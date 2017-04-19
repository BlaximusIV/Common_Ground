using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    class Individual
    {
        public int IndividualID { get; set; }
        public int IndividualTypeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsWaiverSigned { get; set; }
        public bool IsMediaReleased { get; set; }
        public bool IsFrequentCaller { get; set; }

        public List<Activity> ActivityList { get; set; }
        public List<EmergencyContact> EmergencyContactList { get; set; }
        public List <IndividualNote> IndividualNoteList { get; set; }
        
        public Individual()
        {
            IndividualID = 0;
        }
        public Individual(int id)
        {
            IndividualID = id;
        }
        public Individual(SqlDataReader rdr)
        {
            IndividualID = rdr["IndividualID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualID"]);
            IndividualTypeID = rdr["IndividualTypeID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualTypeID"]);
            FirstName = rdr["FirstName"] == DBNull.Value ? String.Empty : rdr["FirstName"].ToString();
            LastName = rdr["LastName"] == DBNull.Value ? String.Empty : rdr["LastName"].ToString();
            PhoneNumber = rdr["PhoneNumber"] == DBNull.Value ? String.Empty : rdr["PhoneNumber"].ToString();
            BirthDay = rdr["BirthDay"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["BirthDay"]);
            Email = rdr["Email"] == DBNull.Value ? String.Empty : rdr["Email"].ToString();
            StreetAddress = rdr["StreetAddress"] == DBNull.Value ? String.Empty : rdr["StreetAddress"].ToString();
            City = rdr["City"] == DBNull.Value ? String.Empty : rdr["City"].ToString();
            State = rdr["State"] == DBNull.Value ? String.Empty : rdr["State"].ToString();
            ZipCode = rdr["ZipCode"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ZipCode"]);
            IsWaiverSigned = rdr["IsWaiverSigned"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsWaiverSigned"]);
            IsMediaReleased = rdr["IsMediaReleased"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsMediaReleased"]);
            IsFrequentCaller = rdr["IsFrequentCaller"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsFrequentCaller"]);
           

        }
    }
}
