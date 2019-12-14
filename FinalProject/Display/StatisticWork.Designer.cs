namespace Display
{
    partial class StatisticWork
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.C1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Mc1 = new System.Windows.Forms.MonthCalendar();
            this.BtnWork = new System.Windows.Forms.RadioButton();
            this.BtnHabit = new System.Windows.Forms.RadioButton();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            this.SuspendLayout();
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.C1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.C1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.C1.Legends.Add(legend1);
            this.C1.Location = new System.Drawing.Point(0, 3);
            this.C1.Name = "C1";
            series1.BorderColor = System.Drawing.Color.Maroon;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Crimson;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Legend = "Legend1";
            series1.Name = "Your Productivity";
            this.C1.Series.Add(series1);
            this.C1.Size = new System.Drawing.Size(742, 384);
            this.C1.TabIndex = 46;
            this.C1.Text = "C1";
            // 
            // Mc1
            // 
            this.Mc1.BackColor = System.Drawing.Color.DarkRed;
            this.Mc1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Mc1.Location = new System.Drawing.Point(591, 180);
            this.Mc1.Name = "Mc1";
            this.Mc1.TabIndex = 47;
            // 
            // BtnWork
            // 
            this.BtnWork.AutoSize = true;
            this.BtnWork.Checked = true;
            this.BtnWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnWork.Location = new System.Drawing.Point(591, 87);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(81, 17);
            this.BtnWork.TabIndex = 48;
            this.BtnWork.TabStop = true;
            this.BtnWork.Text = "Work Mode";
            this.BtnWork.UseVisualStyleBackColor = true;
            // 
            // BtnHabit
            // 
            this.BtnHabit.AutoCheck = false;
            this.BtnHabit.AutoSize = true;
            this.BtnHabit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHabit.Location = new System.Drawing.Point(682, 87);
            this.BtnHabit.Name = "BtnHabit";
            this.BtnHabit.Size = new System.Drawing.Size(80, 17);
            this.BtnHabit.TabIndex = 49;
            this.BtnHabit.TabStop = true;
            this.BtnHabit.Text = "Habit Mode";
            this.BtnHabit.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(591, 120);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(171, 35);
            this.BtnShow.TabIndex = 50;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            // 
            // StatisticWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnHabit);
            this.Controls.Add(this.BtnWork);
            this.Controls.Add(this.Mc1);
            this.Controls.Add(this.C1);
            this.Name = "StatisticWork";
            this.Size = new System.Drawing.Size(796, 390);
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart C1;
        private System.Windows.Forms.MonthCalendar Mc1;
        private System.Windows.Forms.RadioButton BtnWork;
        private System.Windows.Forms.RadioButton BtnHabit;
        private System.Windows.Forms.Button BtnShow;



    }
}