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
            populateIndividuals();
        }

        private void populateFilterType()
        {
            List<IndividualType> types = Controller.GetIndividualTypeList();
            FilterIndividualType.DataSource = types;
            FilterIndividualType.DisplayMember = "Name";
            FilterIndividualType.ValueMember = "IndividualTypeID";

            individualTypeComboBox.Items.Clear();
            foreach (IndividualType type in types)
                individualTypeComboBox.Items.Add(type);

            individualTypeComboBox.DisplayMember = "Name";
            individualTypeComboBox.ValueMember = "IndividualTypeID";
        }

        private void populateIndividuals()
        {
            IndividualDataSource.DataSource = new Individual();
            individualTreeView.Nodes.Clear();

            List<Individual> indList = Controller.GetIndividualList();
            TreeNode node = new TreeNode();
            foreach (Individual ind in indList)
            {
                node = new TreeNode { Text = ind.FullName, Tag = ind };
                individualTreeView.Nodes.Add(node);
            }   
        }

        private void AddIndividualButton_Click(object sender, EventArgs e)
        {
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                if (individualTypeComboBox.SelectedItem != null)
                    individual.IndividualTypeID = ((IndividualType)individualTypeComboBox.SelectedItem).IndividualTypeID;

                Controller.SaveIndividual(individual);
                populateFilterType();
            }
            catch (Exception)
            { }
        }

        private void UpdateIndividualButton_Click(object sender, EventArgs e)
        {
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                if (individualTypeComboBox.SelectedItem != null)
                    individual.IndividualTypeID = ((IndividualType)individualTypeComboBox.SelectedItem).IndividualTypeID;

                Controller.SaveIndividual(individual);
                populateFilterType();
            }
            catch (Exception)
            { }
        }

        private void DeleteIndividualButton_Click(object sender, EventArgs e)
        {
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                DialogResult answer = MessageBox.Show("You are about to delete " + individual.FirstName + " " + individual.LastName + " forever, are you sure you wish to continue?", "Confirmation", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    Controller.DeleteIndividual(individual);
                    populateFilterType();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an Individual before attempting to alter.");
            }
        }

        private void individualTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Individual individual = (Individual)individualTreeView.SelectedNode.Tag;
            IndividualDataSource.DataSource = individual;

            if (individual.IndividualTypeID > 0)
                individualTypeComboBox.SelectedItem = individualTypeComboBox.Items[individual.IndividualTypeID - 1];
        }

        private void FilterIndividualName_TextChanged(object sender, EventArgs e)
        {
            FilterTreeNames();
        }

        private void FilterIndividualType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTreeNames();
        }




        private void FilterTreeNames()
        {
            populateIndividuals();
            IndividualType type = (IndividualType)FilterIndividualType.SelectedItem;
            string name = FilterIndividualName.Text.Trim().ToUpper();

            List<TreeNode> removeableNodes = new List<TreeNode>();
            foreach (TreeNode node in individualTreeView.Nodes)
            {
                Individual individual = (Individual)node.Tag;

                if (!String.IsNullOrEmpty(name) && individual.FullName.ToString().Trim().ToUpper().IndexOf(name) == -1)
                    removeableNodes.Add(node);
                else if (type != null && individual.IndividualTypeID != type.IndividualTypeID)
                    removeableNodes.Add(node);
            }

            if (removeableNodes.Count > 0)
                foreach (TreeNode node in removeableNodes)
                    node.Remove();
        }

    }
}
