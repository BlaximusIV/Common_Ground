using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class ActivityNoteSql
    {
        public ActivityNote GetActivityNote(ActivityNote note)
        {
            List<ActivityNote> returnList = new List<ActivityNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityNoteID", note.ActivityNoteID));

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityNoteGetByID");
            returnList = createConnection(cmd, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new ActivityNote();
        }
        public List<ActivityNote> GetActivityNoteList(Activity activity)
        {
            List<ActivityNote> returnList = new List<ActivityNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityNoteGetByActivity");
            returnList = createConnection(cmd, parameters);

            return returnList;
        }

        public void SaveActivityNote(ActivityNote note)
        {
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (note.ActivityID == 0)
                        {
                            cmd.CommandText = "Master.dbo.ActivityNoteInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", DBNull.Value).Direction = System.Data.ParameterDirection.ReturnValue);

                            cmd.Parameters.AddWithValue("@ActivityID", note.ActivityID);
                            cmd.Parameters.AddWithValue("@Note", note.Note);

                            cmd.Connection = connection;
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Connection.Open();
                            cmd.ExecuteScalar();

                            if (note.ActivityNoteID == 0)
                            {
                                int returnID = Convert.ToInt32(cmd.Parameters["@NewID"].Value);
                                if (returnID > 0)
                                    note.ActivityNoteID = returnID;
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



        private List<ActivityNote> createConnection(SqlCommand cmd, List<SqlParameter> parameters = null)
        {
            List<ActivityNote> returnList = new List<ActivityNote>();
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
                                returnList.Add(new ActivityNote(rdr));
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
