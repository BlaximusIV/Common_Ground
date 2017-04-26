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
            activityDataSource.DataSource = new Activity();
            refreshActivityTab();
            populateActivityTree();
        }

        private void activityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Activity activity = (Activity)e.Node.Tag;
            activityDataSource.DataSource = activity;

            refreshActivityTab();
        }

        private void refreshActivityTab()
        {
            textBox1.Clear();
            ActivityNote.Clear();
            populateActivityVehicles();
            populateActivityNotes();
            populateActivityParticipants();
            populateAssignedTree();
        }

        private void populateActivityVehicles()
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            activity.VehicleList = Controller.GetVehicleList(activity, out errorMessage);
            activityDataSource.DataSource = activity;

            vehicleListBindingSource.DataSource = activity.VehicleList;
        }

        private void populateActivityNotes()
        {
            string errorMessage = String.Empty;
            Activity activity = (Activity)activityDataSource.DataSource;
            activity.ActivityNoteList = Controller.GetActivityNoteList(activity, out errorMessage);
            activityDataSource.DataSource = activity;

            activityNoteListBindingSource.DataSource = activity.ActivityNoteList;
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
                Activity activity = (Activity)activityDataSource.DataSource;
                Vehicle vehicle = (Vehicle)VehicleSelector.SelectedItem;
                

                Controller.SaveVehicleActivity(activity, vehicle, out errorMessage);

                if (errorMessage == String.Empty)
                {
                    activity.VehicleList.Add(vehicle);
                    activityDataSource.DataSource = activity;
                    refreshActivityTab();
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
                Activity act = (Activity)activityDataSource.DataSource;
                ActivityNote note = new ActivityNote();
                note.ActivityID = act.ActivityID;
                note.Note = ActivityNote.Text.Trim();

                Controller.InsertActivityNote(note, out errorMessage);

                if (errorMessage == String.Empty)
                {
                    act.ActivityNoteList.Add(note);
                    activityDataSource.DataSource = act;
                    refreshActivityTab();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please first select an activity to add a note to.");
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

        private void IndividualTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateAssigneeTree();
        }

        private void populateAssigneeTree()
        {
            string errorMessage = String.Empty;
            assigneeTree.Nodes.Clear();

            IndividualType type = (IndividualType)IndividualTypeFilter.SelectedItem;
            if (type != null)
            {
                List<Individual> peeps = Controller.GetIndividualList(type, out errorMessage);

                if (String.IsNullOrEmpty(errorMessage))
                {
                    TreeNode node = new TreeNode();
                    foreach (Individual indiv in peeps)
                    {
                        node = new TreeNode();
                        node.Text = indiv.FullName;
                        node.Tag = indiv;

                        assigneeTree.Nodes.Add(node);
                    }
                }
                else
                    MessageBox.Show(errorMessage);
            }
        }

        private void IndividualNameFilter_TextChanged(object sender, EventArgs e)
        {
            filterIndividualTree();
        }

        private void filterIndividualTree()
        {
            populateAssigneeTree();
            string name = textBox1.Text.Trim().ToUpper();

            List<TreeNode> removeableNodes = new List<TreeNode>();
            foreach (TreeNode node in assigneeTree.Nodes)
            {
                Individual individual = (Individual)node.Tag;

                if (!String.IsNullOrEmpty(name) && individual.FullName.ToString().Trim().ToUpper().IndexOf(name) == -1)
                {
                    removeableNodes.Add(node);
                }
            }

            if (removeableNodes.Count > 0)
            {
                foreach (TreeNode node in removeableNodes)
                {
                    node.Remove();
                }
            }

        }

        private void populateAssignedTree()
        {
            string errorMessage = String.Empty;
            assignedTree.Nodes.Clear();
            Activity activity = (Activity)activityDataSource.DataSource;

            if (activity != null && activity.ActivityID > 0)
            {
                List<Individual> peeps = Controller.GetIndividualList(activity, out errorMessage);

                if (String.IsNullOrEmpty(errorMessage))
                {
                    if (peeps != null && peeps.Count > 0)
                    {
                        TreeNode node = new TreeNode();
                        foreach (Individual indiv in peeps)
                        {
                            node = new TreeNode();
                            node.Text = indiv.FullName;
                            node.Tag = indiv;

                            assignedTree.Nodes.Add(node);
                        }
                    }
                }
                else
                    MessageBox.Show(errorMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIndividualToActivity();
        }

        private void assigneeTree_DoubleClick(object sender, EventArgs e)
        {
            AddIndividualToActivity();
        }

        private void AddIndividualToActivity()
        {
            string errorMessage = String.Empty;
            if (assigneeTree.SelectedNode != null)
            {
                if (activityDataSource.DataSource != null)
                {
                    Individual peep = (Individual)assigneeTree.SelectedNode.Tag;
                    Activity act = (Activity)activityDataSource.DataSource;

                    Controller.SaveActivityIndividual(act, peep, out errorMessage);

                    if (String.IsNullOrEmpty(errorMessage))
                    {
                        act.IndividualList.Add(peep);
                        refreshActivityTab();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveIndividualToActivity();
        }

        private void assignedTree_DoubleClick(object sender, EventArgs e)
        {
            RemoveIndividualToActivity();
        }

        private void RemoveIndividualToActivity()
        {
            string errorMessage = String.Empty;
            if (assignedTree.SelectedNode != null)
            {
                if (activityDataSource.DataSource != null)
                {
                    Individual peep = (Individual)assignedTree.SelectedNode.Tag;
                    Activity act = (Activity)activityDataSource.DataSource;

                    Controller.DeleteActivityIndividual(act, peep, out errorMessage);

                    if (String.IsNullOrEmpty(errorMessage))
                    {
                        act.IndividualList.Add(peep);
                        refreshActivityTab();
                    }
                }
            }
        }

       private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterIndividualTree();
        }
    }
}
