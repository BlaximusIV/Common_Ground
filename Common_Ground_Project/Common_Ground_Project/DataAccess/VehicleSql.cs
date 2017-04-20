using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class VehicleSql
    {
        public Vehicle GetVehicle(Vehicle vehicle, out string errorMessage)
        {
            List<Vehicle> returnList = new List<Vehicle>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@VehicleID", vehicle.VehicleID));

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Vehicle();
        }
        public List<Vehicle> GetVehicleList(out string errorMessage)
        {
            List<Vehicle> returnList = new List<Vehicle>();

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }
        public List<Vehicle> GetVehicleList(Activity activity, out string errorMessage)
        {
            List<Vehicle> returnList = new List<Vehicle>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetByActivity");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }

        public void SaveVehicle(Vehicle vehicle, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (vehicle.VehicleID == 0)
                        {
                            cmd.CommandText = "Master.dbo.VehicleInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output });
                        }
                        else
                        {
                            cmd.CommandText = "Master.dbo.VehicleUpdate";
                            cmd.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
                        }

                        cmd.Parameters.AddWithValue("@Name", vehicle.Name);
                        cmd.Parameters.AddWithValue("@Description", vehicle.Description);
                        cmd.Parameters.AddWithValue("@VIN", vehicle.VIN);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();

                        if (vehicle.VehicleID == 0)
                        {
                            int returnID = Convert.ToInt32(cmd.Parameters["@NewID"].Value);
                            if (returnID > 0)
                                vehicle.VehicleID = returnID;
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured while saving Vehicle: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteVehicle(Vehicle vehicle, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.VehicleDeleteByID";

                        cmd.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error occured while deleting Vehicle: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<Vehicle> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<Vehicle> returnList = new List<Vehicle>();
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
                                returnList.Add(new Vehicle(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Vehicle connection error: " + e.Message;
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
