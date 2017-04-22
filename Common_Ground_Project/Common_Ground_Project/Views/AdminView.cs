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
            staffID.DataPropertyName = "StaffID";
            staffID.ReadOnly = true;
            staffID.Visible = false;

            DataGridViewTextBoxColumn individualID = new DataGridViewTextBoxColumn();
            individualID.DataPropertyName = "IndividualID";
            individualID.ReadOnly = true;
            individualID.Visible = false;

            DataGridViewTextBoxColumn staffName = new DataGridViewTextBoxColumn();
            staffName.DataPropertyName = "Name";
            staffName.HeaderText = "Name";
            staffName.ReadOnly = true;

            DataGridViewTextBoxColumn hireDate = new DataGridViewTextBoxColumn();
            hireDate.DataPropertyName = "HireDate";
            hireDate.HeaderText = "Hired On";
            hireDate.ValueType = typeof(DateTime);

            DataGridViewTextBoxColumn leaveDate = new DataGridViewTextBoxColumn();
            leaveDate.DataPropertyName = "LeaveDate";
            leaveDate.HeaderText = "Left On";
            leaveDate.ValueType = typeof(DateTime);

            DataGridViewComboBoxColumn permission = new DataGridViewComboBoxColumn();
            permission.DataPropertyName = "PermissionID";
            permission.HeaderText = "Position";
            permission.DataSource = Controller.GetPermissionList(out errorMessage);
            permission.DisplayMember = "Name";
            permission.ValueMember = "PermissionID";

            staffDataGrid.Columns.Add(staffID);
            staffDataGrid.Columns.Add(individualID);
            staffDataGrid.Columns.Add(staffName);
            staffDataGrid.Columns.Add(hireDate);
            staffDataGrid.Columns.Add(leaveDate);
            staffDataGrid.Columns.Add(permission);

            populateStaffGrid();
        }

        private void populateStaffGrid()
        {
            string errorMessage = String.Empty;
            List<Staff> Staff = new List<Staff>();
            Staff = Controller.GetStaffList(out errorMessage);

            staffDataGrid.DataSource = Staff;
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

        private void staffDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string errorMessage = String.Empty;
                Staff staff = (Staff)staffDataGrid.Rows[e.RowIndex].DataBoundItem;
                Controller.SaveStaff(staff, out errorMessage);

                if (!String.IsNullOrEmpty(errorMessage))
                    MessageBox.Show(errorMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            if (staffDataGrid.SelectedCells != null && staffDataGrid.SelectedCells.Count > 0)
            {
                Staff staff = (Staff)staffDataGrid.Rows[staffDataGrid.SelectedCells[0].RowIndex].DataBoundItem;
                if (staff != null && staff.StaffID > 0)
                {
                    string password = Controller.PasswordStaff(staff, out errorMessage);
                    if (!String.IsNullOrEmpty(errorMessage))
                        MessageBox.Show(errorMessage);
                    else
                        MessageBox.Show("Please let " + staff.Name + " know their password has changed to " + password + " temporarily.");
                }
            }
        }
    }
}
