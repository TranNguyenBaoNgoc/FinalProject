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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habit));
            this.PnlList = new System.Windows.Forms.Panel();
            this.PnlDateAndScroll = new System.Windows.Forms.Panel();
            this.LblMonthYear = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.PictureBox();
            this.BtnPre = new System.Windows.Forms.PictureBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PnlDateAndScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPre)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlList
            // 
            this.PnlList.AutoScroll = true;
            this.PnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.PnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlList.Location = new System.Drawing.Point(0, 66);
            this.PnlList.Margin = new System.Windows.Forms.Padding(4);
            this.PnlList.Name = "PnlList";
            this.PnlList.Size = new System.Drawing.Size(1060, 403);
            this.PnlList.TabIndex = 7;
            // 
            // PnlDateAndScroll
            // 
            this.PnlDateAndScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PnlDateAndScroll.Controls.Add(this.LblMonthYear);
            this.PnlDateAndScroll.Controls.Add(this.LblDate);
            this.PnlDateAndScroll.Controls.Add(this.BtnNext);
            this.PnlDateAndScroll.Controls.Add(this.BtnPre);
            this.PnlDateAndScroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDateAndScroll.Location = new System.Drawing.Point(0, 0);
            this.PnlDateAndScroll.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDateAndScroll.Name = "PnlDateAndScroll";
            this.PnlDateAndScroll.Size = new System.Drawing.Size(1060, 66);
            this.PnlDateAndScroll.TabIndex = 8;
            // 
            // LblMonthYear
            // 
            this.LblMonthYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMonthYear.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.LblMonthYear.ForeColor = System.Drawing.Color.White;
            this.LblMonthYear.Location = new System.Drawing.Point(487, 6);
            this.LblMonthYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMonthYear.Name = "LblMonthYear";
            this.LblMonthYear.Size = new System.Drawing.Size(125, 57);
            this.LblMonthYear.TabIndex = 4;
            this.LblMonthYear.Text = "May 2017,\r\nSaturday";
            this.LblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDate
            // 
            this.LblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDate.Font = new System.Drawing.Font("Century Gothic", 25.75F);
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(405, 6);
            this.LblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(77, 57);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "06";
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(1010, 14);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(40, 37);
            this.BtnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNext.TabIndex = 1;
            this.BtnNext.TabStop = false;
            this.ToolTip1.SetToolTip(this.BtnNext, "Next Day");
            // 
            // BtnPre
            // 
            this.BtnPre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPre.Image = ((System.Drawing.Image)(resources.GetObject("BtnPre.Image")));
            this.BtnPre.Location = new System.Drawing.Point(8, 14);
            this.BtnPre.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(40, 37);
            this.BtnPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPre.TabIndex = 0;
            this.BtnPre.TabStop = false;
            this.ToolTip1.SetToolTip(this.BtnPre, "Previous Day");
            // 
            // Habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlList);
            this.Controls.Add(this.PnlDateAndScroll);
            this.Name = "Habit";
            this.Size = new System.Drawing.Size(1060, 469);
            this.PnlDateAndScroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlList;
        internal System.Windows.Forms.Panel PnlDateAndScroll;
        internal System.Windows.Forms.Label LblMonthYear;
        internal System.Windows.Forms.Label LblDate;
        internal System.Windows.Forms.PictureBox BtnNext;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.PictureBox BtnPre;
    }
}
