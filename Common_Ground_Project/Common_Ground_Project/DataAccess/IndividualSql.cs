using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class IndividualSql
    {
        public Individual GetIndividual(Individual individual)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualID", individual.IndividualID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByID");
            returnList = createConnection(cmd, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Individual();
        }
        public List<Individual> GetIndividualList(Activity activity)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByActivity");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }
        public List<Individual> GetIndividualList(IndividualType type)
        {
            List<Individual> returnList = new List<Individual>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualTypeID", type.IndividualTypeID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetByType");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveIndividual(Individual individual)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (individual.IndividualID == 0)
                        {
                            cmd.CommandText = "Master.dbo.IndividualInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", DBNull.Value).Direction = System.Data.ParameterDirection.ReturnValue);
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
                                individual.IndividualID = returnID;
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
        }

        public void DeleteIndividual(Individual individual)
        {
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
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<Individual> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
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
