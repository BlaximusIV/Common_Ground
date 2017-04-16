namespace Common_Ground_Project.Views
{
    partial class StaffView
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
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.staffDataSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p_DOB = new System.Windows.Forms.MaskedTextBox();
            this.btn_ClearParticipant = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.btn_Addparticipant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_searchParticipant = new System.Windows.Forms.Button();
            this.p_search = new System.Windows.Forms.TextBox();
            this.dvgParticipant = new System.Windows.Forms.DataGridView();
            this.btn_deleteParticipant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.staffDataSource, "IsMediaReleased", true));
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.staffDataSource, "IsMediaReleased", true));
            this.checkBox7.Location = new System.Drawing.Point(5, 300);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(97, 17);
            this.checkBox7.TabIndex = 66;
            this.checkBox7.Text = "Media Release";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // staffDataSource
            // 
            this.staffDataSource.DataSource = typeof(Common_Ground_Project.Models.Staff);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.staffDataSource, "IsWaiverSigned", true));
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.staffDataSource, "IsWaiverSigned", true));
            this.checkBox2.Location = new System.Drawing.Point(5, 279);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Waiver Signed";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // p_notes
            // 
            this.p_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "Note", true));
            this.p_notes.Location = new System.Drawing.Point(5, 349);
            this.p_notes.Margin = new System.Windows.Forms.Padding(2);
            this.p_notes.Name = "p_notes";
            this.p_notes.Size = new System.Drawing.Size(284, 113);
            this.p_notes.TabIndex = 53;
            this.p_notes.Text = "";
            // 
            // p_emergencyContact
            // 
            this.p_emergencyContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "EmergencyContact", true));
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
            this.p_zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "ZipCode", true));
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
            this.p_state.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "State", true));
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
            this.p_city.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "City", true));
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
            this.p_streetAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "StreetAddress", true));
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
            this.p_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "EmailAddress", true));
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
            this.p_lName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "LastName", true));
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
            this.p_fName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "FirstName", true));
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
            this.label69.Location = new System.Drawing.Point(2, 334);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(38, 13);
            this.label69.TabIndex = 64;
            this.label69.Text = "Notes:";
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
            this.p_DOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "BirthDay", true));
            this.p_DOB.Location = new System.Drawing.Point(108, 72);
            this.p_DOB.Margin = new System.Windows.Forms.Padding(2);
            this.p_DOB.Mask = "00/00/0000";
            this.p_DOB.Name = "p_DOB";
            this.p_DOB.Size = new System.Drawing.Size(68, 20);
            this.p_DOB.TabIndex = 46;
            this.p_DOB.ValidatingType = typeof(System.DateTime);
            // 
            // btn_ClearParticipant
            // 
            this.btn_ClearParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearParticipant.Location = new System.Drawing.Point(858, 6);
            this.btn_ClearParticipant.Name = "btn_ClearParticipant";
            this.btn_ClearParticipant.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearParticipant.TabIndex = 2;
            this.btn_ClearParticipant.Text = "&Clear";
            this.btn_ClearParticipant.UseVisualStyleBackColor = true;
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
            // btn_Addparticipant
            // 
            this.btn_Addparticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Addparticipant.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Addparticipant.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Addparticipant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Addparticipant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_Addparticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addparticipant.Location = new System.Drawing.Point(1020, 6);
            this.btn_Addparticipant.Name = "btn_Addparticipant";
            this.btn_Addparticipant.Size = new System.Drawing.Size(75, 23);
            this.btn_Addparticipant.TabIndex = 0;
            this.btn_Addparticipant.Text = "&Add";
            this.btn_Addparticipant.UseVisualStyleBackColor = false;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.splitContainer1.Panel2.Controls.Add(this.btn_ClearParticipant);
            this.splitContainer1.Panel2.Controls.Add(this.btn_deleteParticipant);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Addparticipant);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 712);
            this.splitContainer1.SplitterDistance = 676;
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
            this.splitContainer2.Size = new System.Drawing.Size(1098, 676);
            this.splitContainer2.SplitterDistance = 297;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 676);
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
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Staff";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label2);
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
            this.richTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "EmergencyEmail", true));
            this.richTextBox2.Location = new System.Drawing.Point(108, 257);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(116, 19);
            this.richTextBox2.TabIndex = 70;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "EmergencyPhone", true));
            this.richTextBox1.Location = new System.Drawing.Point(108, 234);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(116, 19);
            this.richTextBox1.TabIndex = 69;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Emergency Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Emergency Phone:";
            // 
            // p_phoneNumber
            // 
            this.p_phoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffDataSource, "PhoneNumber", true));
            this.p_phoneNumber.Location = new System.Drawing.Point(108, 48);
            this.p_phoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.p_phoneNumber.Mask = "(999) 000-0000";
            this.p_phoneNumber.Name = "p_phoneNumber";
            this.p_phoneNumber.Size = new System.Drawing.Size(116, 20);
            this.p_phoneNumber.TabIndex = 45;
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
            this.splitContainer3.Panel1.Controls.Add(this.btn_searchParticipant);
            this.splitContainer3.Panel1.Controls.Add(this.p_search);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dvgParticipant);
            this.splitContainer3.Size = new System.Drawing.Size(797, 676);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_searchParticipant
            // 
            this.btn_searchParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchParticipant.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_searchParticipant.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_searchParticipant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_searchParticipant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btn_searchParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchParticipant.Location = new System.Drawing.Point(719, 3);
            this.btn_searchParticipant.Name = "btn_searchParticipant";
            this.btn_searchParticipant.Size = new System.Drawing.Size(75, 23);
            this.btn_searchParticipant.TabIndex = 1;
            this.btn_searchParticipant.Text = "Search";
            this.btn_searchParticipant.UseVisualStyleBackColor = false;
            // 
            // p_search
            // 
            this.p_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_search.Location = new System.Drawing.Point(3, 3);
            this.p_search.Name = "p_search";
            this.p_search.Size = new System.Drawing.Size(687, 20);
            this.p_search.TabIndex = 0;
            // 
            // dvgParticipant
            // 
            this.dvgParticipant.AllowUserToAddRows = false;
            this.dvgParticipant.AllowUserToDeleteRows = false;
            this.dvgParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgParticipant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgParticipant.Location = new System.Drawing.Point(0, 0);
            this.dvgParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.dvgParticipant.MultiSelect = false;
            this.dvgParticipant.Name = "dvgParticipant";
            this.dvgParticipant.ReadOnly = true;
            this.dvgParticipant.RowHeadersVisible = false;
            this.dvgParticipant.RowTemplate.Height = 33;
            this.dvgParticipant.Size = new System.Drawing.Size(797, 632);
            this.dvgParticipant.TabIndex = 44;
            // 
            // btn_deleteParticipant
            // 
            this.btn_deleteParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteParticipant.BackColor = System.Drawing.Color.LightCoral;
            this.btn_deleteParticipant.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_deleteParticipant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteParticipant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btn_deleteParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteParticipant.Location = new System.Drawing.Point(939, 6);
            this.btn_deleteParticipant.Name = "btn_deleteParticipant";
            this.btn_deleteParticipant.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteParticipant.TabIndex = 1;
            this.btn_deleteParticipant.Text = "Delete";
            this.btn_deleteParticipant.UseVisualStyleBackColor = false;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "StaffView";
            this.Size = new System.Drawing.Size(1098, 712);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgParticipant)).EndInit();
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
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox p_DOB;
        private System.Windows.Forms.Button btn_ClearParticipant;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btn_Addparticipant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox p_phoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_searchParticipant;
        private System.Windows.Forms.TextBox p_search;
        private System.Windows.Forms.DataGridView dvgParticipant;
        private System.Windows.Forms.Button btn_deleteParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource staffDataSource;
    }
}
