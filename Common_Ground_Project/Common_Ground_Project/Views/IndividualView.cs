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
    public partial class IndividualView : UserControl
    {
        private CommonController Controller;

        public IndividualView()
        {
            InitializeComponent();
        }
        public void Initialize(CommonController controller)
        {
            Controller = controller;
            populateFilterType();
            //populateIndividuals();
        }

        private void populateFilterType()
        {
            List<IndividualType> types = Controller.GetIndividualTypeList();
            FilterIndividualType.DataSource = types;
            FilterIndividualType.DisplayMember = "Name";
            FilterIndividualType.ValueMember = "IndividualTypeID";
        }

        private void AddIndividualButton_Click(object sender, EventArgs e)
        {
            Individual individual = (Individual)IndividualDataSource.DataSource;
            Controller.SaveIndividual(individual);
        }

        private void UpdateIndividualButton_Click(object sender, EventArgs e)
        {
            Individual individual = (Individual)IndividualDataSource.DataSource;

        }



        //private void populateIndividuals()
        //{
        //    List<Individual> indList = Controller.GetIndividualList();

        //}
    }
}
