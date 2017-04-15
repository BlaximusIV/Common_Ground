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
            ID = rdr[0] == DBNull.Value ? 0 : Convert.ToInt32(rdr[0]);
            FirstName = rdr[2] == DBNull.Value ? String.Empty : rdr[2].ToString();
            LastName = rdr[1] == DBNull.Value ? String.Empty : rdr[1].ToString();
            PhoneNumber = rdr[3] == DBNull.Value ? String.Empty : rdr[3].ToString();
            BirthDay = rdr[15] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr[15]);
            EmailAddress = rdr[4] == DBNull.Value ? String.Empty : rdr[4].ToString();
            StreetAddress = rdr[9] == DBNull.Value ? String.Empty : rdr[9].ToString();
            City = rdr[10] == DBNull.Value ? String.Empty : rdr[10].ToString();
            State = rdr[11] == DBNull.Value ? String.Empty : rdr[11].ToString();
            ZipCode = rdr[12] == DBNull.Value ? 0 : Convert.ToInt32(rdr[12]);
            EmergencyContact = rdr[7] == DBNull.Value ? String.Empty : rdr[7].ToString();
            Note = rdr[13] == DBNull.Value ? String.Empty : rdr[13].ToString();

            IsFrequentCaller = false;
            IsMediaReleased = false;
            IsWaiverSigned = false;
        }
    }
}
