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

namespace Common_Ground_Project.Views
{
    public partial class UserDayReport : UserControl
    {
        private CommonController Controller;

        public UserDayReport()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            splitContainer1.Panel2Collapsed = true;
        }

        private void AddEContactButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            DateTime fromDate = fromUserDay.Value;
            DateTime todAte = toUserDay.Value;

            DataTable table = Controller.UserDayReport(fromDate, todAte, out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                if (table != null)
                {
                    userDayGrid.DataSource = table;
                    //userDayChart.DataSource = table;
                }
            }
        }
    }
}
