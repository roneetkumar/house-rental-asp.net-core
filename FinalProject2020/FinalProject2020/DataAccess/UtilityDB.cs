using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1_final.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection {

                ConnectionString="server = WZUN\\MSSQLSERVER2017; database = PropertyRentalDB; user = sa; password = Admin#admin"
                //ConnectionString = ConfigurationManager.ConnectionStrings["PropertyRentalDBConnection"].ConnectionString
            };
            conn.Open();
            return conn;
        }
    }
}