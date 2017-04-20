using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class ReportSql
    {
        public DataTable UserDayReport(DateTime startTime, DateTime endTime, out string errorMessage)
        {
            errorMessage = String.Empty;
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.UserDayReport";
                        cmd.Parameters.AddWithValue("@FromDate", startTime);
                        cmd.Parameters.AddWithValue("@ToDate", endTime);

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error getting reports: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }

            return table;
        }

        public DataTable FrequentCallerReport(out string errorMessage)
        {
            errorMessage = String.Empty;
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "Master.dbo.FrequentCallerReport";

                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Error getting reports: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }

            return table;
        }
    }
}
