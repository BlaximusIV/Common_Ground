using System;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class ActivityType
    {
        public int ActivityTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public ActivityType()
        {
            ActivityTypeID = 0;
        }
        public ActivityType(int id)
        {
            ActivityTypeID = id;
        }
        public ActivityType(SqlDataReader rdr)
        {
            ActivityTypeID = rdr["ActivityTypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ActivityTypeID"]);
            Name = rdr["Name"] == DBNull.Value ? String.Empty : rdr["Name"].ToString();
            Description = rdr["Description"] == DBNull.Value ? String.Empty : rdr["Description"].ToString();
        }
    }
}
