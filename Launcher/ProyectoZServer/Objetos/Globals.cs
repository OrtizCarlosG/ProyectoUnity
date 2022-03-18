using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoZServer.SQL;
namespace ProyectoZServer
{
    class Globals
    {

        private static Form1 _form;

        private static string _sqlUser;
        private static string _sqlServer;
        private static string _sqlPass;
        private static string _sqlDB;

        private static SQLCon _SQL = new SQLCon();

        public static void setForm(Form1 form)
        {
            _form = form;
        }

        public static Form1 getForm()
        {
            return _form;
        }

        public static void setSQLData(string server, string user, string password, string db)
        {
            _sqlServer = server;
            _sqlUser = user;
            _sqlPass = password;
            _sqlDB = db;
        }

        public static SQLCon getSQL()
        {
            return _SQL;
        }
    }
}
