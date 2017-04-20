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
    public partial class FrequentCallerReport : UserControl
    {
        private CommonController Controller;

        public FrequentCallerReport()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            string errorMessage = String.Empty;
            DataTable table = Controller.FrequentCallerReport(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                if (table != null)
                {
                    frequentCallerGrid.DataSource = table;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
