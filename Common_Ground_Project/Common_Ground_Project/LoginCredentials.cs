using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Ground_Project
{
    class LoginCredentials
    {
        static private string password = "testing123";
        static public string Password { get { return LoginCredentials.password; } }

        static private bool isAuthenticated = false;
        static public bool IsAuthenticated
        {
            get { return LoginCredentials.isAuthenticated; }
            set { LoginCredentials.isAuthenticated = value; }
        }
    }
        
}
