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

namespace Common_Ground_Project.Forms
{
    public partial class CommonGroundsForm : Form
    {
        public CommonController Controller;


        public CommonGroundsForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Controller = new CommonController();

            // Setup Controls with the Controller
            //IndividualView.Initialize(Controller);
        }
    }
}
