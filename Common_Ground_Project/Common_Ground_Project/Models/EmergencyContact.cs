using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    class EmergencyContact
    {
        public int EmergencyContactID { get; set; }
        public int IndividualID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public EmergencyContact()
        {
            EmergencyContactID = 0;
        }
        public EmergencyContact(int id)
        {
            EmergencyContactID = id;
        }
        public EmergencyContact(SqlDataReader rdr)
        {
            EmergencyContactID = rdr["EmergencyContactID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["EmergencyContactID"]);
            IndividualID = rdr["IndividualID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualID"]);
            Name = rdr["Name"] == DBNull.Value ? String.Empty : rdr["Name"].ToString();
            Phone = rdr["Phone"] == DBNull.Value ? String.Empty : rdr["Phone"].ToString();
            Email = rdr["Email"] == DBNull.Value ? String.Empty : rdr["Email"].ToString();
        }
    }
}
