using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    class IndividualNote
    {
        public int IndividualNoteID { get; set; }
        public int IndividualID { get; set; }
        public string Note { get; set; }
        public DateTime DateTime { get; set; }


        public IndividualNote()
        {
            IndividualNoteID = 0;
        }
        public IndividualNote(int id)
        {
            IndividualNoteID = id;
        }
        public IndividualNote(SqlDataReader rdr)
        {
            IndividualNoteID = rdr["IndividualNoteID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualNoteID"]);
            IndividualID = rdr["IndividualID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["IndividualID"]);
            Note = rdr["Note"] == DBNull.Value ? String.Empty : rdr["Note"].ToString();
            DateTime = rdr["DateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["DateTime"]);
        }
    }
}
