using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_Ground_Project.Models;
using Common_Ground_Project.Controllers;

namespace Common_Ground_Project.Views
{
    public partial class ActivityView : UserControl
    {
        private CommonController Controller;

        public ActivityView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            activityDataSource.DataSource = new Activity();
            populateActivityTree();
            PopulateActivityTypeSelector();
            PopulateTripLeaderSelector();
            PopulateVehicleSelector();
            PopulateIndividualTypeFilter();
        }

        private void populateActivityTree() {
            string errorMsg = String.Empty;
            activityTreeView.Nodes.Clear();
            DateTime date = DateTime.Now;
            DateTime.TryParse(ActivitySearch.Text, out date);

            if (date < new DateTime(1900, 1, 1))
                date = DateTime.Now;

            List<Activity> acvityList = Controller.GetActivityList(date, out errorMsg);

            TreeNode node = new TreeNode();
            foreach(Activity act in acvityList)
            {
                node = new TreeNode();
                node.Text = act.ActivityTypeName;
                node.Tag = act;
                activityTreeView.Nodes.Add(node);
            }
        }

        private void ActivitySearch_ValueChanged(object sender, EventArgs e)
        {
            populateActivityTree();
        }

        private void activityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Activity activity = (Activity)e.Node.Tag;
            activityDataSource.DataSource = activity;

            populateActivityVehicles();
            populateActivityNotes();
            populateActivityParticipants();
        }

        private void populateActivityVehicles()
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            activity.VehicleList = Controller.GetVehicleList(activity, out errorMessage);
            activityDataSource.DataSource = activity;
        }

        private void populateActivityNotes()
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            activity.ActivityNoteList = Controller.GetActivityNoteList(activity, out errorMessage);
            activityDataSource.DataSource = activity;
        }

        private void populateActivityParticipants()
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            activity.IndividualList = Controller.GetIndividualList(activity, out errorMessage);
            activityDataSource.DataSource = activity;
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            Controller.SaveActivity(activity, out errorMessage);
            if (!String.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);
            else
                populateActivityTree();
        }

        private void DeleteActivityButton_Click(object sender, EventArgs e)
        {
            if (activityDataSource.DataSource != null)
            {
                string errorMessage = String.Empty;
                Activity activity = (Activity)activityDataSource.DataSource;
                Controller.DeleteActivity(activity, out errorMessage);
                if (!String.IsNullOrEmpty(errorMessage))
                    MessageBox.Show(errorMessage);
                else
                    populateActivityTree();
            }
            else
            {
                MessageBox.Show("Please first select an activity to delete.");
            }
        }

        private void PopulateActivityTypeSelector()
        {
            string errorMessage = String.Empty;

            List<ActivityType> actTypes = Controller.GetActivityTypeList(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                ActivityTypeSelector.DataSource = actTypes;
                ActivityTypeSelector.DisplayMember = "Name";
                ActivityTypeSelector.ValueMember = "ActivityTypeID";
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void PopulateTripLeaderSelector()
        {
            string errorMessage = String.Empty;

            List<Staff> listStaff = Controller.GetStaffList(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {

                TripLeaderSelector.DataSource = listStaff;
                TripLeaderSelector.DisplayMember = "Name";
                TripLeaderSelector.ValueMember = "IndividualID";
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void PopulateVehicleSelector()
        {
            string errorMessage = String.Empty;

            List<Vehicle> vehicleList = Controller.GetVehicleList(out errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                VehicleSelector.DataSource = vehicleList;
                VehicleSelector.DisplayMember = "Name";
                VehicleSelector.ValueMember = "VehicleID";
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            if (activityDataSource.DataSource != null)
            {
                String errorMessage = String.Empty;
                Vehicle vehicle = (Vehicle)activityDataSource.DataSource;
                Controller.SaveVehicle(vehicle, out errorMessage);

                if (errorMessage == String.Empty)
                {
                    //do nothing
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please first select an activity to add a vehicle to.");
            }
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            if (activityDataSource.DataSource != null)
            {
                String errorMessage = String.Empty;
                ActivityNote note = (ActivityNote)activityDataSource.DataSource;
                Controller.InsertActivityNote(note, out errorMessage);

                if (errorMessage == String.Empty)
                {
                    //do nothing
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please first select an activity to add a not to.");
            }
        }

        private void PopulateIndividualTypeFilter()
        {
            string errorMessage = String.Empty;

            List<IndividualType> individualTypeList = Controller.GetIndividualTypeList(out errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                IndividualTypeFilter.DataSource = individualTypeList;
                IndividualTypeFilter.DisplayMember = "Name";
                IndividualTypeFilter.ValueMember = "IndividualTypeID";
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void ActivityTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activityDataSource.DataSource != null)
            {
                ((Activity)activityDataSource.DataSource).ActivityTypeID = ((ActivityType)ActivityTypeSelector.SelectedItem).ActivityTypeID;
            }
        }

        private void TripLeaderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activityDataSource.DataSource != null)
            {
                ((Activity)activityDataSource.DataSource).TripLeaderID = ((Staff)TripLeaderSelector.SelectedValue).IndividualID;
            }
        }
    }
}
