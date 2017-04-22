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


        public CommonGroundsForm()
        {
            Controller = new CommonController();
            this.FormClosed -= CommonGroundsForm_FormClosed;

            InitializeComponent();
            Initialize();
        }
        public CommonGroundsForm(LoginForm loginParent)
        {
            loginForm = loginParent;
            Controller = loginForm.Controller;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            // Setup Controls with the Controller
            individualView1.Initialize(Controller);
            activityView1.Initialize(Controller);
            vehicalView1.Initialize(Controller);
            adminView1.Initialize(Controller);

            frequentCallerReport1.Initialize(Controller);
            userDayReport1.Initialize(Controller);
        }

        private void CommonGroundsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                loginForm.Close();
            }
            catch (Exception)
            {
                // NO ONE CARES!
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Admin Tab - Assistant / Manager / Owner / Admin
            if (Controller.Permission.PermissionID < 3 && tabControl1.SelectedIndex == 3) 
                tabControl1.SelectedIndex = 0;
        }
    }
}
