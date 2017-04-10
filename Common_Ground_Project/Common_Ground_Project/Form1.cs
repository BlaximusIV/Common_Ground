using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Common_Ground_Project
{


    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-GUSKKLJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        int personID = 0;
        int volunteerID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dateTimePicker5.Visible = true;
            }
            else
            {
                dateTimePicker5.Visible = false;
            }
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Addparticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btn_Addparticipant.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("TestingSP", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@personID", 0);
                    sqlCmd.Parameters.AddWithValue("@firstName", p_fName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lastName", p_lName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@phoneNumber", p_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", p_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@emergencyContact", p_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@streetAddress", p_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", p_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@residentState", p_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@zip", p_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@instructions", p_notes.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Save Succesful");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("TestingSP", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@personID", personID);
                    sqlCmd.Parameters.AddWithValue("@firstName", p_fName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lastName", p_lName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@phoneNumber", p_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", p_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@emergencyContact", p_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@streetAddress", p_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", p_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@residentState", p_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@zip", p_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@instructions", p_notes.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update Succesful");

                }
                ResetParticipant();
                FillDVGParticipant();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }


        void FillDVGParticipant()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("participantGridVew1", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@firstName", p_search.Text.Trim());
            //the "txtSearch might be the name of the text box in the UI// 
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dvgParticipant.DataSource = dtbl;
            dvgParticipant.Columns[0].Visible = false;

            // this hides the columns in the data grid view on the UI. "[0]' is index one of all the columns.//

            sqlCon.Close();
        }


        private void btn_searchParticipant_Click(object sender, EventArgs e)
        {
            try
            {

                FillDVGParticipant();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");

            }

        }

        private void dvgParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgParticipant_DoubleClick(object sender, EventArgs e)
        {
            if (dvgParticipant.CurrentRow.Index != -1)
            {
                personID = Convert.ToInt32(dvgParticipant.CurrentRow.Cells[0].Value.ToString());
                p_fName.Text = dvgParticipant.CurrentRow.Cells[2].Value.ToString();
                p_lName.Text = dvgParticipant.CurrentRow.Cells[1].Value.ToString();
                p_phoneNumber.Text = dvgParticipant.CurrentRow.Cells[3].Value.ToString();
                p_DOB.Text = dvgParticipant.CurrentRow.Cells[15].Value.ToString();
                p_email.Text = dvgParticipant.CurrentRow.Cells[4].Value.ToString();
                p_streetAddress.Text = dvgParticipant.CurrentRow.Cells[9].Value.ToString();
                p_city.Text = dvgParticipant.CurrentRow.Cells[10].Value.ToString();
                p_state.Text = dvgParticipant.CurrentRow.Cells[11].Value.ToString();
                p_zip.Text = dvgParticipant.CurrentRow.Cells[12].Value.ToString();
                p_emergencyContact.Text = dvgParticipant.CurrentRow.Cells[7].Value.ToString();
                p_notes.Text = dvgParticipant.CurrentRow.Cells[13].Value.ToString();
                btn_Addparticipant.Text = "Update";
                btn_deleteParticipant.Enabled = true;
            }


        }

        void ResetParticipant()
        {
            p_lName.Text = p_fName.Text = p_phoneNumber.Text = p_DOB.Text = p_email.Text = p_state.Text = p_streetAddress.Text = p_zip.Text = p_city.Text = p_emergencyContact.Text = p_notes.Text = "";
            btn_Addparticipant.Text = "Save";
            personID = 0;
            btn_deleteParticipant.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetParticipant();
            FillDVGParticipant();
            ResetVolunteer();
            FillDVGVolunteer();
        }

        private void btn_deleteParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteParticipant", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@personID", personID);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Delete Succesful");
                ResetParticipant();
                FillDVGParticipant();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }


        }

        private void btn_addVolunteer_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btn_addVolunteer.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("VolunteerAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@volunteerID", 0);
                    sqlCmd.Parameters.AddWithValue("@First_Name", v_firstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_Name", v_lastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone_Number", v_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", v_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Emergency_Contact", v_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Street_Address", v_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", v_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@State", v_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Zip", v_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Notes", v_notes.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DOB", v_DOB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Save Succesful");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("VolunteerAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@volunteerID", volunteerID);
                    sqlCmd.Parameters.AddWithValue("@First_Name", v_firstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_Name", v_lastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone_Number", v_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", v_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Emergency_Contact", v_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Street_Address", v_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", v_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@State", v_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Zip", v_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Notes", v_notes.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DOB", v_DOB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update Succesful");

                }
                ResetVolunteer();
                FillDVGVolunteer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDVGVolunteer()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("volunteerGridView1", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@First_Name", v_search.Text.Trim());
            //the "txtSearch might be the name of the text box in the UI// 
            DataTable Volunteerdtbl = new DataTable();
            sqlDa.Fill(Volunteerdtbl);

            dvgVolunteer.DataSource = Volunteerdtbl;
            dvgVolunteer.Columns[0].Visible = false;

            // this hides the columns in the data grid view on the UI. "[0]' is index one of all the columns.//

            sqlCon.Close();
        }
        private void btn_deleteVolunteer_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteVolunteer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@volunteerID", volunteerID);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Delete Succesful");
                ResetVolunteer();
                FillDVGVolunteer();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }


        }

        private void dvgVolunteer_DoubleClick(object sender, EventArgs e)
        {
            if (dvgVolunteer.CurrentRow.Index != -1)
            {
                volunteerID = Convert.ToInt32(dvgVolunteer.CurrentRow.Cells[0].Value.ToString());
                v_firstName.Text = dvgVolunteer.CurrentRow.Cells[1].Value.ToString();
                v_lastName.Text = dvgVolunteer.CurrentRow.Cells[2].Value.ToString();
                v_phoneNumber.Text = dvgVolunteer.CurrentRow.Cells[3].Value.ToString();
                v_DOB.Text = dvgVolunteer.CurrentRow.Cells[4].Value.ToString();
                v_email.Text = dvgVolunteer.CurrentRow.Cells[12].Value.ToString();
                v_streetAddress.Text = dvgVolunteer.CurrentRow.Cells[6].Value.ToString();
                v_city.Text = dvgVolunteer.CurrentRow.Cells[7].Value.ToString();
                v_state.Text = dvgVolunteer.CurrentRow.Cells[8].Value.ToString();
                v_zip.Text = dvgVolunteer.CurrentRow.Cells[9].Value.ToString();
                v_emergencyContact.Text = dvgVolunteer.CurrentRow.Cells[10].Value.ToString();
                v_notes.Text = dvgVolunteer.CurrentRow.Cells[11].Value.ToString();
                v_wavierDate.Text = dvgVolunteer.CurrentRow.Cells[5].Value.ToString();
                btn_addVolunteer.Text = "Update";
                btn_deleteVolunteer.Enabled = true;
            }
        }
        void ResetVolunteer()
        {
            v_firstName.Text = v_lastName.Text = v_phoneNumber.Text = v_DOB.Text = v_email.Text = v_city.Text = v_state.Text = v_streetAddress.Text = v_zip.Text = v_wavierDate.Text = v_emergencyContact.Text = v_notes.Text = "";
            btn_addVolunteer.Text = "Save";
            volunteerID = 0;
            btn_deleteVolunteer.Enabled = false;

        }

        private void btn_searchVolunteer_Click(object sender, EventArgs e)
        {
            try
            {

                FillDVGVolunteer();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");

            }
        }
    }
}