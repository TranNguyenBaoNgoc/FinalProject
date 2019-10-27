namespace Display
{
    partial class Day
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Day));
            this.List = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.Date1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Pre = new System.Windows.Forms.PictureBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pre)).BeginInit();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.AutoScroll = true;
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.Location = new System.Drawing.Point(0, 66);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(1060, 421);
            this.List.TabIndex = 5;
            this.List.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel1.Controls.Add(this.Date);
            this.Panel1.Controls.Add(this.Date1);
            this.Panel1.Controls.Add(this.Next);
            this.Panel1.Controls.Add(this.Pre);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1060, 66);
            this.Panel1.TabIndex = 6;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(487, 6);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(125, 57);
            this.Date.TabIndex = 4;
            this.Date.Text = "May 2017,\r\nSaturday";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Date.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Date1
            // 
            this.Date1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date1.Font = new System.Drawing.Font("Century Gothic", 25.75F);
            this.Date1.ForeColor = System.Drawing.Color.White;
            this.Date1.Location = new System.Drawing.Point(405, 6);
            this.Date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(77, 57);
            this.Date1.TabIndex = 2;
            this.Date1.Text = "06";
            this.Date1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Date1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.Location = new System.Drawing.Point(1010, 14);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(40, 37);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next.TabIndex = 1;
            this.Next.TabStop = false;
            this.ToolTip1.SetToolTip(this.Next, "Next Day");
            this.Next.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Pre
            // 
            this.Pre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pre.Image = ((System.Drawing.Image)(resources.GetObject("Pre.Image")));
            this.Pre.Location = new System.Drawing.Point(8, 14);
            this.Pre.Margin = new System.Windows.Forms.Padding(4);
            this.Pre.Name = "Pre";
            this.Pre.Size = new System.Drawing.Size(40, 37);
            this.Pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pre.TabIndex = 0;
            this.Pre.TabStop = false;
            this.ToolTip1.SetToolTip(this.Pre, "Previous Day");
            this.Pre.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.List);
            this.Controls.Add(this.Panel1);
            this.Name = "Day";
            this.Size = new System.Drawing.Size(1060, 487);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel List;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Date;
        internal System.Windows.Forms.Label Date1;
        internal System.Windows.Forms.PictureBox Next;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.PictureBox Pre;
    }
}
