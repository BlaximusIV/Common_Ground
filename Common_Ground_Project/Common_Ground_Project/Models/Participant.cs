using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Participant
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
        public string EmergencyPhone { get; set; }
        public string EmergencyEmail { get; set; }
        public bool IsWaiverSigned { get; set; }
        public bool IsMediaReleased { get; set; }
        public bool IsFrequentCaller { get; set; }
        public string Note { get; set; }

        public Participant()
        {
            ID = 0;
        }
        public Participant(int id)
        {
            ID = id;
        }
        public Participant(SqlDataReader rdr)
        {
            ID = rdr["personID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["personID"]);
            FirstName = rdr["firstName"] == DBNull.Value ? String.Empty : rdr["firstName"].ToString();
            LastName = rdr["lastName"] == DBNull.Value ? String.Empty : rdr["lastName"].ToString();
            PhoneNumber = rdr["phoneNumber"] == DBNull.Value ? String.Empty : rdr["phoneNumber"].ToString();
            BirthDay = rdr["DOB"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["DOB"]);
            EmailAddress = rdr["email"] == DBNull.Value ? String.Empty : rdr["email"].ToString();
            StreetAddress = rdr["streetAddress"] == DBNull.Value ? String.Empty : rdr["streetAddress"].ToString();
            City = rdr["City"] == DBNull.Value ? String.Empty : rdr["City"].ToString();
            State = rdr["residentState"] == DBNull.Value ? String.Empty : rdr["residentState"].ToString();
            ZipCode = rdr["zip"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["zip"]);
            EmergencyContact = rdr["emergencyContact"] == DBNull.Value ? String.Empty : rdr["emergencyContact"].ToString();
            EmergencyPhone = rdr["Emergency_Phone"] == DBNull.Value ? String.Empty : rdr["Emergency_Phone"].ToString();
            EmergencyEmail = rdr["Emergency_Email"] == DBNull.Value ? String.Empty : rdr["Emergency_Email"].ToString();
            IsWaiverSigned = rdr["Waiver_Signed"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Waiver_Signed"]);
            IsMediaReleased = rdr["Media_Release"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Media_Release"]);
            IsFrequentCaller = rdr["Frequent_Caller"] == DBNull.Value ? false : Convert.ToBoolean(rdr["Frequent_Caller"]);
            Note = rdr["notes"] == DBNull.Value ? String.Empty : rdr["notes"].ToString();

            IsFrequentCaller = false;
            IsMediaReleased = false;
            IsWaiverSigned = false;
        }
    }
}
