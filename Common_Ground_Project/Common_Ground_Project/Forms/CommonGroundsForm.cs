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
        CommonController Controller { get; set; }

        public CommonGroundsForm()
        {
            InitializeComponent();
            Intialize();
        }

        public void Intialize()
        {
            // Initialize Controls
            Controller = new CommonController();

            participantView1.Initialize(Controller);
            volunteerView1.Initialize(Controller);
            staffView1.Initialize(Controller);
        }
    }
}
