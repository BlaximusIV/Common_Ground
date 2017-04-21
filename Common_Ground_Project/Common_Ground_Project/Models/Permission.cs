using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common_Ground_Project.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string Name { get; set; }
        public bool IsAllowedEntry { get; set; }


        public Permission()
        {
            PermissionID = 0;
        }
        public Permission(int id)
        {
            PermissionID = id;
        }
        public Permission(SqlDataReader rdr)
        {
            PermissionID = rdr["PermissionID"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["PermissionID"]);
            Name = rdr["Name"] == DBNull.Value ? String.Empty : rdr["Name"].ToString();
            IsAllowedEntry = rdr["IsAllowedEntry"] == DBNull.Value ? false : Convert.ToBoolean(rdr["IsAllowedEntry"]);
        }
    }
}
