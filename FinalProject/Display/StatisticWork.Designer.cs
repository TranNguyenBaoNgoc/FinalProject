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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.C1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Mc1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            this.SuspendLayout();
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.C1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.Name = "CA1";
            this.C1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.C1.Legends.Add(legend1);
            this.C1.Location = new System.Drawing.Point(0, 3);
            this.C1.Name = "C1";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "CA1";
            series1.Color = System.Drawing.Color.Crimson;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Legend = "Legend1";
            series1.Name = "Your Productivity";
            series1.YValuesPerPoint = 4;
            this.C1.Series.Add(series1);
            this.C1.Size = new System.Drawing.Size(765, 384);
            this.C1.TabIndex = 46;
            this.C1.Text = "C1";
            title1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Tl1";
            title1.Text = "Completed Tasks Of Selected Day By Percentage";
            this.C1.Titles.Add(title1);
            // 
            // Mc1
            // 
            this.Mc1.BackColor = System.Drawing.Color.DarkRed;
            this.Mc1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Mc1.Location = new System.Drawing.Point(594, 181);
            this.Mc1.MaxSelectionCount = 1;
            this.Mc1.Name = "Mc1";
            this.Mc1.TabIndex = 47;
            // 
            // StatisticWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Mc1);
            this.Controls.Add(this.C1);
            this.Name = "StatisticWork";
            this.Size = new System.Drawing.Size(796, 390);
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart C1;
        internal System.Windows.Forms.MonthCalendar Mc1;



    }
}