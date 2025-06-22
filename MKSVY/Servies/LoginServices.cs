using MKSVY.Common;
using MKSVY.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MKSVY.Servies
{
    public class LoginServices
    {
        public static List<Login> GetLoginDetails(string userName,string password)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<Login> logins = new List<Login>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginDetails";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getUserId", userName);
                cmd.Parameters.AddWithValue("@getPassword", password);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Login login = new Login
                    {
                        LOGIN_ID = reader["LOGIN_ID"].ToString(),
                        LOGIN_NAME = reader["LOGIN_NAME"].ToString(),
                        PASSWORD = reader["PASSWORD"].ToString(),
                    };
                    logins.Add(login);
                   // Login.Add(new DataPoint(" ", 1, " #808080", " "));
                    //dataPoints.Add(new DataPoint("Completed", 0, "#228B22", "Completed")); //Convert.ToInt32(reader["Completed"])
                    //dataPoints.Add(new DataPoint("Pending",0 , "#FFD142", "Pending"));//Convert.ToInt32(reader["Pending"])
                    //dataPoints.Add(new DataPoint("Not Yet To Start",0 , "#FF4255", "Yet To Start"));// Convert.ToInt32(reader["Yet_To_Start"])
                }

                //MyCon.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ConnectionOpen.CloseConn(MyCon);
            }

            return logins;
        }
    }
}