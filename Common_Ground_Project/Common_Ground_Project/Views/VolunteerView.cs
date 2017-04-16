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
    public partial class VolunteerView : UserControl
    {
        private CommonController Controller;

        public VolunteerView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            PopulateDvgVolunteer();
        }

        private void ResetForm()
        {
            //btn_addVolunteer.Text = "Save";
            btn_deleteVolunteer.Enabled = false;
            voluteerDataSource.DataSource = new Volunteer();
        }

        private void PopulateDvgVolunteer()
        {
            string filter = v_search.Text.Trim();
            List<Volunteer> volunteer = Controller.GetVolunteerList(filter);

            dvgVolunteer.DataSource = null;
            dvgVolunteer.DataSource = volunteer;
        }

        private void dvgVolunteer_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgVolunteer.SelectedCells.Count > 0)
            {
                int index = dvgVolunteer.SelectedCells[0].RowIndex;
                Volunteer volunteer = (Volunteer)dvgVolunteer.Rows[0].DataBoundItem;

                voluteerDataSource.DataSource = volunteer;

                /// Controller
                //btn_addVolunteer.Text = "Update";
                btn_deleteVolunteer.Enabled = true;
            }
        }



        //private void btn_deleteVolunteer_Click(object sender, EventArgs e)
        //{
        //    if (voluteerDataSource.DataSource != null)
        //    {
        //        Volunteer volunteer = (Volunteer)voluteerDataSource.DataSource;

        //        if (volunteer.ID > 0)
        //            Controller.DeleteVolunteer(volunteer);
        //    }
        //}

        //private void btn_searchVolunteer_Click(object sender, EventArgs e)
        //{
        //    PopulateDvgVolunteer();
        //}

        //private void btn_addPar(object sender, EventArgs e)
        //{
        //    if (voluteerDataSource.DataSource != null)
        //    {
        //        Volunteer volunteer = (Volunteer)voluteerDataSource.DataSource;

        //        if (volunteer.ID > 0)
        //            Controller.SaveVolunteer(volunteer);
        //    }
        //}

        //private void btn_clearVolunteer_Click(object sender, EventArgs e)
        //{
        //    voluteerDataSource.DataSource = new Volunteer();
        //}
    }
}
