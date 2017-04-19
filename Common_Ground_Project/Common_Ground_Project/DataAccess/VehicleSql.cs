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
        public Vehicle GetVehicle(Vehicle veh)
        {
            List<Vehicle> returnList = new List<Vehicle>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@VehicleID", veh.VehicleID));

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetByID");
            returnList = createConnection(cmd, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Vehicle();
        }
        public List<Vehicle> GetVehicleList()
        {
            List<Vehicle> returnList = new List<Vehicle>();

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetAll");
            returnList = createConnection(cmd);

            return returnList;
        }
        public List<Vehicle> GetVehicleList(Activity activity)
        {
            List<Vehicle> returnList = new List<Vehicle>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.VehicleGetByActivity");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (vehicle.VehicleID == 0)
                        {
                            cmd.CommandText = "Master.dbo.VehicleInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", DBNull.Value).Direction = System.Data.ParameterDirection.ReturnValue);
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
                catch (Exception)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.VehicleDelete";

                        cmd.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);

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



        private List<Vehicle> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
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
