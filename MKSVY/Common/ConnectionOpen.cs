using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MKSVY.Common
{
    public class ConnectionOpen
    {

        public static MySqlConnection OpenConn()
        {
            string conn_string = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

            MySqlConnection MyCon = new MySqlConnection(conn_string.ToString());

            MyCon.Open();

            return MyCon;

        }

        public static void CloseConn(MySqlConnection MyCon)
        {
            if (MyCon != null)
            {
                if (MyCon.State == System.Data.ConnectionState.Open)
                {
                    MyCon.Close();
                }
            }
        }
        
    }
}