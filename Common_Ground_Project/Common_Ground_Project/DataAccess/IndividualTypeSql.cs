using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class IndividualTypeSql
    {
        public IndividualType GetIndividualType(IndividualType type, out string errorMessage)
        {
            List<IndividualType> returnList = new List<IndividualType>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualTypeID", type.IndividualTypeID));

            SqlCommand cmd = new SqlCommand("dbo.IndividualTypeGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new IndividualType();
        }
        public List<IndividualType> GetIndividualTypeList(out string errorMessage)
        {
            List<IndividualType> returnList = new List<IndividualType>();

            SqlCommand cmd = new SqlCommand("dbo.IndividualTypeGetAll");
            returnList = createConnection(cmd, out errorMessage);

            return returnList;
        }


        private List<IndividualType> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
            List<IndividualType> returnList = new List<IndividualType>();
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
                                returnList.Add(new IndividualType(rdr));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    errorMessage = "Individual Type connection error: " + e.Message;
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
