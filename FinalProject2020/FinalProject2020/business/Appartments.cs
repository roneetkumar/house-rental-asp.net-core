using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Lab1_final.DataAccess;
using System.Data.SqlClient;

namespace Lab1_final.business
{
    public class Appartment
    {
        //private class variables
        private int appartmentId;
        private int numberOfRoom;
        private int numberOfBath;
        private int numberOfParking;
        private int floorNum;
        private int pricePerMonth;
        private string description;
        private string rentStatus;
        private int buildingId;

        //public methods
        public int AppartmentId { get => appartmentId; set => appartmentId = value; }
        public int NumberOfRoom { get => numberOfRoom; set => numberOfRoom = value; }
        public int NumberOfBath { get => numberOfBath; set => numberOfBath = value; }
        public int NumberOfParking { get => numberOfParking; set => numberOfParking = value; }
        public int FloorNum { get => floorNum; set => floorNum = value; }
        public int PricePerMonth { get => pricePerMonth; set => pricePerMonth = value; }
        public string Description { get => description; set => description = value; }
        public string RentStatus { get => rentStatus; set => rentStatus = value; }
        public int BuildingId { get => buildingId; set => buildingId = value; }


        public List<Appartment> SearchAppartments(SqlDataReader reader)
        {
            return AppartmentDB.SearchRecords(reader);
        }
    }
}