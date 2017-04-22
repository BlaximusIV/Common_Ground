using System;
using System.Collections.Generic;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class IndividualSql
    {
        public Individual GetIndividual(Individual individual, out string errorMessage)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualID", individual.IndividualID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Individual();
        }
        public List<Individual> GetIndividualList(out string errorMessage)
        {
            List<Individual> returnList = new List<Individual>();

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }
        public List<Individual> GetIndividualList(Activity activity, out string errorMessage)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByActivity");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }
        public List<Individual> GetIndividualList(IndividualType type, out string errorMessage)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualTypeID", type.IndividualTypeID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByType");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }

        public void ResetIndividualWaiver(out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.IndividualWaiverReset";

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
        public void SaveIndividual(Individual individual, out string errorMessage)
        {
            errorMessage = String.Empty;
            bool isInsert = false;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (individual.IndividualID == 0)
                        {
                            isInsert = true;
                            cmd.CommandText = "Master.dbo.IndividualInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output });
                        }
                        else
                        {
                            cmd.CommandText = "Master.dbo.IndividualUpdate";
                            cmd.Parameters.AddWithValue("@IndividualID", individual.IndividualID);
                        }

                        cmd.Parameters.AddWithValue("@IndividualTypeID", individual.IndividualTypeID);
                        cmd.Parameters.AddWithValue("@LastName", individual.LastName);
                        cmd.Parameters.AddWithValue("@FirstName", individual.FirstName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", individual.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", individual.Email);
                        cmd.Parameters.AddWithValue("@StreetAddress", individual.StreetAddress);
                        cmd.Parameters.AddWithValue("@City", individual.City);
                        cmd.Parameters.AddWithValue("@State", individual.State);
                        cmd.Parameters.AddWithValue("@ZipCode", individual.ZipCode);
                        cmd.Parameters.AddWithValue("@Birthday", individual.BirthDay);
                        cmd.Parameters.AddWithValue("@IsFrequentCaller", individual.IsFrequentCaller);
                        cmd.Parameters.AddWithValue("@IsWaiverSigned", individual.IsWaiverSigned);
                        cmd.Parameters.AddWithValue("@IsMediaReleased", individual.IsMediaReleased);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();

                        if (individual.IndividualID == 0) { 
                            int returnID = Convert.ToInt32(cmd.Parameters["@NewID"].Value);
                            if (returnID > 0)
                            {
                                individual.IndividualID = returnID;
                            }
                        }

                        if (individual.IndividualTypeID == 1)
                        {
                            Staff staff = new Staff();
                            staff.AddIndividual(individual);

                            if (!isInsert)
                                staff.StaffID = staff.IndividualID;

                            new StaffSql().SaveStaff(staff, out errorMessage);
                        }
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

        public void DeleteIndividual(Individual individual, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.IndividualDelete";

                        cmd.Parameters.AddWithValue("@IndividualID", individual.IndividualID);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured while deleting Individual: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<Individual> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<Individual> returnList = new List<Individual>();
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
                                returnList.Add(new Individual(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Individual connection error: " + e.Message;
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
