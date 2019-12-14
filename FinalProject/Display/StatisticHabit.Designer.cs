namespace Display
{
    partial class StatisticHabit
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
            this.BtnHabit = new System.Windows.Forms.RadioButton();
            this.BtnWork = new System.Windows.Forms.RadioButton();
            this.Mc1 = new System.Windows.Forms.MonthCalendar();
            this.GrdHabit = new System.Windows.Forms.DataGridView();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdHabit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHabit
            // 
            this.BtnHabit.AutoSize = true;
            this.BtnHabit.Checked = true;
            this.BtnHabit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHabit.Location = new System.Drawing.Point(700, 44);
            this.BtnHabit.Name = "BtnHabit";
            this.BtnHabit.Size = new System.Drawing.Size(80, 17);
            this.BtnHabit.TabIndex = 58;
            this.BtnHabit.TabStop = true;
            this.BtnHabit.Text = "Habit Mode";
            this.BtnHabit.UseVisualStyleBackColor = true;
            // 
            // BtnWork
            // 
            this.BtnWork.AutoSize = true;
            this.BtnWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnWork.Location = new System.Drawing.Point(609, 44);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.Size = new System.Drawing.Size(81, 17);
            this.BtnWork.TabIndex = 57;
            this.BtnWork.Text = "Work Mode";
            this.BtnWork.UseVisualStyleBackColor = true;
            // 
            // Mc1
            // 
            this.Mc1.BackColor = System.Drawing.Color.DarkRed;
            this.Mc1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Mc1.Location = new System.Drawing.Point(609, 170);
            this.Mc1.Name = "Mc1";
            this.Mc1.TabIndex = 56;
            // 
            // GrdHabit
            // 
            this.GrdHabit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdHabit.Location = new System.Drawing.Point(9, 3);
            this.GrdHabit.Name = "GrdHabit";
            this.GrdHabit.Size = new System.Drawing.Size(588, 372);
            this.GrdHabit.TabIndex = 59;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(609, 94);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(171, 35);
            this.BtnShow.TabIndex = 60;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            // 
            // StatisticHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.GrdHabit);
            this.Controls.Add(this.BtnHabit);
            this.Controls.Add(this.BtnWork);
            this.Controls.Add(this.Mc1);
            this.Name = "StatisticHabit";
            this.Size = new System.Drawing.Size(796, 390);
            ((System.ComponentModel.ISupportInitialize)(this.GrdHabit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BtnHabit;
        private System.Windows.Forms.RadioButton BtnWork;
        private System.Windows.Forms.MonthCalendar Mc1;
        private System.Windows.Forms.DataGridView GrdHabit;
        private System.Windows.Forms.Button BtnShow;

    }
}