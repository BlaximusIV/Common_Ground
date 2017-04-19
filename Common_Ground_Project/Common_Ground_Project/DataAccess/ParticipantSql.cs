using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class ParticipantSql
    {
        public List<Participant> GetParticipantList(string filter)
        {
            List<Participant> returnList = new List<Participant>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@firstName", filter));

            SqlCommand cmd = new SqlCommand("participantGridVew1");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveParticipant(Participant participant)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ParticipantAddEdit";
                        if (participant.ID == 0)
                            cmd.Parameters.Add(new SqlParameter("@model", "Add"));
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@model", "Edit"));
                            cmd.Parameters.AddWithValue("@personID", participant.ID);
                        }

                        cmd.Parameters.AddWithValue("@firstName", participant.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", participant.LastName);
                        cmd.Parameters.AddWithValue("@phoneNumber", participant.PhoneNumber);
                        cmd.Parameters.AddWithValue("@email", participant.EmailAddress);
                        cmd.Parameters.AddWithValue("@emergencyContact", participant.EmergencyContact);
                        cmd.Parameters.AddWithValue("@streetAddress", participant.StreetAddress);
                        cmd.Parameters.AddWithValue("@City", participant.City);
                        cmd.Parameters.AddWithValue("@residentState", participant.State);
                        cmd.Parameters.AddWithValue("@zip", participant.ZipCode);
                        cmd.Parameters.AddWithValue("@instructions", participant.Note);


                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteParticipant(Participant participant)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "deleteParticipant";
                        
                        cmd.Parameters.AddWithValue("@personID", participant.ID);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<Participant> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<Participant> returnList = new List<Participant>();
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (cmd)
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters.ToArray());

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                returnList.Add(new Participant(rdr));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return returnList;
        }

    }
}
