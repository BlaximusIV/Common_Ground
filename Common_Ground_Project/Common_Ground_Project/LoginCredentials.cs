using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Ground_Project
{
    public class LoginCredentials
    {
        static private string password = "testing123";
        static public string Password { get { return LoginCredentials.password; } }
        public static string ConnectionString { get { return "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"; } }
        public static string ConnectionString { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; } }
        //public static string ConnectionString { get { return ""; } }
        public static string ConnectionString { get { return "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"; } }

        static private bool isAuthenticated = false;
        static public bool IsAuthenticated
        {
            get { return LoginCredentials.isAuthenticated; }
            set { LoginCredentials.isAuthenticated = value; }
        }
    }
        
}
