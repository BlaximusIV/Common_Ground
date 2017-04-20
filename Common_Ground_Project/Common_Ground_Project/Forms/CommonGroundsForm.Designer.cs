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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonGroundsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.individualTab = new System.Windows.Forms.TabPage();
            this.individualView1 = new Common_Ground_Project.Views.IndividualView();
            this.activityTab = new System.Windows.Forms.TabPage();
            this.activityView1 = new Common_Ground_Project.Views.ActivityView();
            this.vehicleTab = new System.Windows.Forms.TabPage();
            this.vehicalView1 = new Common_Ground_Project.Views.VehicalView();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.frequentCallers = new System.Windows.Forms.ToolStripButton();
            this.userDays = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.individualTab.SuspendLayout();
            this.activityTab.SuspendLayout();
            this.vehicleTab.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.individualTab);
            this.tabControl1.Controls.Add(this.activityTab);
            this.tabControl1.Controls.Add(this.vehicleTab);
            this.tabControl1.Controls.Add(this.reportTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // individualTab
            // 
            this.individualTab.Controls.Add(this.individualView1);
            this.individualTab.Location = new System.Drawing.Point(23, 4);
            this.individualTab.Name = "individualTab";
            this.individualTab.Padding = new System.Windows.Forms.Padding(3);
            this.individualTab.Size = new System.Drawing.Size(1021, 482);
            this.individualTab.TabIndex = 0;
            this.individualTab.Text = "Individual";
            this.individualTab.UseVisualStyleBackColor = true;
            // 
            // individualView1
            // 
            this.individualView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.individualView1.Location = new System.Drawing.Point(3, 3);
            this.individualView1.Name = "individualView1";
            this.individualView1.Size = new System.Drawing.Size(1015, 476);
            this.individualView1.TabIndex = 0;
            // 
            // activityTab
            // 
            this.activityTab.Controls.Add(this.activityView1);
            this.activityTab.Location = new System.Drawing.Point(23, 4);
            this.activityTab.Name = "activityTab";
            this.activityTab.Padding = new System.Windows.Forms.Padding(3);
            this.activityTab.Size = new System.Drawing.Size(1021, 482);
            this.activityTab.TabIndex = 1;
            this.activityTab.Text = "Activity";
            this.activityTab.UseVisualStyleBackColor = true;
            // 
            // activityView1
            // 
            this.activityView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityView1.Location = new System.Drawing.Point(3, 3);
            this.activityView1.Name = "activityView1";
            this.activityView1.Size = new System.Drawing.Size(1015, 476);
            this.activityView1.TabIndex = 0;
            // 
            // vehicleTab
            // 
            this.vehicleTab.Controls.Add(this.vehicalView1);
            this.vehicleTab.Location = new System.Drawing.Point(23, 4);
            this.vehicleTab.Name = "vehicleTab";
            this.vehicleTab.Size = new System.Drawing.Size(1021, 482);
            this.vehicleTab.TabIndex = 2;
            this.vehicleTab.Text = "Vehicles";
            this.vehicleTab.UseVisualStyleBackColor = true;
            // 
            // vehicalView1
            // 
            this.vehicalView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicalView1.Location = new System.Drawing.Point(0, 0);
            this.vehicalView1.Name = "vehicalView1";
            this.vehicalView1.Size = new System.Drawing.Size(1021, 482);
            this.vehicalView1.TabIndex = 0;
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.toolStrip1);
            this.reportTab.Location = new System.Drawing.Point(23, 4);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(1021, 482);
            this.reportTab.TabIndex = 3;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frequentCallers,
            this.userDays});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frequentCallers
            // 
            this.frequentCallers.Image = ((System.Drawing.Image)(resources.GetObject("frequentCallers.Image")));
            this.frequentCallers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frequentCallers.Name = "frequentCallers";
            this.frequentCallers.Size = new System.Drawing.Size(112, 22);
            this.frequentCallers.Text = "Frequent Callers";
            // 
            // userDays
            // 
            this.userDays.Image = ((System.Drawing.Image)(resources.GetObject("userDays.Image")));
            this.userDays.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userDays.Name = "userDays";
            this.userDays.Size = new System.Drawing.Size(78, 22);
            this.userDays.Text = "User Days";
            // 
            // CommonGroundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "CommonGroundsForm";
            this.Text = "Common Grounds";
            this.tabControl1.ResumeLayout(false);
            this.individualTab.ResumeLayout(false);
            this.activityTab.ResumeLayout(false);
            this.vehicleTab.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage individualTab;
        private System.Windows.Forms.TabPage activityTab;
        private Views.IndividualView individualView1;
        private System.Windows.Forms.TabPage vehicleTab;
        private Views.ActivityView activityView1;
        private Views.VehicalView vehicalView1;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton frequentCallers;
        private System.Windows.Forms.ToolStripButton userDays;
    }
}