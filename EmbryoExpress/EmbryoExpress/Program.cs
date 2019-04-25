using EmbryoExpress.SysClass;
using EmbryoExpress.UI;
using EmbryoExpress.UI.UserManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress
{
    static class Program
    {
        private static Mutex mutex = null;
        private static Mutex mutexGlobal = null;    // used start from 1.2.5

        private static double _dpiFactor = 1;
        /// <summary>
        /// system dpi setting, default is 100%
        /// </summary>
        public static double DpiFactor
        {
            get { return _dpiFactor; }
            set { _dpiFactor = value; }
        }


        private static MainForm _mainForm;

        /// <summary>
        /// The reference of program main form
        /// </summary>
        public static MainForm MainForm
        {
            get { return _mainForm; }
        }

        private static SysConfig _sysConfig;

        /// <summary>
        /// The configure information about software and hardware
        /// </summary>
        public static SysConfig SysConfig
        {
            get { return _sysConfig; }
        }

        private static SysConfig _sysConfigOrigin;

        /// <summary>
        /// The original configuration about software and hardware
        /// </summary>
        public static SysConfig SysConfigOrigin
        {
            get { return _sysConfigOrigin; }
        }

        /// <summary>
        /// return major software version with format 1.0.0
        /// </summary>
        public static string MajorVersion
        {
            get
            {
                return BaseFunction.GetMajorVersion(Application.ProductVersion);
            }
        }

        private static bool Initialize()
        {
            System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero);
            DpiFactor = g.DpiX / 96.0;
            g.Dispose();

            _sysConfig = SysConfig.Load();

            //foreach user if guid is null create a guid and save FConfig
            if (_sysConfig.UserConfig.GetAllUserWithoutGUID().Count<User>() != 0)
            {
                foreach (User user in _sysConfig.UserConfig.GetAllUserWithoutGUID())
                {
                    user.UserGUID = Guid.NewGuid().ToString("N");
                }
                SysConfig.Save(_sysConfig);
            }
            _sysConfigOrigin = SysConfig.Load();

            // set CurrentUICultrue of last login user after sysconfig loaded
            CultureSettings.SetAppUICulture(SysConfig, null);

            return true;
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //initial application main thread culture
            CultureSettings.InitalAppCulture();
            // set CurrentUICultrue for user interface before loading sysconfig
            CultureSettings.SetAppUICulture(null, null);

            MiniDumper.Init();

            try
            {
                // set the process to real time priority
                var p = System.Diagnostics.Process.GetCurrentProcess();
                p.PriorityClass = ProcessPriorityClass.High;
            }
            catch (System.Exception)
            {

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // show splash screen once started
            SplashScreenForm.ShowSplash();

            Initialize();

            bool login = Program.SysConfig.AutoLogin && Program.SysConfig.LoginUser != null;    // check if auto login
            if (!login) // show login window
            {
                SplashScreenForm.CloseSplash();
                using (var form = new Login())
                    login = form.ShowDialog() == DialogResult.OK;
            }

            // after login
            if (login)
            {
                // set UI culture after login
                CultureSettings.SetAppUICulture(Program.SysConfig, null);

                BaseFunction.CreateDirectory(Program.SysConfig.LoginUser.DefaultDataFolder);

                RunMainForm();
            }

            if (_mainForm != null && _mainForm.ToRestart)
            {
                //_mainForm.Activate();
                Application.Restart();
            }

            MessageBoxManager.Unregister();
        }


        static void RunMainForm()
        {
            //Set work directory
            try { System.IO.Directory.SetCurrentDirectory(_sysConfig.LoginUser.DefaultDataFolder); }
            catch { }

            _mainForm = new MainForm();

            SplashScreenForm.CloseSplash();
            if (!_mainForm.IsDisposed && !_mainForm.ToRestart)
            {
                Application.Run(_mainForm);
            }

            try
            {
                if (mutex != null)
                {
                    mutex.ReleaseMutex();
                }
                if (mutexGlobal != null)
                {
                    mutexGlobal.ReleaseMutex();
                }
            }
            catch
            {
            }
        }

        static bool CreateMutex()
        {
            // mutex name
            string name = "b64b2340-84dc-454d-81e6-1123ccd445b2";

            // try to obtain the local mutex used before 1.2.5
            bool result = false;
            mutex = new Mutex(true, name, out result);

            // try to obatin the global mutex used start from 1.2.5
            if (result) mutexGlobal = new Mutex(true, "Global\\" + name, out result);

            return result;
        }

        static void ReleasMutex()
        {
            if (mutex != null)
            {
                mutex.Close();
                mutex = null;
            }
            if (mutexGlobal != null)
            {
                mutexGlobal.Close();
                mutexGlobal = null;
            }
        }

    }
}
