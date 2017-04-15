using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_Ground_Project.Forms;

namespace Common_Ground_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG
            //Application.Run(new Form1());
            Application.Run(new CommonGroundsForm());
#else
            Application.Run(new Form2());
            if (LoginCredentials.IsAuthenticated)
            {
                Application.Run(new Form1());
            }
#endif
        }
    }
}

