using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class PermissionSql
    {
        public Permission GetPermission(Permission permission, out string errorMessage)
        {
            List<Permission> returnList = new List<Permission>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@PermissionID", permission.PermissionID));

            SqlCommand cmd = new SqlCommand("Master.dbo.PermissionGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new Permission();
        }
        public List<Permission> GetPermissionList(out string errorMessage)
        {
            List<Permission> returnList = new List<Permission>();

            SqlCommand cmd = new SqlCommand("Master.dbo.PermissionGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }


        private List<Permission> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<Permission> returnList = new List<Permission>();
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
                                returnList.Add(new Permission(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Permission connection error: " + e.Message;
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
