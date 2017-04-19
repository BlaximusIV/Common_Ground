using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    class ActivitySql
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS01;Database=master;" +
           "Trusted_Connection=True";

        public List<Activity> GetActivityList(string filter)
        {
            List<Activity> returnList = new List<Activity>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@firstName", filter));

            SqlCommand cmd = new SqlCommand("ActivityGridVew1");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveActivity(Activity Activity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ActivityAddEdit";
                        if (Activity.ID == 0)
                            cmd.Parameters.Add(new SqlParameter("@model", "Add"));
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@model", "Edit"));
                            cmd.Parameters.AddWithValue("@ActivityID", Activity.ID);
                        }

                        cmd.Parameters.AddWithValue("@Title", Activity.Title);
                        cmd.Parameters.AddWithValue("@TripLeader", Activity.TripLeader);
                        cmd.Parameters.AddWithValue("@Description", Activity.Description);
                        cmd.Parameters.AddWithValue("@Start_Date", Activity.StartDate);
                        cmd.Parameters.AddWithValue("@End_Date", Activity.EndDate);
                        cmd.Parameters.AddWithValue("@Start_Time", Activity.StartTime);
                        cmd.Parameters.AddWithValue("@End_Time", Activity.EndTime);
                        cmd.Parameters.AddWithValue("@Pick_Up_Time", Activity.PickUpTime);
                        cmd.Parameters.AddWithValue("@Drop_Off_Time", Activity.DropOffTime);
                        cmd.Parameters.AddWithValue("@Staff_Arrival_Time", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Cost", Activity.Cost);
                        cmd.Parameters.AddWithValue("@Vehicle_1", Activity.Vehicle1);
                        cmd.Parameters.AddWithValue("@Vehicle_2", Activity.Vehicle2);
                        cmd.Parameters.AddWithValue("@Vehicle_3", Activity.Vehicle3);
                        cmd.Parameters.AddWithValue("@Vehicle_4", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Vehicle_5", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Vehicle_6", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Vehicle_7", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Vehicle_8", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Vehicle_9", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@Notes", Activity.StaffArrivalTime);
                        cmd.Parameters.AddWithValue("@TripLeader", Activity.TripLeader);

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

        public void DeleteActivity(Activity Activity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "deleteActivity";

                        cmd.Parameters.AddWithValue("@personID", Activity.ID);

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



        private List<Activity> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<Activity> returnList = new List<Activity>();
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
                                returnList.Add(new Activity(rdr));
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
