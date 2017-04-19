using System;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class IndividualType
    {
        public int IndividualTypeID { get; set; }
        public string Name { get; set; }


        public IndividualType()
        {
            IndividualTypeID = 0;
        }
        public IndividualType(int id)
        {
            IndividualTypeID = id;
        }
        public IndividualType(SqlDataReader rdr)
        {
            IndividualTypeID = rdr["IndividualTypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualTypeID"]);
            Name = rdr["Name"] == DBNull.Value ? String.Empty : rdr["Name"].ToString();
        }
    }
}
