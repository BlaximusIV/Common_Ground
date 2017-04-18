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

    //Hey Neal testing 1,2,3.....

    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;");
        int volunteerID = 0;
        int ActivityID= 0;
        int staffID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void btn_Addparticipant_Click(object sender, EventArgs e)
        {

        }

        void FillDVGParticipant()
        {
            //if (sqlCon.State == ConnectionState.Closed)
            //    sqlCon.Open();
            //SqlDataAdapter sqlDa = new SqlDataAdapter("participantGridVew1", sqlCon);
            //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDa.SelectCommand.Parameters.AddWithValue("@firstName", p_search.Text.Trim());
            ////the "txtSearch might be the name of the text box in the UI// 
            //DataTable dtbl = new DataTable();
            //sqlDa.Fill(dtbl);

            //dvgParticipant.DataSource = dtbl;
            //dvgParticipant.Columns[0].Visible = false;

            //// this hides the columns in the data grid view on the UI. "[0]' is index one of all the columns.//

            //sqlCon.Close();
        }

        private void btn_searchParticipant_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FillDVGParticipant();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error Message");
            //}
        }

        private void dvgParticipant_DoubleClick(object sender, EventArgs e)
        {
            //if (dvgParticipant.CurrentRow.Index != -1)
            //{
            //    personID = Convert.ToInt32(dvgParticipant.CurrentRow.Cells[0].Value.ToString());
            //    p_fName.Text = dvgParticipant.CurrentRow.Cells[2].Value.ToString();
            //    p_lName.Text = dvgParticipant.CurrentRow.Cells[1].Value.ToString();
            //    p_phoneNumber.Text = dvgParticipant.CurrentRow.Cells[3].Value.ToString();
            //    p_DOB.Text = dvgParticipant.CurrentRow.Cells[15].Value.ToString();
            //    p_email.Text = dvgParticipant.CurrentRow.Cells[4].Value.ToString();
            //    p_streetAddress.Text = dvgParticipant.CurrentRow.Cells[9].Value.ToString();
            //    p_city.Text = dvgParticipant.CurrentRow.Cells[10].Value.ToString();
            //    p_state.Text = dvgParticipant.CurrentRow.Cells[11].Value.ToString();
            //    p_zip.Text = dvgParticipant.CurrentRow.Cells[12].Value.ToString();
            //    p_emergencyContact.Text = dvgParticipant.CurrentRow.Cells[7].Value.ToString();
            //    p_notes.Text = dvgParticipant.CurrentRow.Cells[13].Value.ToString();
            //    btn_Addparticipant.Text = "Update";
            //    btn_deleteParticipant.Enabled = true;
            //}


        }

        void ResetParticipant()
        {
            //p_lName.Text = p_fName.Text = p_phoneNumber.Text = p_DOB.Text = p_email.Text = p_state.Text = p_streetAddress.Text = p_zip.Text = p_city.Text = p_emergencyContact.Text = p_notes.Text = "";
            //btn_Addparticipant.Text = "Save";
            //personID = 0;
            //btn_deleteParticipant.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ResetParticipant();
            //FillDVGParticipant();
            //ResetVolunteer();
            //FillDVGVolunteer();
            //ResetActivity();
            //FillDVGActivity();
            //ResetStaff();
            //FillDVGStaff();
       
        }

        private void btn_deleteParticipant_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("Are you sure you would like to delete this record?", "Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        if (sqlCon.State == ConnectionState.Closed)
            //            sqlCon.Open();
            //        SqlCommand sqlCmd = new SqlCommand("deleteParticipant", sqlCon);
            //        sqlCmd.CommandType = CommandType.StoredProcedure;
            //        sqlCmd.Parameters.AddWithValue("@personID", personID);
            //        sqlCmd.ExecuteNonQuery();
            //        MessageBox.Show("Delete Succesful");
            //        ResetParticipant();
            //        FillDVGParticipant();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Canceling Deletion");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error Message");
            //}


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
                if (MessageBox.Show("Are you sure you would like to delete this record?", "Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                else
                {
                    MessageBox.Show("Canceling Deletion");
                }
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

        private void ResetVolunteer()
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

        private void label22_Click(object sender, EventArgs e)
        {
            ParticipantHelp ph = new ParticipantHelp();
            ph.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            VolunteerHelp vh = new VolunteerHelp();
            vh.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            ActivitiesHelp ah = new ActivitiesHelp();
            ah.Show();
        }
        //----------------------------------------------------------------------------------
        //
        //              ACTIVITY
        //
        //----------------------------------------------------------------------------------
        private void btn_addActivity_Click(object sender, EventArgs e)
        {
            try 
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btn_addActivity.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("ActivityAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@ActivityID", 0);
                    sqlCmd.Parameters.AddWithValue("@Title", a_title.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Description", a_activityDescription.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Location", a_location.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Start_Date", Convert.ToDateTime(a_startDate.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@End_Date", Convert.ToDateTime(a_endDate.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Start_Time", Convert.ToDateTime(a_startTime.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@End_Time", Convert.ToDateTime(a_endTime.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Pick_Up_Time", Convert.ToDateTime(a_pickUpTime.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Drop_Off_Time", Convert.ToDateTime(a_dropOffTime.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Staff_Arrival_Time", Convert.ToDateTime(a_staffArrivalTime.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Cost", a_cost.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_1", a_v1.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_2", a_v2.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_3", a_v3.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_4", a_v4.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_5", a_v5.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_6", a_v6.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_7", a_v7.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_8", a_v8.Checked);
                    sqlCmd.Parameters.AddWithValue("@Vehicle_9", a_v9.Checked);
                    sqlCmd.Parameters.AddWithValue("@Notes", a_notes.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Save Succesful");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("ActivityAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@ActivityID", ActivityID);
                    sqlCmd.Parameters.AddWithValue("@Title", a_title.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Description", a_activityDescription.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Location", a_location.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Start_Date", a_startDate.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@End_Date", a_endDate.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Start_Time", a_startTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@End_Time", a_endTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Pick_Up_Time", a_pickUpTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Drop_Off_Time", a_dropOffTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Staff_Arrival_Time", a_staffArrivalTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Cost", a_cost.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_1", a_v1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_2", a_v2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_3", a_v3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_4", a_v4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_5", a_v5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_6", a_v6.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_7", a_v7.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_8", a_v8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vehicle_9", a_v9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Notes", a_notes.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update Succesful");

                }
                ResetActivity();
                FillDVGActivity();

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
        private void FillDVGActivity()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("activityGridView1", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Title", a_searchActivity.Text.Trim());
            //the "txtSearch might be the name of the text box in the UI// 
            DataTable Activitydtbl = new DataTable();
            sqlDa.Fill(Activitydtbl);

            dvgActivity.DataSource = Activitydtbl;
            dvgActivity.Columns[0].Visible = false;

            // this hides the columns in the data grid view on the UI. "[0]' is index one of all the columns.//

            sqlCon.Close();
        }

        private void btn_deleteActivity_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteActivity", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ActivityID", ActivityID);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Delete Succesful");
                ResetActivity();
                FillDVGActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void dvgActivity_DoubleClick(object sender, EventArgs e)
        {
            if (dvgActivity.CurrentRow.Index != -1)
            {
                ActivityID = Convert.ToInt32(dvgActivity.CurrentRow.Cells[0].Value.ToString());
                a_title.Text = dvgActivity.CurrentRow.Cells[1].Value.ToString();
                a_activityDescription.Text = dvgActivity.CurrentRow.Cells[2].Value.ToString();
                a_location.Text = dvgActivity.CurrentRow.Cells[3].Value.ToString();
                a_startDate.Text = dvgActivity.CurrentRow.Cells[4].Value.ToString();
                a_endDate.Text = dvgActivity.CurrentRow.Cells[5].Value.ToString();
                a_startTime.Text = dvgActivity.CurrentRow.Cells[6].Value.ToString();
                a_endTime.Text = dvgActivity.CurrentRow.Cells[7].Value.ToString();
                a_pickUpTime.Text = dvgActivity.CurrentRow.Cells[8].Value.ToString();
                a_dropOffTime.Text = dvgActivity.CurrentRow.Cells[9].Value.ToString();
                a_staffArrivalTime.Text = dvgActivity.CurrentRow.Cells[10].Value.ToString();
                a_cost.Text = dvgActivity.CurrentRow.Cells[11].Value.ToString();
                a_notes.Text = dvgActivity.CurrentRow.Cells[21].Value.ToString();
                btn_addActivity.Text = "Update";
                btn_deleteActivity.Enabled = true;
            }
        }
        void ResetActivity()
        {
            a_startDate.Text = a_endDate.Text = "";
            a_title.Text = a_activityDescription.Text = a_location.Text = a_startTime.Text = a_endTime.Text = a_pickUpTime.Text = a_dropOffTime.Text = a_staffArrivalTime.Text = a_cost.Text = a_cost.Text = "";
            btn_addActivity.Text = "Save";
            ActivityID = 0;
            btn_deleteActivity.Enabled = false;

        }

        private void btn_searchActivity_Click(object sender, EventArgs e)
        {
            try
            {
                FillDVGActivity();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        //----------------------------------------------------------------------------------
        //
        //              STAFF                  
        //
        //----------------------------------------------------------------------------------
        private void btn_addStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (btn_addStaff.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("StaffAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@staffID", 0);
                    sqlCmd.Parameters.AddWithValue("@First_Name", s_firstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_Name", s_lastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone_Number", s_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", s_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Emergency_Contact", s_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Street_Address", s_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", s_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@State", s_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Zip", s_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Notes", s_notes.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DOB", s_DOB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Save Succesful");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("StaffAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@staffID", staffID);
                    sqlCmd.Parameters.AddWithValue("@First_Name", s_firstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_Name", s_lastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone_Number", s_phoneNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", s_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Emergency_Contact", s_emergencyContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Street_Address", s_streetAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", s_city.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@State", s_state.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Zip", s_zip.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Notes", s_notes.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DOB", s_DOB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update Succesful");

                }
                ResetStaff();
                FillDVGStaff();
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
        void FillDVGStaff()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("staffGridView1", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@First_Name", s_searchStaff.Text.Trim());
            //the "txtSearch might be the name of the text box in the UI// 
            DataTable Staffdtbl = new DataTable();
            sqlDa.Fill(Staffdtbl);

            dvgStaff.DataSource = Staffdtbl;
            dvgStaff.Columns[0].Visible = false;

            // this hides the columns in the data grid view on the UI. "[0]' is index one of all the columns.//

            sqlCon.Close();
        }

        private void dvgStaff_DoubleClick(object sender, EventArgs e)
        {
            if (dvgStaff.CurrentRow.Index != -1)
            {
                staffID = Convert.ToInt32(dvgStaff.CurrentRow.Cells[0].Value.ToString());
                s_firstName.Text = dvgStaff.CurrentRow.Cells[1].Value.ToString();
                s_lastName.Text = dvgStaff.CurrentRow.Cells[2].Value.ToString();
                s_phoneNumber.Text = dvgStaff.CurrentRow.Cells[3].Value.ToString();
                s_DOB.Text = dvgStaff.CurrentRow.Cells[4].Value.ToString();
                s_email.Text = dvgStaff.CurrentRow.Cells[12].Value.ToString();
                s_streetAddress.Text = dvgStaff.CurrentRow.Cells[6].Value.ToString();
                s_city.Text = dvgStaff.CurrentRow.Cells[7].Value.ToString();
                s_state.Text = dvgStaff.CurrentRow.Cells[8].Value.ToString();
                s_zip.Text = dvgStaff.CurrentRow.Cells[9].Value.ToString();
                s_emergencyContact.Text = dvgStaff.CurrentRow.Cells[10].Value.ToString();
                s_notes.Text = dvgStaff.CurrentRow.Cells[11].Value.ToString();
                btn_addStaff.Text = "Update";
                btn_deleteStaff.Enabled = true;
            }
        }

        void ResetStaff()
        {
            s_firstName.Text = s_lastName.Text = s_phoneNumber.Text = s_DOB.Text = s_email.Text = s_city.Text = s_state.Text = s_streetAddress.Text = s_zip.Text = s_emergencyContact.Text = s_notes.Text = "";
            btn_addStaff.Text = "Save";
            staffID = 0;
            btn_deleteStaff.Enabled = false;
        }

        private void btn_searchStaff_Click(object sender, EventArgs e)
        {
            try
            {
                FillDVGStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}