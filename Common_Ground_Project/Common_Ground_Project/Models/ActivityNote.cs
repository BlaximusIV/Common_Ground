using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class ActivityNote
    {

        public int ActivityNoteID { get; set; }
        public int ActivityID { get; set; }
        public string Note { get; set; }
        public DateTime DateTime { get; set; }
        

        public ActivityNote()
        {
            ActivityNoteID = 0;
        }
        public ActivityNote(int id)
        {
            ActivityNoteID = ActivityNoteID;
        }
        public ActivityNote(SqlDataReader rdr)
        {
            ActivityNoteID = rdr["ActivityNoteID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ActivityNoteID"]);
            ActivityID = rdr["ActivityID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["ActivityID"]);
            DateTime = rdr["DateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(rdr["DateTime"]);
            Note = rdr["Note"] == DBNull.Value ? String.Empty : rdr["Note"].ToString();
        }
    }
}
