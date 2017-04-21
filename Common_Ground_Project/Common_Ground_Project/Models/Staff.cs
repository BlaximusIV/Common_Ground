using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public Individual Individual { get; set; }
        public string Username { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public int PermissionID { get; set; }
        public bool IsEligibleDriver { get; set; }
        public bool IsEmployeed { get; set; }


        public Staff()
        {
            StaffID = 0;
        }
        public Staff(int id)
        {
            StaffID = id;
        }
        public Staff(SqlDataReader rdr)
        {
            Individual = new Individual(rdr);
            StaffID = Individual.IndividualID;
            Username = rdr["Username"] == DBNull.Value ? String.Empty : rdr["Username"].ToString();
            HireDate = rdr["HireDate"] == DBNull.Value ? new DateTime(1900,1,1) : Convert.ToDateTime(rdr["HireDate"]);
            LeaveDate = rdr["LeaveDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["LeaveDate"]);
            PermissionID = rdr["PermissionID"] == DBNull.Value ? 1 : Convert.ToInt32(rdr["PermissionID"]);
            IsEligibleDriver = rdr["IsEligibleDriver"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsEligibleDriver"]);
            IsEmployeed = rdr["IsEmployeed"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsEmployeed"]);
        }
    }
}
