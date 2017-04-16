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
    public partial class StaffView : UserControl
    {
        private CommonController Controller;

        public StaffView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
        }



    }
}
