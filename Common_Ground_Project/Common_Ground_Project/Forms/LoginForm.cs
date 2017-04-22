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
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Forms
{
    public partial class LoginForm : Form
    {
        public CommonController Controller { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            Controller = new CommonController();
        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Attempt Logging In
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            validateLogin();
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validateLogin();
            }
        }

        private void validateLogin()
        {
            string userName = usernameText.Text;
            string password = passwordText.Text;

            if (Controller.IsAuthenticated(userName, password))
            {
                this.Visible = false;
                CommonGroundsForm form = new CommonGroundsForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login, Please try again.");
                passwordText.Text = String.Empty;
            }
        }
    }
}
