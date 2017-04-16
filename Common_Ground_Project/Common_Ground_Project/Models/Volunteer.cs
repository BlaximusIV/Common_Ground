using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public string EmailAddress { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone{ get; set; }
        public string EmergencyEmail { get; set; }
        public bool IsWaiverSigned { get; set; }
        public bool IsMediaReleased { get; set; }
        public bool IsFrequentCaller { get; set; }
        public string Note { get; set; }

        public Volunteer()
        {
            ID = 0;
        }
        public Volunteer(int id)
        {
            ID = id;
        }
        public Volunteer(SqlDataReader rdr)
        {
            ID = rdr["volunteerID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["volunteerID"]);
            FirstName = rdr["First_Name"] == DBNull.Value ? String.Empty : rdr["First_Name"].ToString();
            LastName = rdr["Last_Name"] == DBNull.Value ? String.Empty : rdr["Last_Name"].ToString();
            PhoneNumber = rdr["Phone_Number"] == DBNull.Value ? String.Empty : rdr["Phone_Number"].ToString();
            BirthDay = rdr["DOB"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["DOB"]);
            EmailAddress = rdr["Email"] == DBNull.Value ? String.Empty : rdr["Email"].ToString();
            StreetAddress = rdr["Street_Address"] == DBNull.Value ? String.Empty : rdr["Street_Address"].ToString();
            City = rdr["City"] == DBNull.Value ? String.Empty : rdr["City"].ToString();
            State = rdr["State"] == DBNull.Value ? String.Empty : rdr["State"].ToString();
            ZipCode = rdr["Zip"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["Zip"]);
            EmergencyContact = rdr["Emergency_Contact"] == DBNull.Value ? String.Empty : rdr["Emergency_Contact"].ToString();
            Note = rdr["Notes"] == DBNull.Value ? String.Empty : rdr["Notes"].ToString();
            EmergencyPhone = rdr["Emergency_Phone"] == DBNull.Value ? String.Empty : rdr["Emergency_Phone"].ToString();
            EmergencyEmail = rdr["Emergency_Email"] == DBNull.Value ? String.Empty : rdr["Emergency_Email"].ToString();
            IsWaiverSigned = rdr["Waiver_Signed"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Waiver_Signed"]);
            IsMediaReleased = rdr["Media_Release"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Media_Release"]);

            IsFrequentCaller = false;
            IsMediaReleased = false;
            IsWaiverSigned = false;
        }
    }
}
