using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZServer.Objetos
{
    class Register
    {
        public static bool insertNewAccount(string account, string password, string email, string hwid, string ip, DateTime _lastLogin, string image)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO Accounts (Account,Password,Email,HWID,IP,LastLogin,AccountLevel,ProfileImage) values (@user, @pass,@email,@hwid,@ip,@lastLogin,@accLevel,@image)";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = account;
            command.Parameters.Add("@pass", SqlDbType.VarChar, 11).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
            command.Parameters.Add("@IP", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@HWID", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@lastLogin", SqlDbType.SmallDateTime).Value = _lastLogin;
            command.Parameters.Add("@accLevel", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@image", SqlDbType.VarChar).Value = image;
            // command.Parameters.Add("@admin", SqlDbType.Bit).Value = false;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }
    }
}
