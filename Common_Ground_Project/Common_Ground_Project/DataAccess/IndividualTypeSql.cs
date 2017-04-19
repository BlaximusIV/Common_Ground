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
        public IndividualType GetIndividualType(IndividualType type)
        {
            List<IndividualType> returnList = new List<IndividualType>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualTypeID", type.IndividualTypeID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualTypeGetByID");
            returnList = createConnection(cmd, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new IndividualType();
        }
        public List<IndividualType> GetIndividualTypeList()
        {
            List<IndividualType> returnList = new List<IndividualType>();

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualTypeGetAll");
            returnList = createConnection(cmd);

            return returnList;
        }


        private List<IndividualType> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
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
