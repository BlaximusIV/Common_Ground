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
            ActivityTreeView.Nodes.Clear();
            DateTime filterDate = Convert.ToDateTime(ActivitySearch.Text);

            List<Activity> acvityList = Controller.GetActivityList(filterDate, out errorMsg);

            TreeNode node = new TreeNode();
            foreach(Activity act in acvityList)
            {
                node = new TreeNode();
                node.Text = act.ActivityTypeName;
                node.Tag = act;
                ActivityTreeView.Nodes.Add(node);
            }
        }

        private void ActivitySearch_ValueChanged(object sender, EventArgs e)
        {
            populateActivityTree();
        }

        private void ActivityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Activity activity = (Activity)e.Node.Tag;
            ActivityViewDataSource.DataSource = activity;
        }
    }
}
