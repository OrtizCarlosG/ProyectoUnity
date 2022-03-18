using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZServer.Objetos
{
    public class Login
    {

        public static bool doesAccountExists(string user)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Accounts WHERE Account = @user";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool doesEmailExists(string email)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Accounts WHERE Email = @email";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool checkAccout(string user, string password)
        {
            bool canLog = false;
            string commandText = "SELECT * FROM Accounts WHERE Account = @user AND Password = @pass";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = password;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canLog = true;
            }
            return canLog;
        }

        public static int getAccountTrys(string ip, string hwid, string account)
        {
            int trys = 0;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQL().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM TryLogins WHERE IP= @ip AND HWID = @hwid AND Account = @usuario";
            sqlCmd.Parameters.Add("@ip", SqlDbType.VarChar, 15).Value = ip;
            sqlCmd.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = account;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    trys = Int32.Parse(reader[4].ToString());
                }
            }
            return trys;
        }

        public static string getAccountProfile(string account)
        {
            string image = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQL().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Accounts WHERE Account = @usuario";
            sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = account;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    image = reader[10].ToString();
                }
            }
            return image;
        }

        public static bool insertNewLoginTry(string ip, string hwid, string account, int tryn)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO TryLogins (IP,HWID,Account,Try,MAX_TRY) values (@IP, @HWID,@usuario,@try,'5')";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@IP", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@HWID", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = account;
            command.Parameters.Add("@try", SqlDbType.Int).Value = tryn;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public static void updateLoginData(string user, string hwid, string ip, DateTime lastLogin)
        {
            string commandText = "UPDATE Accounts SET HWID = @hwid, ip = @ip, LastLogin = @login WHERE Account = @user";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            command.Parameters.Add("@ip", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@login", SqlDbType.SmallDateTime).Value = lastLogin;
            command.ExecuteNonQuery();
        }

        public static void updateProfileImage(string user, string image)
        {
            string commandText = "UPDATE Accounts SET ProfileImage = @image WHERE Account = @user";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = user;
            command.Parameters.Add("@image", SqlDbType.VarChar).Value = image;
            command.ExecuteNonQuery();
        }

    }
}
