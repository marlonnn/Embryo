using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress.SysClass
{
    [Serializable]
    public class User
    {
        public enum UserRoleType
        {
            NormalUser = 0,
            Administrator = 1,
            ServiceEnginner = 2,
        }

        private string _userName;
        /// <summary>
        /// gets or sets user name
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private UserRoleType _userRole;
        public UserRoleType UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        private string _userPassword;
        /// <summary>
        /// gets or sets user password
        /// </summary>
        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        private string _userGUID;
        public string UserGUID
        {
            get
            {
                return _userGUID;
            }
            set
            {
                if (_userGUID == null || _userGUID == string.Empty)
                {
                    _userGUID = value;
                }
            }
        }

        private string _uiCulture;
        public string UICulture
        {
            get { return this._uiCulture; }
            set
            {
                if (_uiCulture == value) return;
                _uiCulture = value;
                if (Program.SysConfig != null && Program.SysConfig.LoginUser == this)
                {
                    OnPropertyChanged(() => UICulture);
                }
            }
        }

        private string _defaultDataFolder;
        /// <summary>
        /// gets or sets user data root folder
        /// </summary>
        public string DefaultDataFolder
        {
            get { return _defaultDataFolder; }
            set
            {
                if (_defaultDataFolder == value) return;
                _defaultDataFolder = value;
            }
        }

        public User(string userName, string userPassword, UserRoleType userRole)
        {
            UserName = userName;
            UserPassword = userPassword;
            UserRole = userRole;
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged<T>(Expression<Func<T>> propertyId)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(((MemberExpression)propertyId.Body).Member.Name));
            }
        }

        private void SetDefault()
        {
            DefaultDataFolder = GetDefaultDataFolder();

            _uiCulture = string.Empty;   // will be set to meaningful value when get it first time
        }
        private string GetDefaultDataFolder()
        {
            string fileUserName = BaseFunction.ReplacePathInvalidChar(UserName);
            string path = BaseFunction.GetPublicPath() + "\\{0} Data" + "\\" + fileUserName;
            path = string.Format(path, Names.ProductNameWithoutTM);
            //BaseFunction.CreateDirectory(path); Create when login
            return path;
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
            // after user name is set
            if (string.IsNullOrEmpty(DefaultDataFolder)) DefaultDataFolder = GetDefaultDataFolder();

            // for previous file
            if (UserConfig.IsServiceengineer(UserName))
            {
                UserRole = UserRoleType.ServiceEnginner;
            }
            else if (UserConfig.IsSystemAdmin(UserName))
            {
                UserRole = UserRoleType.Administrator;
            }
        }
    }

    [Serializable]
    public class UserConfig
    {
        private int _maxUserNum = Int32.MaxValue;
        private readonly string serviceUser = "SERVICEENGINEER";
        private readonly string adminUser = "ADMINISTRATOR";

        private List<User> _list;

        private void DeleteUser(User user)
        {
            _list.Remove(user);
        }

        public IEnumerable<User> GetAllUserWithoutGUID()
        {
            return _list.Where(n => n.UserGUID == null);
        }

        public User GetUserByGuid(string guid)
        {
            User user = null;
            foreach (User item in _list)
            {
                if (item.UserGUID == guid)
                {
                    user = item;
                }
            }
            return user;
        }

        /// <summary>
        /// get all users sorted
        /// </summary>        
        public List<User> GetSortedUsers(bool includeServiceUser)
        {
            List<User> users = new List<User>();
            foreach (User item in _list)
            {
                var user = item;
                if (user.UserName.ToUpper() != serviceUser || includeServiceUser)
                {
                    users.Add(user);
                }
            }
            users.Sort((x, y) => string.Compare(x.UserName, y.UserName));
            return users;
        }

        private User _loginUser;
        /// <summary>
        /// gets or sets login user
        /// </summary>
        public User LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }

        public UserConfig()
        {
            _list = new List<User>();
            _list.Add(new User(serviceUser.ToLower(), "sErvicEnginEr", User.UserRoleType.ServiceEnginner));
            _list.Add(new User(adminUser.ToLower(), adminUser.ToLower(), User.UserRoleType.Administrator));
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext sc)
        {
            //if (_rootUserGroup == null) _rootUserGroup = UserGroup.CreateRootGroup();

            if (_list[0].UserName.ToUpper() == serviceUser)
            {
                _list[0].UserPassword = "sErvicEnginEr";
            }
            _maxUserNum = Int32.MaxValue;

            // in case something wrong, _list should always contains _loginUser
            if (_loginUser != null && !_list.Contains(_loginUser))
            {
                _loginUser = null;
            }
        }

        public bool AddUser(string userName, string userPassword1, string userPassword2, User.UserRoleType userRole)
        {
            if (_list.Count >= _maxUserNum)
            {
                MessageBox.Show(Res.User.StrAddUser_TooMany, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            userName = userName.Trim();

            string userNameNew = GetRidOfSpecialChars(userName);
            if (userNameNew != userName)
            {
                MessageBox.Show(Res.User.StrAddUser_Characters, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (userName.Length > 32 || userName.Length < 1)
            {
                MessageBox.Show(Res.User.StrAddUser_NameTooLong, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsUserExist(userName))
            {
                MessageBox.Show(Res.User.StrAddUser_Exist, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (userPassword1 != userPassword2)
            {
                MessageBox.Show(Res.User.StrAddUser_PasswordError, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _list.Add(new User(userName, userPassword1, userRole));
            return true;

        }

        protected string GetRidOfSpecialChars(string userInput)
        {
            return userInput;	// allow all charactors for user name
            string userOutput = string.Empty;
            char[] charInput = userInput.ToCharArray();

            for (int i = 0; i < userInput.Length; i++)
            {
                char ch = charInput[i];
                if ('0' <= ch && ch <= '9' || 'A' <= ch && ch <= 'Z' || 'a' <= ch && ch <= 'z' || ch == '_' || ch == ' ') userOutput += ch.ToString();
            }
            return userOutput;
        }

        public bool IsUserExist(string userName)
        {
            if (userName == string.Empty || userName == null)
            {
                return false;
            }
            foreach (User item in _list)
            {
                if ((item.UserName).ToUpper() == userName.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsServiceengineerLogin()
        {
            return IsServiceengineer(LoginUser.UserName);
        }

        public bool IsPasswordOk(string userName, string strPassword)
        {
            User user = _list.Find(u => u.UserName == userName);
            if (user == null)
            {
                MessageBox.Show(Res.User.StrLogin_UserError, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (strPassword == user.UserPassword)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Res.User.StrLogin_Error, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        /// is specified user's role is administrator or service engineer
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsAdminUser(string userName)
        {
            //return userName.ToUpper() == serviceUser || userName.ToUpper() == adminUser;
            return GetUserFromName(userName).UserRole == User.UserRoleType.Administrator || GetUserFromName(userName).UserRole == User.UserRoleType.ServiceEnginner;
        }

        /// <summary>
        /// is specified user name is service engineer
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool IsServiceengineer(string userName)
        {
            return userName.ToUpper() == "SERVICEENGINEER";
        }

        /// <summary>
        /// is specified user name is system defined administrator
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool IsSystemAdmin(string userName)
        {
            return userName.ToUpper() == "ADMINISTRATOR";
        }

        public User GetUserFromName(string userName)
        {
            return _list.Find(u => u.UserName == userName);
        }

        /// <summary>
        /// merge user fields
        /// </summary>
        /// <param name="userOrigin"></param>
        /// <param name="userModified"></param>
        /// <param name="userNewer"></param>
        /// <param name="takeModifiedGroup">if take user group tree from modified</param>
        public static void SetUser(User userOrigin, User userModified, User userNewer, bool takeModifiedGroupTree)
        {
            FieldInfo[] userFields = userModified.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo userField in userFields)
            {
                if (userField != null && (userField.Attributes & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
                {
                    CustomAttrs attr = (CustomAttrs)Attribute.GetCustomAttribute(userField, typeof(CustomAttrs));
                    object origin = userOrigin == null ? null : userField.GetValue(userOrigin);
                    object modified = userField.GetValue(userModified);
                    object newer = userField.GetValue(userNewer);
                    if (attr != null && !attr.IfEntirelyModify)
                    {
                        object mergedField = SysConfig.MergeField(origin, modified, newer);
                        userField.SetValue(userNewer, mergedField);
                    }
                    else
                    {
                        if (!SysConfig.FieldEqual(origin, modified))
                        {
                            userField.SetValue(userNewer, modified);
                        }
                    }
                }
            }
        }

        public static UserConfig MergeUserConfig(UserConfig userConfigModified, UserConfig userConfigOrigin, UserConfig userConfigNewer)
        {
            // for user group tree, does not merge it, it is too complicated
            // either take modified one or newer one
            bool takeModifiedUserGroupTree = false;

            foreach (User userModified in userConfigModified._list)
            {
                User userOrigin = userConfigOrigin.GetUserByGuid(userModified.UserGUID);
                if (userOrigin != null)//user exists in userConfig and userConfigOrigin
                {
                    User userNewer = userConfigNewer.GetUserByGuid(userModified.UserGUID);
                    if (userNewer != null)//user exists in all
                    {
                        SetUser(userOrigin, userConfigModified.GetUserByGuid(userModified.UserGUID), userNewer, takeModifiedUserGroupTree);
                    }
                    else
                    {
                        //DO NOTHING: The user has been deleted before
                    }
                }
                else
                {
                    if (userConfigNewer.GetUserByGuid(userModified.UserGUID) != null)//user exists in userConfig and userConfigNewer
                    {
                        SetUser(userOrigin, userConfigModified.GetUserByGuid(userModified.UserGUID), userConfigNewer.GetUserByGuid(userModified.UserGUID), takeModifiedUserGroupTree);
                    }
                    else
                    {
                        userConfigNewer._list.Add(userModified);
                    }
                }
                userConfigOrigin.DeleteUser(userOrigin);
            }
            if (userConfigOrigin._list.Count > 0)
            {
                foreach (User userOrigin in userConfigOrigin._list)
                {
                    if (userConfigNewer.GetUserByGuid(userOrigin.UserGUID) != null)//user exists in userConfigOrigin and userConfigNewer
                    {
                        userConfigNewer.DeleteUser(userConfigNewer.GetUserByGuid(userOrigin.UserGUID));
                    }
                }
            }

            // make sure no duplicate user name after merge
            var existsName = new List<string>();
            foreach (User user in userConfigNewer._list)
            {
                user.UserName = BaseFunction.GeDuplicateName(user.UserName, existsName);
                existsName.Add(user.UserName);
            }

            return userConfigNewer;
        }
    }
}
