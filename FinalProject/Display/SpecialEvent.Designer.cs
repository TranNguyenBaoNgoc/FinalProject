namespace Display
{
    partial class SpecialEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialEvent));
            this.PnlList = new System.Windows.Forms.Panel();
            this.ToolTipSpecEvent = new System.Windows.Forms.ToolTip(this.components);
            this.PnlControl = new System.Windows.Forms.Panel();
            this.LblMonthYear = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.BtnPre = new System.Windows.Forms.PictureBox();
            this.BtnNext = new System.Windows.Forms.PictureBox();
            this.PnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).BeginInit();
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
            this.PnlList.Size = new System.Drawing.Size(1059, 403);
            this.PnlList.TabIndex = 11;
            // 
            // PnlControl
            // 
            this.PnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PnlControl.Controls.Add(this.BtnNext);
            this.PnlControl.Controls.Add(this.LblMonthYear);
            this.PnlControl.Controls.Add(this.LblDay);
            this.PnlControl.Controls.Add(this.BtnPre);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(1059, 66);
            this.PnlControl.TabIndex = 10;
            // 
            // LblMonthYear
            // 
            this.LblMonthYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMonthYear.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.LblMonthYear.ForeColor = System.Drawing.Color.White;
            this.LblMonthYear.Location = new System.Drawing.Point(489, 5);
            this.LblMonthYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMonthYear.Name = "LblMonthYear";
            this.LblMonthYear.Size = new System.Drawing.Size(125, 57);
            this.LblMonthYear.TabIndex = 7;
            this.LblMonthYear.Text = "May 2017,\r\nSaturday";
            this.LblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDay
            // 
            this.LblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDay.Font = new System.Drawing.Font("Century Gothic", 25.75F);
            this.LblDay.ForeColor = System.Drawing.Color.White;
            this.LblDay.Location = new System.Drawing.Point(407, 5);
            this.LblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(77, 57);
            this.LblDay.TabIndex = 6;
            this.LblDay.Text = "06";
            this.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnPre
            // 
            this.BtnPre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPre.Image = ((System.Drawing.Image)(resources.GetObject("BtnPre.Image")));
            this.BtnPre.Location = new System.Drawing.Point(8, 13);
            this.BtnPre.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(40, 37);
            this.BtnPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPre.TabIndex = 5;
            this.BtnPre.TabStop = false;
            this.ToolTipSpecEvent.SetToolTip(this.BtnPre, "Previous Day");
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(1015, 13);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(40, 37);
            this.BtnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNext.TabIndex = 8;
            this.BtnNext.TabStop = false;
            this.ToolTipSpecEvent.SetToolTip(this.BtnNext, "Next Day");
            // 
            // SpecialEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.PnlList);
            this.Controls.Add(this.PnlControl);
            this.Name = "SpecialEvent";
            this.Size = new System.Drawing.Size(1059, 469);
            this.PnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlList;
        internal System.Windows.Forms.ToolTip ToolTipSpecEvent;
        internal System.Windows.Forms.Panel PnlControl;
        internal System.Windows.Forms.PictureBox BtnNext;
        internal System.Windows.Forms.Label LblMonthYear;
        internal System.Windows.Forms.Label LblDay;
        internal System.Windows.Forms.PictureBox BtnPre;
    }
}
