using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoZServer.Objetos
{
    class Ban
    {
        public static bool isBanned(string hwid)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Ban WHERE HWID = @hwid";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool isPermaBanned(string hwid)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Ban WHERE HWID = @hwid AND isPerm = 'True'";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool insertNewBan(string hwid, string ip, string reason, bool isPermanent, DateTime _until)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO Ban (HWID,IP,Reason,isPerm,Until,Date) values (@HWID, @IP,@reason,@perm,@until,'"+ DateTime.Now +"')";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@IP", SqlDbType.VarChar, 15).Value = ip;
            command.Parameters.Add("@HWID", SqlDbType.VarChar, 25).Value = hwid;
            command.Parameters.Add("@reason", SqlDbType.VarChar, 150).Value = reason;
            command.Parameters.Add("@perm", SqlDbType.Bit).Value = isPermanent;
            command.Parameters.Add("@until", SqlDbType.SmallDateTime).Value = _until;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public static string getBanReason(string hwid)
        {
            string reason = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQL().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Ban WHERE HWID = @hwid";
            sqlCmd.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    reason = reader[3].ToString();
                }
            }
            return reason;
        }

        public static DateTime getUnbanDate(string hwid)
        {
            DateTime date = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQL().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Ban WHERE HWID = @hwid";
            sqlCmd.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    date = DateTime.Parse(reader[5].ToString());
                }
            }
            return date;
        }

        public static bool deleteBan(string hwid)
        {
            bool canInsert = false;
            string commandText = "DELETE FROM Ban WHERE HWID = @hwid";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQL().cnn);
            command.Parameters.Add("@hwid", SqlDbType.VarChar, 25).Value = hwid;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

    }
}
