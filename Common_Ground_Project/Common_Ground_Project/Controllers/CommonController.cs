using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.DataAccess;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Controllers
{
    public class CommonController
    {
        // private Repository references.
        private ParticipantSql ParticipantData;
        //private VolunteerSql VolunteerData;
        private StaffSql StaffData;

        public CommonController()
        {
            // Initialize repositories
            ParticipantData = new ParticipantSql();
            //VolunteerData = new VolunteerSql();
            StaffData = new StaffSql();
        }


        #region Participants 
        public List<Participant> GetParticipantList(string filter)
        {
            return ParticipantData.GetParticipantList(filter);
        }
        public void SaveParticipant(Participant participant)
        {
            ParticipantData.SaveParticipant(participant);
        }
        public void DeleteParticipant(Participant participant)
        {
            ParticipantData.DeleteParticipant(participant);
        }
        #endregion

        #region Volunteers
        //public List<Volunteer> GetVolunteerList(string filter)
        //{
        //    return VolunteerData.GetVolunteerList(filter);
        //}
        //public void SaveVolunteer(Volunteer volunteer)
        //{
        //    ParticipantData.SaveVolunteer(volunteer);
        //}
        //public void DeleteVolunteer(Volunteer volunteer)
        //{
        //    VolunteerData.DeleteVolunteer(volunteer);
        //}
        #endregion

        #region Staff
        public List<Staff> GetStaffList(string filter)
        {
            return StaffData.GetStaffList(filter);
        }
        public void SaveStaff(Staff staff)
        {
            StaffData.SaveStaff(staff);
        }
        public void DeleteStaff(Staff staff)
        {
            StaffData.DeleteStaff(staff);
        }
        #endregion

    }
}
