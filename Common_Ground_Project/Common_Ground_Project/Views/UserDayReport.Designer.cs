namespace Common_Ground_Project.Views
{
    partial class UserDayReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddEContactButton = new System.Windows.Forms.Button();
            this.toUserDay = new System.Windows.Forms.DateTimePicker();
            this.fromUserDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userDayGrid = new System.Windows.Forms.DataGridView();
            this.userDayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDayChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userDayChart);
            this.splitContainer1.Size = new System.Drawing.Size(860, 528);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.AddEContactButton);
            this.splitContainer2.Panel1.Controls.Add(this.toUserDay);
            this.splitContainer2.Panel1.Controls.Add(this.fromUserDay);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.userDayGrid);
            this.splitContainer2.Size = new System.Drawing.Size(287, 528);
            this.splitContainer2.SplitterDistance = 82;
            this.splitContainer2.TabIndex = 0;
            // 
            // AddEContactButton
            // 
            this.AddEContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEContactButton.BackColor = System.Drawing.Color.PaleGreen;
            this.AddEContactButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.AddEContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.AddEContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.AddEContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEContactButton.Location = new System.Drawing.Point(-369, 56);
            this.AddEContactButton.Name = "AddEContactButton";
            this.AddEContactButton.Size = new System.Drawing.Size(80, 23);
            this.AddEContactButton.TabIndex = 7;
            this.AddEContactButton.Text = "Generate";
            this.AddEContactButton.UseVisualStyleBackColor = false;
            this.AddEContactButton.Click += new System.EventHandler(this.AddEContactButton_Click);
            // 
            // toUserDay
            // 
            this.toUserDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toUserDay.Location = new System.Drawing.Point(84, 29);
            this.toUserDay.Name = "toUserDay";
            this.toUserDay.Size = new System.Drawing.Size(200, 20);
            this.toUserDay.TabIndex = 3;
            this.toUserDay.Value = new System.DateTime(2017, 4, 19, 23, 13, 10, 0);
            // 
            // fromUserDay
            // 
            this.fromUserDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromUserDay.Location = new System.Drawing.Point(84, 3);
            this.fromUserDay.Name = "fromUserDay";
            this.fromUserDay.Size = new System.Drawing.Size(200, 20);
            this.fromUserDay.TabIndex = 2;
            this.fromUserDay.Value = new System.DateTime(2017, 4, 19, 23, 13, 4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // userDayGrid
            // 
            this.userDayGrid.AllowUserToAddRows = false;
            this.userDayGrid.AllowUserToDeleteRows = false;
            this.userDayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDayGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDayGrid.Enabled = false;
            this.userDayGrid.Location = new System.Drawing.Point(0, 0);
            this.userDayGrid.Name = "userDayGrid";
            this.userDayGrid.RowHeadersVisible = false;
            this.userDayGrid.Size = new System.Drawing.Size(287, 442);
            this.userDayGrid.TabIndex = 1;
            // 
            // userDayChart
            // 
            chartArea4.Name = "ChartArea1";
            this.userDayChart.ChartAreas.Add(chartArea4);
            this.userDayChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.userDayChart.Legends.Add(legend4);
            this.userDayChart.Location = new System.Drawing.Point(0, 0);
            this.userDayChart.Name = "userDayChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.userDayChart.Series.Add(series4);
            this.userDayChart.Size = new System.Drawing.Size(569, 528);
            this.userDayChart.TabIndex = 0;
            this.userDayChart.Text = "chart1";
            // 
            // UserDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserDayReport";
            this.Size = new System.Drawing.Size(860, 528);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDayChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart userDayChart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView userDayGrid;
        private System.Windows.Forms.DateTimePicker toUserDay;
        private System.Windows.Forms.DateTimePicker fromUserDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEContactButton;
    }
}
