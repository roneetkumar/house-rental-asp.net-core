using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Lab1_final.business;

namespace Lab1_final.DataAccess
{
    public class AppartmentDB
    {
        ////search function by AppartmentId
        //public static Appartment SearchRecord(int searchId)
        //{
        //    Appartment app = new Appartment();
        //    SqlConnection conn = UtilityDB.ConnectDB();

        //    SqlCommand cmd = new SqlCommand();

        //    cmd.Connection = conn;
        //    cmd.CommandText = "Select * From Appartments where AppartmentId = @AppartmentId ";            
        //    cmd.Parameters.AddWithValue("@AppartmentId", searchId);            

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.Read()) 
        //    {
        //        app.AppartmentId = Convert.ToInt32(reader["EmployeeId"]);
        //        app.NumberOfRoom = Convert.ToInt32(reader["NumberOfRoom"]);
        //        app.NumberOfBath = Convert.ToInt32(reader["NumberOfBath"]);
        //        app.NumberOfParking = Convert.ToInt32(reader["NumberOfParking"]);
        //        app.FloorNum = Convert.ToInt32(reader["FloorNum"]);
        //        app.PricePerMonth = Convert.ToInt32(reader["PricePerMonth"]);
        //        app.Description = Convert.ToString(reader["Description"]);
        //        app.RentStatus = Convert.ToString(reader["RentStatus"]);
        //        app.BuildingId = Convert.ToInt32(reader["BuildingId"]);
        //    }        
        //    else
        //    {
        //        app = null;
        //    }

        //    conn.Close();
        //    return app;
        //}

        //search more than one record by Int

        public static List<Appartment> SearchRecords(SqlDataReader reader)
        {
            List<Appartment> ListApp = new List<Appartment>();
            Appartment app;
                      
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    app = new Appartment();
                    app.AppartmentId = Convert.ToInt32(reader["AppartmentId"]);
                    app.NumberOfRoom = Convert.ToInt32(reader["NumberOfRoom"]);
                    app.NumberOfBath = Convert.ToInt32(reader["NumberOfBath"]);
                    app.NumberOfParking = Convert.ToInt32(reader["NumberOfParking"]);
                    app.FloorNum = Convert.ToInt32(reader["FloorNum"]);
                    app.PricePerMonth = Convert.ToInt32(reader["PricePerMonth"]);
                    app.Description = Convert.ToString(reader["Description"]);
                    app.RentStatus = Convert.ToString(reader["RentStatus"]);
                    app.BuildingId = Convert.ToInt32(reader["BuildingId"]);

                    ListApp.Add(app);
                }
            }
            else
            {
                ListApp = null;
            }
            return ListApp;
        }
    }
}