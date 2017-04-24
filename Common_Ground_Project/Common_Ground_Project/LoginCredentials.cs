using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Ground_Project
{
    public class LoginCredentials
    {
        static private string password = "!@#admin123";
        static public string Password { get { return LoginCredentials.password; } }
        public static string ConnectionString = "Data Source=129.123.162.145;" +
                "Initial Catalog=CommonGround;" +
                "User id=CA7241;" +
                "Password=A00787241;";
        //public static string ConnectionString { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; } }
        //public static string ConnectionString { get { return "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"; } }

        static private bool isAuthenticated = false;
        static public bool IsAuthenticated
        {
            get { return LoginCredentials.isAuthenticated; }
            set { LoginCredentials.isAuthenticated = value; }
        }
    }
        
}
