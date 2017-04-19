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
        public int ActivityID { get; set; }
        public string Title { get; set; }
        public int TripLeaderID { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime DropOffTime { get; set; }
        public DateTime StaffArrivalTime { get; set; }
        public string Location { get; set; }
        public Decimal Cost { get; set; }

        public List<Individual> IndividualList { get; set; }
        public List<Vehicle> VehicleList { get; set; }
        public List<ActivityNote> ActivityNoteList { get; set; }

        public Activity()
        {
            ActivityID = 0;
        }
        public Activity(int id)
        {
            ActivityID = ActivityID;
        }
        public Activity(SqlDataReader rdr)
        {
            ActivityID = rdr["ActivityID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ActivityID"]);
            Title = rdr["Title"] == DBNull.Value ? String.Empty : rdr["Title"].ToString();
            TripLeaderID = rdr["TripLeaderID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["TripLeaderID"]);
            Description = rdr["Description"] == DBNull.Value ? String.Empty : rdr["Description"].ToString();
            StartDate = rdr["Start_Date"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Start_Date"]);
            EndDate = rdr["End_Date"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["End_Date"]);
            PickUpTime = rdr["Pick_Up_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Pick_Up_Time"]);
            DropOffTime = rdr["Drop_Off_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Drop_Off_Time"]);
            StaffArrivalTime = rdr["Staff_Arrival_Time"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["Staff_Arrival_Time"]);
            Location = rdr["Location"] == DBNull.Value ? String.Empty : rdr["Location"].ToString();
            Cost = rdr["Cost"] == DBNull.Value ? 0.00M : Convert.ToDecimal(rdr["Cost"]);
        }
    }
}
