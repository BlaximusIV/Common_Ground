using System;
using System.Collections.Generic;
using Common_Ground_Project.Models;
using System.Data.SqlClient;

namespace Common_Ground_Project.DataAccess
{
    public class IndividualNoteSql
    {
        public IndividualNote GetIndividualNote(IndividualNote note)
        {
            List<IndividualNote> returnList = new List<IndividualNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualNoteID", note.IndividualNoteID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualNoteGetByID");
            returnList = createConnection(cmd, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new IndividualNote();
        }
        public List<IndividualNote> GetIndividualNoteList(Individual individual)
        {
            List<IndividualNote> returnList = new List<IndividualNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IndividualID", individual.IndividualID));

            SqlCommand cmd = new SqlCommand("Master.dbo.IndividualGetAll");
            returnList = createConnection(cmd);

            return returnList;
        }

        public void SaveIndividualNote(IndividualNote note)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (note.IndividualNoteID == 0)
                        {
                            cmd.CommandText = "Master.dbo.IndividualNoteInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", DBNull.Value).Direction = System.Data.ParameterDirection.ReturnValue);

                            cmd.Parameters.AddWithValue("@IndividualID", note.IndividualID);
                            cmd.Parameters.AddWithValue("@Note", note.Note);

                            cmd.Connection = connection;
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Connection.Open();
                            cmd.ExecuteScalar();

                            if (note.IndividualNoteID == 0)
                            {
                                int returnID = Convert.ToInt32(cmd.Parameters["@NewID"].Value);
                                if (returnID > 0)
                                    note.IndividualNoteID = returnID;
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
        }




        private List<IndividualNote> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<IndividualNote> returnList = new List<IndividualNote>();
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
                                returnList.Add(new IndividualNote(rdr));
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
