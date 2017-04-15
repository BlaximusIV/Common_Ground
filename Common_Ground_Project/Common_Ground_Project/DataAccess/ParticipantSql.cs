using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class ParticipantSql
    {
        private string ConnectionString = @"Server=localhost\SQLEXPRESS01;Database=master;" + 
            "Trusted_Connection=True";


        public List<Participant> GetParticipantList(string filter)
        {
            // Proc: participantGridVew1
            // sqlDa.SelectCommand.Parameters.AddWithValue("@firstName", filter);

            //Participant test = new Participant(rdr);




            List<Participant> testData = new List<Participant>();
            Participant part = new Participant { ID = 1, FirstName = "Steve", LastName = "James", BirthDay = new DateTime(2000, 1, 1) };
            testData.Add(part);

            return testData;
        }

        public void SaveParticipant(Participant participant)
        {
            if (participant.ID == 0)
            {
                // Insert
            }
            else
            {
                // Update
            }
        }

        public void DeleteParticipant(Participant participant)
        {
            // Delete
        }
    }
}
