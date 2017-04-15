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
    public partial class ParticipantView : UserControl
    {
        private CommonController Controller;

        public ParticipantView()
        {
            InitializeComponent();
        }

        public void Initialize(CommonController controller)
        {
            Controller = controller;
            PopulateDvgParticipants();
        }

        private void ResetForm()
        {
            btn_Addparticipant.Text = "Save";
            btn_deleteParticipant.Enabled = false;
            participantDataSource.DataSource = new Participant();
        }

        private void PopulateDvgParticipants()
        {
            string filter = p_search.Text.Trim();
            List<Participant> participants = Controller.GetParticipantList(filter);

            dvgParticipant.DataSource = null;
            dvgParticipant.DataSource = participants;
        }

        private void dvgParticipant_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgParticipant.SelectedCells.Count > 0)
            {
                int index = dvgParticipant.SelectedCells[0].RowIndex;
                Participant participent = (Participant)dvgParticipant.Rows[0].DataBoundItem;

                participantDataSource.DataSource = participent;

                /// Controller
                btn_Addparticipant.Text = "Update";
                btn_deleteParticipant.Enabled = true;
            }
        }

        private void btn_deleteParticipant_Click(object sender, EventArgs e)
        {
            if (participantDataSource.DataSource != null) {
                Participant participant = (Participant)participantDataSource.DataSource;

                if (participant.ID > 0)
                    Controller.DeleteParticipant(participant);
            }
        }

        private void btn_searchParticipant_Click(object sender, EventArgs e)
        {
            PopulateDvgParticipants();
        }

        private void btn_Addparticipant_Click(object sender, EventArgs e)
        {
            if (participantDataSource.DataSource != null)
            {
                Participant participant = (Participant)participantDataSource.DataSource;

                if (participant.ID > 0)
                    Controller.SaveParticipant(participant);
            }
        }

        private void btn_ClearParticipant_Click(object sender, EventArgs e)
        {
            participantDataSource.DataSource = new Participant();
        }
    }
}
