namespace Display
{
    partial class Habit
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
            this.PnlList = new System.Windows.Forms.Panel();
            this.PnlDateAndScroll = new System.Windows.Forms.Panel();
            this.LblMonthYear = new System.Windows.Forms.Label();
            this.ToolTipHabit = new System.Windows.Forms.ToolTip(this.components);
            this.PnlDateAndScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlList
            // 
            this.PnlList.AutoScroll = true;
            this.PnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.PnlList.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlList.Location = new System.Drawing.Point(0, 54);
            this.PnlList.Name = "PnlList";
            this.PnlList.Size = new System.Drawing.Size(795, 327);
            this.PnlList.TabIndex = 7;
            // 
            // PnlDateAndScroll
            // 
            this.PnlDateAndScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PnlDateAndScroll.Controls.Add(this.LblMonthYear);
            this.PnlDateAndScroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDateAndScroll.Location = new System.Drawing.Point(0, 0);
            this.PnlDateAndScroll.Name = "PnlDateAndScroll";
            this.PnlDateAndScroll.Size = new System.Drawing.Size(795, 54);
            this.PnlDateAndScroll.TabIndex = 8;
            // 
            // LblMonthYear
            // 
            this.LblMonthYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMonthYear.Font = new System.Drawing.Font("Bradley Hand ITC", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthYear.ForeColor = System.Drawing.Color.White;
            this.LblMonthYear.Location = new System.Drawing.Point(32, 5);
            this.LblMonthYear.Name = "LblMonthYear";
            this.LblMonthYear.Size = new System.Drawing.Size(732, 46);
            this.LblMonthYear.TabIndex = 4;
            this.LblMonthYear.Text = "Successful people are simply those with successful habits.";
            this.LblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlList);
            this.Controls.Add(this.PnlDateAndScroll);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Habit";
            this.Size = new System.Drawing.Size(795, 381);
            this.PnlDateAndScroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlList;
        internal System.Windows.Forms.Panel PnlDateAndScroll;
        internal System.Windows.Forms.Label LblMonthYear;
        internal System.Windows.Forms.ToolTip ToolTipHabit;
    }
}
