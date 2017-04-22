using System;
using System.Collections.Generic;
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
            FilterTreeNames();
        }

        private void populateFilterType()
        {
            string errorMessage = String.Empty;
            List<IndividualType> types = Controller.GetIndividualTypeList(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                FilterIndividualType.DataSource = types;
                FilterIndividualType.DisplayMember = "Name";
                FilterIndividualType.ValueMember = "IndividualTypeID";

                individualTypeComboBox.Items.Clear();
                foreach (IndividualType type in types)
                    individualTypeComboBox.Items.Add(type);

                individualTypeComboBox.DisplayMember = "Name";
                individualTypeComboBox.ValueMember = "IndividualTypeID";
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void populateIndividuals()
        {
            string errorMessage = String.Empty;
            IndividualDataSource.DataSource = new Individual();
            individualTreeView.Nodes.Clear();

            List<Individual> indList = Controller.GetIndividualList(out errorMessage);

            if (String.IsNullOrEmpty(errorMessage))
            {
                TreeNode node = new TreeNode();
                foreach (Individual ind in indList)
                {
                    node = new TreeNode { Text = ind.FullName, Tag = ind };
                    individualTreeView.Nodes.Add(node);
                }
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void AddIndividualButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                if (individualTypeComboBox.SelectedItem != null)
                    individual.IndividualTypeID = ((IndividualType)individualTypeComboBox.SelectedItem).IndividualTypeID;

                Controller.SaveIndividual(individual, out errorMessage);

                if (String.IsNullOrEmpty(errorMessage))
                    populateFilterType();
                else
                    MessageBox.Show(errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void UpdateIndividualButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                if (individualTypeComboBox.SelectedItem != null)
                    individual.IndividualTypeID = ((IndividualType)individualTypeComboBox.SelectedItem).IndividualTypeID;

                Controller.SaveIndividual(individual, out errorMessage);

                if (String.IsNullOrEmpty(errorMessage))
                    populateFilterType();
                else
                    MessageBox.Show(errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void DeleteIndividualButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            try
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                DialogResult answer = MessageBox.Show("You are about to delete " + individual.FirstName + " " + individual.LastName + " forever, are you sure you wish to continue?", "Confirmation", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    Controller.DeleteIndividual(individual, out errorMessage);

                    if (String.IsNullOrEmpty(errorMessage))
                        populateFilterType();
                    else
                        MessageBox.Show(errorMessage);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an Individual before attempting to alter.");
            }
        }

        private void individualTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string errorMessage = String.Empty;
            Individual individual = (Individual)individualTreeView.SelectedNode.Tag;
            IndividualDataSource.DataSource = new Individual();
            IndividualDataSource.DataSource = individual;

            if (individual.IndividualTypeID > 0)
                individualTypeComboBox.SelectedItem = individualTypeComboBox.Items[individual.IndividualTypeID - 1];

            getIndividualContacts();
            getIndividualNotes();
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

        private void AddEContactButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            string name = ecNameText.Text.Trim();
            string email = ecEmailText.Text.Trim();
            string phone = ecPhoneText.Text.Trim();

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(phone))
                MessageBox.Show("Please provide a Contact Name and Phone number.");
            else
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;

                if (individual != null && individual.IndividualID > 0)
                { 
                    EmergencyContact contact = new EmergencyContact
                    {
                        IndividualID = individual.IndividualID,
                        Name = name,
                        Phone = phone,
                        Email = email
                    };

                    Controller.SaveEmergencyContact(contact, out errorMessage);

                    if (!String.IsNullOrEmpty(errorMessage))
                        MessageBox.Show(errorMessage);
                    else
                    {
                        getIndividualContacts();

                        ecNameText.Text = String.Empty;
                        ecEmailText.Text = String.Empty;
                        ecPhoneText.Text = String.Empty;
                    }
                }
                else
                    MessageBox.Show("Please select an individual first.");
            }
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            string note = noteText.Text.Trim();

            if (String.IsNullOrEmpty(note))
                MessageBox.Show("Please enter a new Note.");
            else
            {
                Individual individual = (Individual)IndividualDataSource.DataSource;
                if (individual != null && individual.IndividualID > 0)
                {
                    IndividualNote idividualNote = new IndividualNote
                    {
                        IndividualID = individual.IndividualID,
                        Note = note
                    };

                    Controller.SaveIndividualNote(idividualNote, out errorMessage);

                    if (!String.IsNullOrEmpty(errorMessage))
                        MessageBox.Show(errorMessage);
                    else
                    {
                        getIndividualNotes();
                        noteText.Text = String.Empty;
                    }
                }
                else
                    MessageBox.Show("Please select an individual first.");
            }
        }



        private void getIndividualNotes()
        {
            string errorMessage = String.Empty;
            Individual individual = (Individual)IndividualDataSource.DataSource;
            individual.IndividualNoteList = new List<IndividualNote>();
            individual.IndividualNoteList = Controller.GetIndividualNoteList(individual, out errorMessage);

            if (!String.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);
            else
                individualNoteListBindingSource.DataSource = individual.IndividualNoteList;
        }

        private void getIndividualContacts()
        {
            string errorMessage = String.Empty;
            Individual individual = (Individual)IndividualDataSource.DataSource;
            individual.IndividualNoteList = new List<IndividualNote>();
            individual.IndividualNoteList = Controller.GetIndividualNoteList(individual, out errorMessage);

            individual.EmergencyContactList = new List<EmergencyContact>();
            individual.EmergencyContactList = Controller.GetEmergencyContactList(individual, out errorMessage);

            if (!String.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);
            else
                emergencyContactListBindingSource.DataSource = individual.EmergencyContactList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndividualDataSource.DataSource = new Individual();
        }
    }
}
