using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class ActivitySql
    {
        public Activity GetActivity(Activity activity, out string errorMessage)
        {
            List<Activity> returnList = new List<Activity>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("dbo.ActivityGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Activity();
        }
        public List<Activity> GetActivityList(DateTime date, out string errorMessage)
        {
            List<Activity> returnList = new List<Activity>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Date", date));

            SqlCommand cmd = new SqlCommand("dbo.ActivityGetByDate");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }
        public List<Activity> GetActivityList(Individual individual, out string errorMessage)
        {
            List<Activity> returnList = new List<Activity>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualID", individual.IndividualID));

            SqlCommand cmd = new SqlCommand("dbo.ActivityGetByIndividual");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }

        public void SaveActivity(Activity activity, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (activity.ActivityID == 0)
                        {
                            cmd.CommandText = "dbo.ActivityInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output });
                        }
                        else
                        {
                            cmd.CommandText = "dbo.ActivityUpdate";
                            cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityID);
                        }

                        cmd.Parameters.AddWithValue("@ActivityTypeID", activity.ActivityTypeID);
                        cmd.Parameters.AddWithValue("@TripLeaderID", activity.TripLeaderID);
                        cmd.Parameters.AddWithValue("@Location", activity.Location);
                        cmd.Parameters.AddWithValue("@StartDate", activity.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", activity.EndDate);
                        cmd.Parameters.AddWithValue("@PickUpTime", activity.PickUpTime);
                        cmd.Parameters.AddWithValue("@DropOffTime", activity.DropOffTime);
                        cmd.Parameters.AddWithValue("@StaffArrivalTime", activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Cost", activity.Cost);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();

                        if (activity.ActivityID == 0)
                        {
                            int returnID = Convert.ToInt32(cmd.Parameters["@NewID"].Value);
                            if (returnID > 0)
                                activity.ActivityID = returnID;
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured when saving: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteActivity(Activity activity, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "dbo.ActivityDeleteByID";

                        cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityID);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Activity Connection Error: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<Activity> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<Activity> returnList = new List<Activity>();
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
                                returnList.Add(new Activity(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Activity Connection Error: " + e.Message;
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
