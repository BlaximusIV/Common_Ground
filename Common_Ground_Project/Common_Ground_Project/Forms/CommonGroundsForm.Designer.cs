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
            this.activityTab = new System.Windows.Forms.TabPage();
            this.vehicleTab = new System.Windows.Forms.TabPage();
            this.individualView1 = new Common_Ground_Project.Views.IndividualView();
            this.tabControl1.SuspendLayout();
            this.individualTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.individualTab);
            this.tabControl1.Controls.Add(this.activityTab);
            this.tabControl1.Controls.Add(this.vehicleTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // individualTab
            // 
            this.individualTab.Controls.Add(this.individualView1);
            this.individualTab.Location = new System.Drawing.Point(23, 4);
            this.individualTab.Name = "individualTab";
            this.individualTab.Padding = new System.Windows.Forms.Padding(3);
            this.individualTab.Size = new System.Drawing.Size(837, 482);
            this.individualTab.TabIndex = 0;
            this.individualTab.Text = "Individual";
            this.individualTab.UseVisualStyleBackColor = true;
            // 
            // activityTab
            // 
            this.activityTab.Location = new System.Drawing.Point(23, 4);
            this.activityTab.Name = "activityTab";
            this.activityTab.Padding = new System.Windows.Forms.Padding(3);
            this.activityTab.Size = new System.Drawing.Size(837, 482);
            this.activityTab.TabIndex = 1;
            this.activityTab.Text = "Activity";
            this.activityTab.UseVisualStyleBackColor = true;
            // 
            // vehicleTab
            // 
            this.vehicleTab.Location = new System.Drawing.Point(23, 4);
            this.vehicleTab.Name = "vehicleTab";
            this.vehicleTab.Size = new System.Drawing.Size(837, 482);
            this.vehicleTab.TabIndex = 2;
            this.vehicleTab.Text = "Vehicles";
            this.vehicleTab.UseVisualStyleBackColor = true;
            // 
            // individualView1
            // 
            this.individualView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.individualView1.Location = new System.Drawing.Point(3, 3);
            this.individualView1.Name = "individualView1";
            this.individualView1.Size = new System.Drawing.Size(831, 476);
            this.individualView1.TabIndex = 0;
            // 
            // CommonGroundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "CommonGroundsForm";
            this.Text = "Common Grounds";
            this.tabControl1.ResumeLayout(false);
            this.individualTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage individualTab;
        private System.Windows.Forms.TabPage activityTab;
        private Views.IndividualView individualView1;
        private System.Windows.Forms.TabPage vehicleTab;
    }
}