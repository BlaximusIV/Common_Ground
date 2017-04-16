using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class StaffSql
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS01;Database=master;" + 
            "Trusted_Connection=True";

        public List<Staff> GetStaffList(string filter)
        {
            List<Staff> returnList = new List<Staff>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@firstName", filter));

            SqlCommand cmd = new SqlCommand("staffGridVew1");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveStaff(Staff staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "StaffAddEdit";
                        if (staff.ID == 0)
                            cmd.Parameters.Add(new SqlParameter("@model", "Add"));
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@model", "Edit"));
                            cmd.Parameters.AddWithValue("@personID", staff.ID);
                        }

                        cmd.Parameters.AddWithValue("@firstName", staff.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", staff.LastName);
                        cmd.Parameters.AddWithValue("@phoneNumber", staff.PhoneNumber);
                        cmd.Parameters.AddWithValue("@email", staff.EmailAddress);
                        cmd.Parameters.AddWithValue("@emergencyContact", staff.EmergencyContact);
                        cmd.Parameters.AddWithValue("@streetAddress", staff.StreetAddress);
                        cmd.Parameters.AddWithValue("@City", staff.City);
                        cmd.Parameters.AddWithValue("@residentState", staff.State);
                        cmd.Parameters.AddWithValue("@zip", staff.ZipCode);
                        cmd.Parameters.AddWithValue("@instructions", staff.Note);


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

        public void DeleteStaff(Staff staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "deleteStaff";
                        
                        cmd.Parameters.AddWithValue("@personID", staff.ID);

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



        private List<Staff> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<Staff> returnList = new List<Staff>();
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
                                returnList.Add(new Staff(rdr));
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
