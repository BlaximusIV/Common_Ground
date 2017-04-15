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

        public CommonController()
        {
            // Initialize repositories
            ParticipantData = new ParticipantSql();
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
    }
}
