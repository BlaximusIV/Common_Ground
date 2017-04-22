using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_Ground_Project.Controllers;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Views
{
    public partial class AdminView : UserControl
    {
        private CommonController Controller;

        public AdminView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;

            BuildStaffTable();
        }

        private void BuildStaffTable()
        {
            string errorMessage = String.Empty;
            staffDataGrid.Columns.Clear();

            DataGridViewTextBoxColumn staffID = new DataGridViewTextBoxColumn();
            staffID.ReadOnly = true;
            staffID.Visible = false;

            DataGridViewTextBoxColumn staffName = new DataGridViewTextBoxColumn();
            staffName.HeaderText = "Name";
            staffName.ReadOnly = true;

            DataGridViewTextBoxColumn hireDate = new DataGridViewTextBoxColumn();
            hireDate.HeaderText = "Hired On";
            hireDate.ValueType = typeof(DateTime);

            DataGridViewTextBoxColumn leaveDate = new DataGridViewTextBoxColumn();
            leaveDate.HeaderText = "Left On";
            leaveDate.ValueType = typeof(DateTime);

            DataGridViewComboBoxColumn permission = new DataGridViewComboBoxColumn();
            permission.HeaderText = "Position";
            permission.DataSource = Controller.GetPermissionList(out errorMessage);
            permission.DisplayMember = "Name";
            permission.ValueMember = "PermissionID";

            staffDataGrid.Columns.Add(staffID);
            staffDataGrid.Columns.Add(staffName);
            staffDataGrid.Columns.Add(hireDate);
            staffDataGrid.Columns.Add(leaveDate);
            staffDataGrid.Columns.Add(permission);
        }

        private void DeleteIndividualButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            DialogResult answer = MessageBox.Show("Are you sure? This will reset all the waivers.", "Final Approval", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Controller.ResetIndividualWaiver(out errorMessage);
            }
        }
    }
}
