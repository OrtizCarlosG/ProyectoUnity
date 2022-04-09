using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoZLauncher.Connections;
namespace ProyectoZLauncher.Objetos
{
    class Globals
    {

        private static MenuForm _menu;
        private static LoginForm _loginForm;
        private static RegisterForm _registerForm;
        private static GameForm _gameForm;

        public static string ServerURL = "http://localhost/ProyectoZ/";
        public static string PatchlistName = "updateList.txt";
        public static string BinaryName = "ProyectoZ.exe";

        public static List<File> Files = new List<File>();
        public static List<string> OldFiles = new List<string>();

        public static long fullSize;
        public static long completeSize;

        public static string _ClientKey;

        public struct File
        {
            public string Name;
            public string Hash;
            public long Size;
        }

        static Timer _timer1;

        public static GameForm getGameForm()
        {
            return _gameForm;
        }

        public static void setGameForm(GameForm _form)
        {
            _gameForm = _form;
        }
        public static void startTimer()
        {
            _timer1 = new Timer();
            _timer1.Interval = 1;
            _timer1.Start();
            _timer1.Tick += new EventHandler(timer1Tick);
        }

        private static void timer1Tick(object sender, EventArgs e)
        {
            ThreadManager.UpdateMain();
        }

        public static void setLoginForm(LoginForm _form)
        {
            _loginForm = _form;
        }

        public static LoginForm getLoginForm()
        {
            return _loginForm;
        }

        public static void setMenu(MenuForm form)
        {
            _menu = form;
        }

        public static MenuForm getMenu()
        {
            return _menu;
        }

        public static void setRegisterForm(RegisterForm _form)
        {
            _registerForm = _form;
        }

        public static RegisterForm getRegisterForm()
        {
            return _registerForm;
        }

        public static void Notify(string msg, string tittle, Notificaciones.alertTypeEnum _type)
        {
            Notificaciones notificaciones = new Notificaciones();
            notificaciones.ShowInTaskbar = false;
            notificaciones.BringToFront();
            notificaciones.TopMost = true;
            notificaciones.setAlert(msg, tittle, _type);
        }

        public static string getCPUId()
       {
           string cpuInfo = string.Empty;
           ManagementClass mc = new ManagementClass("win32_processor");
           ManagementObjectCollection moc = mc.GetInstances();
       
           foreach (ManagementObject mo in moc)
           {
               if (cpuInfo == "")
               {
                   //Get only the first CPU's ID
                   cpuInfo = mo.Properties["processorID"].Value.ToString();
                   break;
               }
           }
           return cpuInfo;
       }
    }
}
