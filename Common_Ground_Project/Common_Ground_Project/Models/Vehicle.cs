using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VIN { get; set; }


        public Vehicle()
        {
            VehicleID = 0;
        }
        public Vehicle(int id)
        {
            VehicleID = id;
        }
        public Vehicle(SqlDataReader rdr)
        {
            VehicleID = rdr["VehicleID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["VehicleID"]);
            Name = rdr["Name"] == DBNull.Value ? String.Empty : rdr["Name"].ToString();
            Description = rdr["Description"] == DBNull.Value ? String.Empty : rdr["Description"].ToString();
            VIN = rdr["VIN"] == DBNull.Value ? String.Empty : rdr["VIN"].ToString();
        }
    }
}
