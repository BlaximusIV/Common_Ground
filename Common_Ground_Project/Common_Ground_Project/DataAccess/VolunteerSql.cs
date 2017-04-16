using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class VolunteerSql
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS01;Database=master;" + 
            "Trusted_Connection=True";

        public List<Volunteer> GetVolunteerList(string filter)
        {
            List<Volunteer> returnList = new List<Volunteer>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@firstName", filter));

            SqlCommand cmd = new SqlCommand("volunteerGridVew1");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveVolunteer(Volunteer volunteer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "VolunteerAddEdit";
                        if (volunteer.ID == 0)
                            cmd.Parameters.Add(new SqlParameter("@model", "Add"));
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@model", "Edit"));
                            cmd.Parameters.AddWithValue("@personID", volunteer.ID);
                        }

                        cmd.Parameters.AddWithValue("@firstName", volunteer.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", volunteer.LastName);
                        cmd.Parameters.AddWithValue("@phoneNumber", volunteer.PhoneNumber);
                        cmd.Parameters.AddWithValue("@email", volunteer.EmailAddress);
                        cmd.Parameters.AddWithValue("@emergencyContact", volunteer.EmergencyContact);
                        cmd.Parameters.AddWithValue("@streetAddress", volunteer.StreetAddress);
                        cmd.Parameters.AddWithValue("@City", volunteer.City);
                        cmd.Parameters.AddWithValue("@residentState", volunteer.State);
                        cmd.Parameters.AddWithValue("@zip", volunteer.ZipCode);
                        cmd.Parameters.AddWithValue("@instructions", volunteer.Note);


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

        public void DeleteVolunteer(Volunteer volunteer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "deleteVolunteer";
                        
                        cmd.Parameters.AddWithValue("@personID", volunteer.ID);

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



        private List<Volunteer> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<Volunteer> returnList = new List<Volunteer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                                returnList.Add(new Volunteer(rdr));
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
