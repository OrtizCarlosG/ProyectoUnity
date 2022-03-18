using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoZServer.Objetos
{
   public  class AccountPlay
    {
        public static bool doesAccountExists(string user)
        {
            bool exists = false;
            string commandText = "SELECT * FROM AccountStatus WHERE Account = @user";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool doesHWIDExists(string hwid)
        {
            bool exists = false;
            string commandText = "SELECT * FROM AccountStatus WHERE HWID = @hwid";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool insertNewAccountStatus(string ip, string hwid, string account, string code)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO AccountStatus (Account,HWID,LastIP,Status,LastPlay,Code,Activity) values (@usuario, @HWID,@ip,@status,@date,@code,@activity)";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = account;
            command.Parameters.Add("@HWID", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@ip", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = DateTime.Now;
            command.Parameters.Add("@code", SqlDbType.VarChar, 15).Value = code;
            command.Parameters.Add("@activity", SqlDbType.VarChar, 15).Value = "IN LAUNCHER";
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public static void updateAccountPlay(string user, string hwid, string ip, DateTime lastLogin, bool status, string code, string activity)
        {
            string commandText = "UPDATE AccountStatus SET HWID = @hwid, LastIP = @ip, Status = @status, LastPlay = @login, Code = @code, Activity = @activity WHERE Account = @user";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            command.Parameters.Add("@ip", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@login", SqlDbType.SmallDateTime).Value = lastLogin;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = status;
            command.Parameters.Add("@code", SqlDbType.VarChar, 15).Value = code;
            command.Parameters.Add("@activity", SqlDbType.VarChar, 15).Value = activity;
            command.ExecuteNonQuery();
        }
    }
}
