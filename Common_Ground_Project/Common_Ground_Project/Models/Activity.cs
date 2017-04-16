using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string TripLeader { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime DropOffTime { get; set; }
        public DateTime StaffArrivalTime { get; set; }
        public string Location { get; set; }
        public Decimal Cost { get; set; }
        public bool Vehicle1 { get; set; }
        public bool Vehicle2 { get; set; }
        public bool Vehicle3 { get; set; }
        public bool Vehicle4 { get; set; }
        public bool Vehicle5 { get; set; }
        public bool Vehicle6 { get; set; }
        public bool Vehicle7 { get; set; }
        public bool Vehicle8 { get; set; }
        public bool Vehicle9 { get; set; }
        public string Note { get; set; }

        public Activity()
        {
            ID = 0;
        }
        public Activity(int id)
        {
            ID = id;
        }
        public Activity(SqlDataReader rdr)
        {
            ID = rdr["ActivityID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ActivityID"]);
            Title = rdr["Title"] == DBNull.Value ? String.Empty : rdr["Title"].ToString();
            TripLeader = rdr["Trip_Leader"] == DBNull.Value ? String.Empty : rdr["Trip_Leader"].ToString();
            Description = rdr["Description"] == DBNull.Value ? String.Empty : rdr["Description"].ToString();
            StartDate = rdr["Start_Date"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Start_Date"]);
            EndDate = rdr["End_Date"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["End_Date"]);
            StartTime = rdr["Start_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Start_Time"]);
            EndTime = rdr["End_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["End_Time"]);
            PickUpTime = rdr["Pick_Up_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Pick_Up_Time"]);
            DropOffTime = rdr["Drop_Off_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Drop_Off_Time"]);
            StaffArrivalTime = rdr["Staff_Arrival_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Staff_Arrival_Time"]);
            Location = rdr["Location"] == DBNull.Value ? String.Empty : rdr["Location"].ToString();
            Cost = rdr["Cost"] == DBNull.Value ? 0.00M : Convert.ToDecimal(rdr["Cost"]);
            Note = rdr["Notes"] == DBNull.Value ? String.Empty : rdr["Notes"].ToString();
            Vehicle1 = rdr["Vehicle_1"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_1"]);
            Vehicle1 = rdr["Vehicle_2"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_2"]);
            Vehicle1 = rdr["Vehicle_3"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_3"]);
            Vehicle1 = rdr["Vehicle_4"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_4"]);
            Vehicle1 = rdr["Vehicle_5"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_5"]);
            Vehicle1 = rdr["Vehicle_6"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_6"]);
            Vehicle1 = rdr["Vehicle_7"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_7"]);
            Vehicle1 = rdr["Vehicle_8"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_8"]);
            Vehicle1 = rdr["Vehicle_9"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Vehicle_9"]);


        }
    }
}
