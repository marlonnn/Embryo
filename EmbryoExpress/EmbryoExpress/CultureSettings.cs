using EmbryoExpress.SysClass;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress
{
    internal static class CultureSettings
    {
        // save the system default culture name, we use it as user's default UI culture
        private static string _sysDefault = "";

        // save the system default thread current culture
        private static CultureInfo _defaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // save the system default thread current ui culture
        private static CultureInfo _defaultThreadCurrentUICulture = new CultureInfo("en-US");

        /// <summary>
        /// initial application main thread culture, set default thread current culture for .Net 4.5 and above
        /// the current culture is based on invariant culture (English), and current system date time and number format
        /// </summary>
        internal static void InitalAppCulture()
        {
            var sys = Thread.CurrentThread.CurrentCulture;  // system default (settings in control panel/region and language/format)
            _sysDefault = sys.Name;

            var culture = new CultureInfo("");           // invariant culture (English)

            // copy date time format and number format from system default
            culture.DateTimeFormat = sys.DateTimeFormat;
            culture.NumberFormat = sys.NumberFormat;

            // set application main thread culture to invariant culture, so that string compare and serialize are consistent
            Application.CurrentCulture = culture;

            // set CultureInfo.DefaultThreadCurrentCulture if above or equal to .net 4.5
            // new Thread should be set the current culture explicitly anyway for .net 4.0
            System.Reflection.PropertyInfo pt = typeof(CultureInfo).GetProperty("DefaultThreadCurrentCulture");
            if (pt != null) pt.SetValue(null, culture, null);
            _defaultThreadCurrentCulture = culture;
        }

        /// <summary>
        /// return the default UICulture name (according to control panel language and region format setting)
        /// </summary>
        internal static string GetDefaultUICulture()
        {
            return GetValidUICulture(_sysDefault);
        }

        /// <summary>
        /// get valid culture for specified culture name, will check the availability of correspond resource dll,
        /// currently only zh-CN and en-US supports
        /// </summary>
        /// <param name="cultureName"></param>
        /// <returns></returns>
        internal static string GetValidUICulture(string cultureName)
        {
            return cultureName == "zh-CN" && BaseFunction.ChineseEdition ? cultureName : "en-US";
        }

        /// <summary>
        /// set the UICulture of application, set last login user's config if not login yet
        /// and save UICulture to login user
        /// </summary>
        /// <param name="sysConfig">null to set system default UICulture</param>
        /// <param name="culture">null if using the last or current login user's config</param>
        internal static void SetAppUICulture(SysConfig sysConfig, string culture)
        {
            if (culture == null)
            {
                // get the login user's UICultrue if login user is not null (could be last login user)
                if (sysConfig != null && sysConfig.LoginUser != null)
                    culture = sysConfig.LoginUser.UICulture;
                // otherwise get the default UICultrue
                if (string.IsNullOrEmpty(culture)) culture = GetDefaultUICulture();
            }
            // make sure UICulture valid
            culture = GetValidUICulture(culture);

            // set current thread UICulture
            var ui = Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            // set CultureInfo.DefaultThreadCurrentUICulture if above or equal to .net 4.5
            // new Thread should be set the current UIculture explicitly anyway for .net 4.0
            System.Reflection.PropertyInfo pt = typeof(CultureInfo).GetProperty("DefaultThreadCurrentUICulture");
            if (pt != null) pt.SetValue(null, ui, null);
            _defaultThreadCurrentUICulture = ui;

            // reset MessageBoxManager's text after UICulture changes
            MessageBoxManager.Reset();

            // set the login user's config and raise event
            if (sysConfig != null && sysConfig.LoginUser != null)
            {
                sysConfig.LoginUser.UICulture = culture;
            }
        }

        /// <summary>
        /// gets if current UICulture is zh-CN
        /// </summary>
        internal static bool IsZhCnUICulture
        {
            get { return Thread.CurrentThread.CurrentUICulture.Name == "zh-CN"; }
        }

        /// <summary>
        /// set default thread current ui culture and culture, necessary for .Net 4.0 and below
        /// </summary>
        /// <param name="uiCulture"></param>
        internal static void SetThreadCultureAndUICultrue()
        {
            Thread.CurrentThread.CurrentUICulture = _defaultThreadCurrentUICulture;
            Thread.CurrentThread.CurrentCulture = _defaultThreadCurrentCulture;
        }
    }
}
