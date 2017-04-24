using System;
using System.Collections.Generic;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class StaffSql
    {
        public Staff GetStaff(Staff staff, out string errorMessage)
        {
            List<Staff> returnList = new List<Staff>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualID", staff.StaffID));

            SqlCommand cmd = new SqlCommand("dbo.StaffGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Staff();
        }

        public List<Staff> GetStaffList(out string errorMessage)
        {
            List<Staff> returnList = new List<Staff>();

            SqlCommand cmd = new SqlCommand("dbo.StaffGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }

        public int AuthenticateStaff(string username, string password, out string errorMessage)
        {
            errorMessage = String.Empty;
            int staffID = 0;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "dbo.StaffAuthenticate";

                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        staffID = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error Authenticating: " + e.Message;
                    staffID = 0;
                }
                finally
                {
                    connection.Close();
                }
            }

            return staffID;
        }

        public void SaveStaff(Staff staff, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (staff.StaffID == 0)
                        {
                            cmd.CommandText = "dbo.StaffInsert";
                            cmd.Parameters.AddWithValue("@Password", "PuppiesForSale");
                            staff.StaffID = staff.IndividualID;
                        }
                        else
                        {
                            cmd.CommandText = "dbo.StaffUpdate";
                        }

                        cmd.Parameters.AddWithValue("@IndividualID", staff.StaffID);
                        cmd.Parameters.AddWithValue("@Username", (String.IsNullOrEmpty(staff.Username)) ? String.Empty : staff.Username);
                        cmd.Parameters.AddWithValue("@HireDate", staff.HireDate);
                        cmd.Parameters.AddWithValue("@LeaveDate", staff.LeaveDate);
                        cmd.Parameters.AddWithValue("@PermissionID", staff.PermissionID);
                        cmd.Parameters.AddWithValue("@IsEligibleDriver", staff.IsEligibleDriver);
                        cmd.Parameters.AddWithValue("@IsEmployeed", staff.IsEmployeed);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured while saving Individual: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void SaveStaffPassword(Staff staff, string password, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "dbo.StaffUpdatePassword";
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@IndividualID", staff.StaffID);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured while saving Individual: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private List<Staff> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<Staff> returnList = new List<Staff>();
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
                                returnList.Add(new Staff(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Staff connection error: " + e.Message;
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
