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
            this.individualTab = new System.Windows.Forms.TabPage();
            this.individualView1 = new Common_Ground_Project.Views.IndividualView();
            this.activityTab = new System.Windows.Forms.TabPage();
            this.vehicleTab = new System.Windows.Forms.TabPage();
            this.vehicalView1 = new Common_Ground_Project.Views.VehicalView();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.adminView1 = new Common_Ground_Project.Views.AdminView();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.frequentCallerReport1 = new Common_Ground_Project.Views.FrequentCallerReport();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userDayReport1 = new Common_Ground_Project.Views.UserDayReport();
            this.activityView1 = new Common_Ground_Project.Views.ActivityView();
            this.tabControl1.SuspendLayout();
            this.individualTab.SuspendLayout();
            this.activityTab.SuspendLayout();
            this.vehicleTab.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.individualTab);
            this.tabControl1.Controls.Add(this.activityTab);
            this.tabControl1.Controls.Add(this.vehicleTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Controls.Add(this.reportTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1397, 603);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // individualTab
            // 
            this.individualTab.Controls.Add(this.individualView1);
            this.individualTab.Location = new System.Drawing.Point(25, 4);
            this.individualTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.individualTab.Name = "individualTab";
            this.individualTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.individualTab.Size = new System.Drawing.Size(1368, 595);
            this.individualTab.TabIndex = 0;
            this.individualTab.Text = "Individual";
            this.individualTab.UseVisualStyleBackColor = true;
            // 
            // individualView1
            // 
            this.individualView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.individualView1.Location = new System.Drawing.Point(4, 4);
            this.individualView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.individualView1.Name = "individualView1";
            this.individualView1.Size = new System.Drawing.Size(1360, 587);
            this.individualView1.TabIndex = 0;
            // 
            // activityTab
            // 
            this.activityTab.Controls.Add(this.activityView1);
            this.activityTab.Location = new System.Drawing.Point(25, 4);
            this.activityTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityTab.Name = "activityTab";
            this.activityTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityTab.Size = new System.Drawing.Size(1368, 595);
            this.activityTab.TabIndex = 1;
            this.activityTab.Text = "Activity";
            this.activityTab.UseVisualStyleBackColor = true;
            // 
            // vehicleTab
            // 
            this.vehicleTab.Controls.Add(this.vehicalView1);
            this.vehicleTab.Location = new System.Drawing.Point(25, 4);
            this.vehicleTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vehicleTab.Name = "vehicleTab";
            this.vehicleTab.Size = new System.Drawing.Size(1368, 595);
            this.vehicleTab.TabIndex = 2;
            this.vehicleTab.Text = "Vehicles";
            this.vehicleTab.UseVisualStyleBackColor = true;
            // 
            // vehicalView1
            // 
            this.vehicalView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicalView1.Location = new System.Drawing.Point(0, 0);
            this.vehicalView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.vehicalView1.Name = "vehicalView1";
            this.vehicalView1.Size = new System.Drawing.Size(1368, 595);
            this.vehicalView1.TabIndex = 0;
            // 
            // adminTab
            // 
            this.adminTab.BackColor = System.Drawing.Color.Transparent;
            this.adminTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminTab.Controls.Add(this.adminView1);
            this.adminTab.Location = new System.Drawing.Point(25, 4);
            this.adminTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(1368, 595);
            this.adminTab.TabIndex = 4;
            this.adminTab.Text = "Admin";
            // 
            // adminView1
            // 
            this.adminView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminView1.Location = new System.Drawing.Point(0, 0);
            this.adminView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminView1.Name = "adminView1";
            this.adminView1.Size = new System.Drawing.Size(1368, 595);
            this.adminView1.TabIndex = 0;
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.tabControl2);
            this.reportTab.Location = new System.Drawing.Point(25, 4);
            this.reportTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportTab.Size = new System.Drawing.Size(1368, 595);
            this.reportTab.TabIndex = 3;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1360, 587);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.frequentCallerReport1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1352, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Frequent Caller";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frequentCallerReport1
            // 
            this.frequentCallerReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequentCallerReport1.Location = new System.Drawing.Point(4, 4);
            this.frequentCallerReport1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frequentCallerReport1.Name = "frequentCallerReport1";
            this.frequentCallerReport1.Size = new System.Drawing.Size(1344, 550);
            this.frequentCallerReport1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userDayReport1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1345, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Days";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userDayReport1
            // 
            this.userDayReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDayReport1.Location = new System.Drawing.Point(4, 4);
            this.userDayReport1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userDayReport1.Name = "userDayReport1";
            this.userDayReport1.Size = new System.Drawing.Size(1337, 549);
            this.userDayReport1.TabIndex = 0;
            // 
            // activityView1
            // 
            this.activityView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityView1.Location = new System.Drawing.Point(4, 4);
            this.activityView1.Margin = new System.Windows.Forms.Padding(4);
            this.activityView1.Name = "activityView1";
            this.activityView1.Size = new System.Drawing.Size(1360, 587);
            this.activityView1.TabIndex = 0;
            // 
            // CommonGroundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 603);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CommonGroundsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Common Grounds";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommonGroundsForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.individualTab.ResumeLayout(false);
            this.activityTab.ResumeLayout(false);
            this.vehicleTab.ResumeLayout(false);
            this.adminTab.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage individualTab;
        private System.Windows.Forms.TabPage activityTab;
        private Views.IndividualView individualView1;
        private System.Windows.Forms.TabPage vehicleTab;
        private Views.VehicalView vehicalView1;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Views.FrequentCallerReport frequentCallerReport1;
        private Views.UserDayReport userDayReport1;
        private System.Windows.Forms.TabPage adminTab;
        private Views.AdminView adminView1;
        private Views.ActivityView activityView1;
    }
}