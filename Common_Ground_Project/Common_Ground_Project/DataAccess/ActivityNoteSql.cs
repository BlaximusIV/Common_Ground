using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.DataAccess
{
    public class ActivityNoteSql
    {
        public ActivityNote GetActivityNote(ActivityNote note, out string errorMessage)
        {
            List<ActivityNote> returnList = new List<ActivityNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityNoteID", note.ActivityNoteID));

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityNoteGetByID");
            returnList = createConnection(cmd, out errorMessage, parameters);

            if (returnList.Count > 0)
                return returnList[0];
            else
                return new ActivityNote();
        }
        public List<ActivityNote> GetActivityNoteList(Activity activity, out string errorMessage)
        {
            List<ActivityNote> returnList = new List<ActivityNote>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ActivityID", activity.ActivityID));

            SqlCommand cmd = new SqlCommand("Master.dbo.ActivityNoteGetByActivity");
            returnList = createConnection(cmd, out errorMessage, parameters);

            return returnList;
        }

        public void SaveActivityNote(ActivityNote note, out string errorMessage)
        {
            errorMessage = String.Empty;
            using (SqlConnection connection = new SqlConnection(LoginCredentials.ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        if (note.ActivityID == 0)
                        {
                            cmd.CommandText = "Master.dbo.ActivityNoteInsert";
                            cmd.Parameters.Add(new SqlParameter("@NewID", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output });

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
                catch (Exception e)
                {
                    errorMessage = "Error occured when saving: " + e.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private List<ActivityNote> createConnection(SqlCommand cmd, out string errorMessage, List<SqlParameter> parameters = null)
        {
            errorMessage = String.Empty;
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
                catch (Exception e)
                {
                    errorMessage = "Activity Note Connection Error: " + e.Message;
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
