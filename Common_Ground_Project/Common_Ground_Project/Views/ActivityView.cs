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
            populateActivityTree();
        }

        private void populateActivityTree() {
            string errorMsg = String.Empty;
            activityTreeView.Nodes.Clear();
            DateTime date;
            DateTime.TryParse(ActivitySearch.Text, out date);
            DateTime filterDate = date;

            List <Activity> acvityList = Controller.GetActivityList(filterDate, out errorMsg);

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
    }
}
