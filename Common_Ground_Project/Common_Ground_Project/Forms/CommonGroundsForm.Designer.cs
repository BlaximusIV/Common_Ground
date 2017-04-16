namespace Common_Ground_Project.Forms
{
    partial class CommonGroundsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.participantView1 = new Common_Ground_Project.Views.ParticipantView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.volunteerView1 = new Common_Ground_Project.Views.VolunteerView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.staffView1 = new Common_Ground_Project.Views.StaffView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 385);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.participantView1);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(654, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participants";
            // 
            // participantView1
            // 
            this.participantView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantView1.Location = new System.Drawing.Point(2, 2);
            this.participantView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.participantView1.Name = "participantView1";
            this.participantView1.Size = new System.Drawing.Size(650, 373);
            this.participantView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.volunteerView1);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(654, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Volunteers";
            // 
            // volunteerView1
            // 
            this.volunteerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volunteerView1.Location = new System.Drawing.Point(2, 2);
            this.volunteerView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.volunteerView1.Name = "volunteerView1";
            this.volunteerView1.Size = new System.Drawing.Size(650, 373);
            this.volunteerView1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.staffView1);
            this.tabPage6.Location = new System.Drawing.Point(23, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(654, 377);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Staff";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Activities";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Location = new System.Drawing.Point(23, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(780, 545);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Reports";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 545);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Manage";
            // 
            // staffView1
            // 
            this.staffView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffView1.Location = new System.Drawing.Point(3, 3);
            this.staffView1.Name = "staffView1";
            this.staffView1.Size = new System.Drawing.Size(648, 371);
            this.staffView1.TabIndex = 0;
            // 
            // CommonGroundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "CommonGroundsForm";
            this.Text = "Common Grounds Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private Views.ParticipantView participantView1;
        private Views.VolunteerView volunteerView1;
        private Views.StaffView staffView1;
    }
}