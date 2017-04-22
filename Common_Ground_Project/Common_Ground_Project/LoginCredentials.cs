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
        //public static string ConnectionString { get { return "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"; } }
        public static string ConnectionString { get { return "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"; } }

        static private bool isAuthenticated = false;
        static public bool IsAuthenticated
        {
            get { return LoginCredentials.isAuthenticated; }
            set { LoginCredentials.isAuthenticated = value; }
        }
    }
        
}
