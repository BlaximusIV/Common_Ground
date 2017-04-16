namespace Common_Ground_Project.Views
{
    partial class VolunteerView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.voluteerDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.p_notes = new System.Windows.Forms.RichTextBox();
            this.p_emergencyContact = new System.Windows.Forms.RichTextBox();
            this.p_zip = new System.Windows.Forms.RichTextBox();
            this.p_state = new System.Windows.Forms.RichTextBox();
            this.p_city = new System.Windows.Forms.RichTextBox();
            this.p_streetAddress = new System.Windows.Forms.RichTextBox();
            this.p_email = new System.Windows.Forms.RichTextBox();
            this.p_lName = new System.Windows.Forms.RichTextBox();
            this.p_fName = new System.Windows.Forms.RichTextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p_DOB = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.p_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_searchVolunteer = new System.Windows.Forms.Button();
            this.v_search = new System.Windows.Forms.TextBox();
            this.dvgVolunteer = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWaiverSignedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isMediaReleasedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_clearVolunteer = new System.Windows.Forms.Button();
            this.btn_deleteVolunteer = new System.Windows.Forms.Button();
            this.btn_addVolunteer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voluteerDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVolunteer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // voluteerDataSource
            // 
            this.voluteerDataSource.DataSource = typeof(Common_Ground_Project.Models.Volunteer);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.voluteerDataSource, "IsMediaReleased", true));
            this.checkBox7.Location = new System.Drawing.Point(4, 322);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(97, 17);
            this.checkBox7.TabIndex = 66;
            this.checkBox7.Text = "Media Release";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.voluteerDataSource, "IsWaiverSigned", true));
            this.checkBox2.Location = new System.Drawing.Point(4, 300);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Waiver Signed";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // p_notes
            // 
            this.p_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "Note", true));
            this.p_notes.Location = new System.Drawing.Point(4, 407);
            this.p_notes.Margin = new System.Windows.Forms.Padding(2);
            this.p_notes.Name = "p_notes";
            this.p_notes.Size = new System.Drawing.Size(284, 113);
            this.p_notes.TabIndex = 53;
            this.p_notes.Text = "";
            // 
            // p_emergencyContact
            // 
            this.p_emergencyContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "EmergencyContact", true));
            this.p_emergencyContact.Location = new System.Drawing.Point(108, 211);
            this.p_emergencyContact.Margin = new System.Windows.Forms.Padding(2);
            this.p_emergencyContact.Multiline = false;
            this.p_emergencyContact.Name = "p_emergencyContact";
            this.p_emergencyContact.Size = new System.Drawing.Size(116, 19);
            this.p_emergencyContact.TabIndex = 52;
            this.p_emergencyContact.Text = "";
            // 
            // p_zip
            // 
            this.p_zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "ZipCode", true));
            this.p_zip.Location = new System.Drawing.Point(108, 188);
            this.p_zip.Margin = new System.Windows.Forms.Padding(2);
            this.p_zip.Multiline = false;
            this.p_zip.Name = "p_zip";
            this.p_zip.Size = new System.Drawing.Size(116, 19);
            this.p_zip.TabIndex = 51;
            this.p_zip.Text = "";
            // 
            // p_state
            // 
            this.p_state.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "State", true));
            this.p_state.Location = new System.Drawing.Point(108, 165);
            this.p_state.Margin = new System.Windows.Forms.Padding(2);
            this.p_state.Multiline = false;
            this.p_state.Name = "p_state";
            this.p_state.Size = new System.Drawing.Size(37, 19);
            this.p_state.TabIndex = 50;
            this.p_state.Text = "";
            // 
            // p_city
            // 
            this.p_city.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "City", true));
            this.p_city.Location = new System.Drawing.Point(108, 142);
            this.p_city.Margin = new System.Windows.Forms.Padding(2);
            this.p_city.Multiline = false;
            this.p_city.Name = "p_city";
            this.p_city.Size = new System.Drawing.Size(116, 19);
            this.p_city.TabIndex = 49;
            this.p_city.Text = "";
            // 
            // p_streetAddress
            // 
            this.p_streetAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "StreetAddress", true));
            this.p_streetAddress.Location = new System.Drawing.Point(108, 119);
            this.p_streetAddress.Margin = new System.Windows.Forms.Padding(2);
            this.p_streetAddress.Multiline = false;
            this.p_streetAddress.Name = "p_streetAddress";
            this.p_streetAddress.Size = new System.Drawing.Size(116, 19);
            this.p_streetAddress.TabIndex = 48;
            this.p_streetAddress.Text = "";
            // 
            // p_email
            // 
            this.p_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "EmailAddress", true));
            this.p_email.Location = new System.Drawing.Point(108, 96);
            this.p_email.Margin = new System.Windows.Forms.Padding(2);
            this.p_email.Multiline = false;
            this.p_email.Name = "p_email";
            this.p_email.Size = new System.Drawing.Size(116, 19);
            this.p_email.TabIndex = 47;
            this.p_email.Text = "";
            // 
            // p_lName
            // 
            this.p_lName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "LastName", true));
            this.p_lName.Location = new System.Drawing.Point(108, 25);
            this.p_lName.Margin = new System.Windows.Forms.Padding(2);
            this.p_lName.Multiline = false;
            this.p_lName.Name = "p_lName";
            this.p_lName.Size = new System.Drawing.Size(116, 19);
            this.p_lName.TabIndex = 44;
            this.p_lName.Text = "";
            // 
            // p_fName
            // 
            this.p_fName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "FirstName", true));
            this.p_fName.Location = new System.Drawing.Point(108, 2);
            this.p_fName.Margin = new System.Windows.Forms.Padding(2);
            this.p_fName.Multiline = false;
            this.p_fName.Name = "p_fName";
            this.p_fName.Size = new System.Drawing.Size(116, 19);
            this.p_fName.TabIndex = 43;
            this.p_fName.Text = "";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(2, 392);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(38, 13);
            this.label69.TabIndex = 64;
            this.label69.Text = "Notes:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(2, 214);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(103, 13);
            this.label68.TabIndex = 63;
            this.label68.Text = "Emergency Contact:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(2, 191);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(25, 13);
            this.label67.TabIndex = 62;
            this.label67.Text = "Zip:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(2, 145);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(27, 13);
            this.label65.TabIndex = 60;
            this.label65.Text = "City:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(2, 122);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(79, 13);
            this.label64.TabIndex = 59;
            this.label64.Text = "Street Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email:";
            // 
            // p_DOB
            // 
            this.p_DOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "BirthDay", true));
            this.p_DOB.Location = new System.Drawing.Point(108, 72);
            this.p_DOB.Margin = new System.Windows.Forms.Padding(2);
            this.p_DOB.Mask = "00/00/0000";
            this.p_DOB.Name = "p_DOB";
            this.p_DOB.Size = new System.Drawing.Size(68, 20);
            this.p_DOB.TabIndex = 46;
            this.p_DOB.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Date of Birth:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(2, 168);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(35, 13);
            this.label66.TabIndex = 61;
            this.label66.Text = "State:";
            // 
            // p_phoneNumber
            // 
            this.p_phoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "PhoneNumber", true));
            this.p_phoneNumber.Location = new System.Drawing.Point(108, 48);
            this.p_phoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.p_phoneNumber.Mask = "(999) 000-0000";
            this.p_phoneNumber.Name = "p_phoneNumber";
            this.p_phoneNumber.Size = new System.Drawing.Size(116, 20);
            this.p_phoneNumber.TabIndex = 45;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_clearVolunteer);
            this.splitContainer1.Panel2.Controls.Add(this.btn_deleteVolunteer);
            this.splitContainer1.Panel2.Controls.Add(this.btn_addVolunteer);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 718);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1141, 610);
            this.splitContainer2.SplitterDistance = 508;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 610);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 63);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Volunteer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.p_notes);
            this.panel2.Controls.Add(this.p_emergencyContact);
            this.panel2.Controls.Add(this.p_zip);
            this.panel2.Controls.Add(this.p_state);
            this.panel2.Controls.Add(this.p_city);
            this.panel2.Controls.Add(this.p_streetAddress);
            this.panel2.Controls.Add(this.p_email);
            this.panel2.Controls.Add(this.p_lName);
            this.panel2.Controls.Add(this.p_fName);
            this.panel2.Controls.Add(this.label69);
            this.panel2.Controls.Add(this.label68);
            this.panel2.Controls.Add(this.label67);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Controls.Add(this.label65);
            this.panel2.Controls.Add(this.label64);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.p_DOB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.p_phoneNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 529);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "EmergencyEmail", true));
            this.richTextBox2.Location = new System.Drawing.Point(108, 254);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(116, 19);
            this.richTextBox2.TabIndex = 70;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Emergency Email:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluteerDataSource, "EmergencyPhone", true));
            this.richTextBox1.Location = new System.Drawing.Point(108, 232);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(116, 19);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Emergency Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Last Name:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(2, 5);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 13);
            this.label42.TabIndex = 54;
            this.label42.Text = "First Name:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_searchVolunteer);
            this.splitContainer3.Panel1.Controls.Add(this.v_search);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dvgVolunteer);
            this.splitContainer3.Size = new System.Drawing.Size(629, 610);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_searchVolunteer
            // 
            this.btn_searchVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchVolunteer.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_searchVolunteer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_searchVolunteer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_searchVolunteer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_searchVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchVolunteer.Location = new System.Drawing.Point(551, 3);
            this.btn_searchVolunteer.Name = "btn_searchVolunteer";
            this.btn_searchVolunteer.Size = new System.Drawing.Size(75, 23);
            this.btn_searchVolunteer.TabIndex = 1;
            this.btn_searchVolunteer.Text = "Search";
            this.btn_searchVolunteer.UseVisualStyleBackColor = false;
            // 
            // v_search
            // 
            this.v_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_search.Location = new System.Drawing.Point(3, 3);
            this.v_search.Name = "v_search";
            this.v_search.Size = new System.Drawing.Size(519, 20);
            this.v_search.TabIndex = 0;
            // 
            // dvgVolunteer
            // 
            this.dvgVolunteer.AllowUserToAddRows = false;
            this.dvgVolunteer.AllowUserToDeleteRows = false;
            this.dvgVolunteer.AutoGenerateColumns = false;
            this.dvgVolunteer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVolunteer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.emergencyPhoneDataGridViewTextBoxColumn,
            this.emergencyEmailDataGridViewTextBoxColumn,
            this.isWaiverSignedDataGridViewCheckBoxColumn,
            this.isMediaReleasedDataGridViewCheckBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dvgVolunteer.DataSource = this.volunteerBindingSource;
            this.dvgVolunteer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgVolunteer.Location = new System.Drawing.Point(0, 0);
            this.dvgVolunteer.Margin = new System.Windows.Forms.Padding(2);
            this.dvgVolunteer.MultiSelect = false;
            this.dvgVolunteer.Name = "dvgVolunteer";
            this.dvgVolunteer.ReadOnly = true;
            this.dvgVolunteer.RowHeadersVisible = false;
            this.dvgVolunteer.RowTemplate.Height = 33;
            this.dvgVolunteer.Size = new System.Drawing.Size(629, 566);
            this.dvgVolunteer.TabIndex = 44;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            this.emergencyContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emergencyPhoneDataGridViewTextBoxColumn
            // 
            this.emergencyPhoneDataGridViewTextBoxColumn.DataPropertyName = "EmergencyPhone";
            this.emergencyPhoneDataGridViewTextBoxColumn.HeaderText = "EmergencyPhone";
            this.emergencyPhoneDataGridViewTextBoxColumn.Name = "emergencyPhoneDataGridViewTextBoxColumn";
            this.emergencyPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emergencyEmailDataGridViewTextBoxColumn
            // 
            this.emergencyEmailDataGridViewTextBoxColumn.DataPropertyName = "EmergencyEmail";
            this.emergencyEmailDataGridViewTextBoxColumn.HeaderText = "EmergencyEmail";
            this.emergencyEmailDataGridViewTextBoxColumn.Name = "emergencyEmailDataGridViewTextBoxColumn";
            this.emergencyEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isWaiverSignedDataGridViewCheckBoxColumn
            // 
            this.isWaiverSignedDataGridViewCheckBoxColumn.DataPropertyName = "IsWaiverSigned";
            this.isWaiverSignedDataGridViewCheckBoxColumn.HeaderText = "IsWaiverSigned";
            this.isWaiverSignedDataGridViewCheckBoxColumn.Name = "isWaiverSignedDataGridViewCheckBoxColumn";
            this.isWaiverSignedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isMediaReleasedDataGridViewCheckBoxColumn
            // 
            this.isMediaReleasedDataGridViewCheckBoxColumn.DataPropertyName = "IsMediaReleased";
            this.isMediaReleasedDataGridViewCheckBoxColumn.HeaderText = "IsMediaReleased";
            this.isMediaReleasedDataGridViewCheckBoxColumn.Name = "isMediaReleasedDataGridViewCheckBoxColumn";
            this.isMediaReleasedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataSource = typeof(Common_Ground_Project.Models.Volunteer);
            // 
            // btn_clearVolunteer
            // 
            this.btn_clearVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearVolunteer.Location = new System.Drawing.Point(901, 6);
            this.btn_clearVolunteer.Name = "btn_clearVolunteer";
            this.btn_clearVolunteer.Size = new System.Drawing.Size(75, 23);
            this.btn_clearVolunteer.TabIndex = 2;
            this.btn_clearVolunteer.Text = "&Clear";
            // 
            // btn_deleteVolunteer
            // 
            this.btn_deleteVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteVolunteer.BackColor = System.Drawing.Color.LightCoral;
            this.btn_deleteVolunteer.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_deleteVolunteer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteVolunteer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btn_deleteVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteVolunteer.Location = new System.Drawing.Point(982, 6);
            this.btn_deleteVolunteer.Name = "btn_deleteVolunteer";
            this.btn_deleteVolunteer.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteVolunteer.TabIndex = 1;
            this.btn_deleteVolunteer.Text = "Delete";
            this.btn_deleteVolunteer.UseVisualStyleBackColor = false;
            // 
            // btn_addVolunteer
            // 
            this.btn_addVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addVolunteer.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_addVolunteer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_addVolunteer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_addVolunteer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_addVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVolunteer.Location = new System.Drawing.Point(1063, 6);
            this.btn_addVolunteer.Name = "btn_addVolunteer";
            this.btn_addVolunteer.Size = new System.Drawing.Size(75, 23);
            this.btn_addVolunteer.TabIndex = 0;
            this.btn_addVolunteer.Text = "&Add";
            this.btn_addVolunteer.UseVisualStyleBackColor = false;
            // 
            // VolunteerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VolunteerView";
            this.Size = new System.Drawing.Size(1141, 718);
            ((System.ComponentModel.ISupportInitialize)(this.voluteerDataSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVolunteer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox p_notes;
        private System.Windows.Forms.RichTextBox p_emergencyContact;
        private System.Windows.Forms.RichTextBox p_zip;
        private System.Windows.Forms.RichTextBox p_state;
        private System.Windows.Forms.RichTextBox p_city;
        private System.Windows.Forms.RichTextBox p_streetAddress;
        private System.Windows.Forms.RichTextBox p_email;
        private System.Windows.Forms.RichTextBox p_lName;
        private System.Windows.Forms.RichTextBox p_fName;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox p_DOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.MaskedTextBox p_phoneNumber;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_searchVolunteer;
        private System.Windows.Forms.TextBox v_search;
        private System.Windows.Forms.DataGridView dvgVolunteer;
        private System.Windows.Forms.Button btn_clearVolunteer;
        private System.Windows.Forms.Button btn_deleteVolunteer;
        private System.Windows.Forms.Button btn_addVolunteer;
        private System.Windows.Forms.BindingSource voluteerDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isWaiverSignedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMediaReleasedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}
