using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress.SysClass
{
    [Serializable]
    public class SysConfig
    {
        [NonSerialized]
        private static string _filePath = Application.StartupPath + "\\FConfig";

        private bool _autoLogin = false;
        /// <summary>
        /// gets or sets auto login
        /// </summary>
        public bool AutoLogin
        {
            get { return _autoLogin; }
            set { _autoLogin = value; }
        }

        private UserConfig _userConfig;
        /// <summary>
        /// gets the user config
        /// </summary>
        /// <returns></returns>
        public UserConfig UserConfig
        {
            get { return _userConfig; }
            private set { _userConfig = value; }
        }

        public User LoginUser
        {
            get { return _userConfig.LoginUser; }
            set { _userConfig.LoginUser = value; }
        }

        public SysConfig()
        {
            SetDefault();
            SysConfig.Save(this);
        }

        private void SetDefault()
        {
            UserConfig = new UserConfig();
        }

        // set default value
        [OnDeserializing]
        private void OnDeserializing(StreamingContext sc)
        {
            SetDefault();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext sc)
        {

        }

        public static SysConfig Load()
        {
            SysConfig config = null;

            try
            {
                config = config.SerializeFromFile(_filePath);
            }
            catch (Exception e)
            {
                config = new SysConfig();
            }

            return config;
        }

        /// <summary>
        /// do not manually call this function during software, the config should only be saved before software quit
        /// </summary>
        /// <param name="config"></param>
        public static void Save(SysConfig config)
        {
            if (config != null)
            {
                try
                {
                    config.SerializeToFile(_filePath);
                }
                catch (System.Exception)
                {

                }
            }
        }

        public static void Save(SysConfig config, SysConfig configOrigin)
        {
            // new config loaded just before saving
            SysConfig configNewer = SysConfig.Load();

            //merge the sysConfig
            FieldInfo[] fieldsSysConfig = config.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo fieldSysConfig in fieldsSysConfig)
            {
                if (fieldSysConfig == null)
                    continue;

                if (fieldSysConfig.Name == "_userConfig")
                    //merge the userConfig
                    configNewer.UserConfig = UserConfig.MergeUserConfig(config.UserConfig, configOrigin.UserConfig, configNewer.UserConfig);

                if ((fieldSysConfig.Attributes & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
                {
                    object origin = fieldSysConfig.GetValue(configOrigin);
                    object modified = fieldSysConfig.GetValue(config);
                    object newer = fieldSysConfig.GetValue(configNewer);
                    CustomAttrs attr = (CustomAttrs)Attribute.GetCustomAttribute(fieldSysConfig, typeof(CustomAttrs));
                    if (attr != null && !attr.IfEntirelyModify)
                    {
                        object mergedProperty = MergeField(origin, modified, newer);
                        fieldSysConfig.SetValue(configNewer, mergedProperty);
                    }
                    else
                    {
                        if (!FieldEqual(origin, modified))
                        {
                            fieldSysConfig.SetValue(configNewer, modified);
                        }
                    }
                }
            }
            //update the loginUser
            configNewer.LoginUser = config.LoginUser == null ? null : configNewer.UserConfig.GetUserByGuid(config.LoginUser.UserGUID);
            Save(configNewer);
        }

        /// <summary>
        /// compare two serializable objects
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="modified"></param>
        /// <returns></returns>
        public static bool FieldEqual(object origin, object modified)
        {
            return origin == modified || (origin != null && modified != null && modified.SerializeEqual(origin));
        }

        public static Object MergeField(Object objOrigin, Object objModified, Object objNewer)
        {
            if (objModified == objOrigin) return objNewer;      // both null

            if (objOrigin == null || objModified == null || objNewer == null) return objModified;

            FieldInfo[] fields = objModified.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                if (field == null) continue;

                // ignore notserialized field
                if ((field.Attributes & FieldAttributes.NotSerialized) == FieldAttributes.NotSerialized) continue;

                object origin = field.GetValue(objOrigin);
                object modified = field.GetValue(objModified);

                if (!FieldEqual(origin, modified))
                {
                    field.SetValue(objNewer, modified);
                }
            }
            return objNewer;
        }
    }
}
