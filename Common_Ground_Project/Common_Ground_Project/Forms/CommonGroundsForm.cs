using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_Ground_Project.Controllers;

namespace Common_Ground_Project.Forms
{
    public partial class CommonGroundsForm : Form
    {
        public CommonController Controller;
        private LoginForm loginForm;


        public CommonGroundsForm(LoginForm loginParent)
        {
            InitializeComponent();
            Initialize();

            loginForm = loginParent;
        }

        private void Initialize()
        {
            Controller = new CommonController();

            // Setup Controls with the Controller
            individualView1.Initialize(Controller);
            activityView1.Initialize(Controller);
            vehicalView1.Initialize(Controller);

            frequentCallerReport1.Initialize(Controller);
            userDayReport1.Initialize(Controller);
        }

        private void CommonGroundsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }
    }
}
