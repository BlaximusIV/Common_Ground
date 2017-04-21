using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class ActivityTypeSql
    {
        public ActivityType GetActivityType(ActivityType activityType, out string errorMessage)
        {
            List<ActivityType> returnList = new List<ActivityType>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityTypeID", activityType.ActivityTypeID));

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityTypeGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new ActivityType();
        }
        public List<ActivityType> GetActivityTypeList(out string errorMessage)
        {
            List<ActivityType> returnList = new List<ActivityType>();

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityTypeGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }


        private List<ActivityType> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<ActivityType> returnList = new List<ActivityType>();
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
                                returnList.Add(new ActivityType(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Activity Type connection error: " + e.Message;
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
