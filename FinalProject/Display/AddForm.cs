using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display
{
    public partial class AddForm : Form
    {
        private LogicLayer Management;
        private int posX;
        private int posY;
        private bool drag;
        public AddForm()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            //control
            this.BtnExit.Click += BtnExit_Click;
            this.BtnClear.Click += BtnClear_Click;
            this.BtnAdd.Click += BtnAdd_Click;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.PnlControl.MouseDown += PnlControl_MouseDown;
            this.PnlControl.MouseMove += PnlControl_MouseMove;
            this.PnlControl.MouseUp += PnlControl_MouseUp;
            //Replaceforcheckbox
            this.UncheckWork.Click += UncheckWork_Click;
            this.UncheckSpec.Click += UncheckSpec_Click;
            this.UncheckHabit.Click += UncheckHabit_Click;
            this.UncheckPrio.Click += UncheckPrio_Click;
            this.CheckedPrio.Click += CheckedPrio_Click;
            //hiddenletters
            this.TxtTitle.Leave += TxtTitle_Leave;
            this.TxtTitle.Enter += TxtTitle_Enter;
            this.TxtDetails.Leave += TxtDetails_Leave;
            this.TxtDetails.Enter += TxtDetails_Enter;
            this.txtStart.Leave += txtStart_Leave;
            this.txtStart.Enter += txtStart_Enter;
            this.txtEnd.Leave += txtEnd_Leave;
            this.txtEnd.Enter += txtEnd_Enter;
            this.TxtLocation.Leave += TxtLocation_Leave;
            this.TxtLocation.Enter += TxtLocation_Enter;
        }
        //*hiddenletters
        void TxtLocation_Enter(object sender, EventArgs e)
        {
            if (this.TxtLocation.ReadOnly == false)
            {
                if (TxtLocation.Text == "Loction")
                {
                    TxtLocation.Text = "";
                }
            }
        }

        void TxtLocation_Leave(object sender, EventArgs e)
        {
            if (this.TxtLocation.ReadOnly == false)
            {
                if (TxtLocation.Text == "")
                {
                    TxtLocation.Text = "Location";
                }
            }
        }

        void txtEnd_Enter(object sender, EventArgs e)
        {
            if (this.txtEnd.ReadOnly == false)
            {
                if (txtEnd.Text == "09:00 PM...")
                {
                    txtEnd.Text = "";
                }
            }
        }

        void txtEnd_Leave(object sender, EventArgs e)
        {
            if (this.txtEnd.ReadOnly == false)
            {
                if (txtEnd.Text == "")
                {
                    txtEnd.Text = "09:00 PM...";
                }
            }
        }

        void txtStart_Enter(object sender, EventArgs e)
        {
            if (this.txtStart.ReadOnly == false)
            {
                if (txtStart.Text == "09:00 AM...")
                {
                    txtStart.Text = "";
                }
            }
        }

        void txtStart_Leave(object sender, EventArgs e)
        {
            if (this.txtStart.ReadOnly == false)
            {
                if (txtStart.Text == "")
                {
                    txtStart.Text = "09:00 AM...";
                }
            }
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "")
            {
                TxtTitle.Text = "Title";
            }
        }

        private void TxtTitle_Enter(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "Title")
            {
                TxtTitle.Text = "";
            }
        }

        private void TxtDetails_Enter(object sender, EventArgs e)
        {
            if (TxtDetails.Text == "Details")
            {
                TxtDetails.Text = "";
            }
        }

        private void TxtDetails_Leave(object sender, EventArgs e)
        {
            if (TxtDetails.Text == "")
            {
                TxtDetails.Text = "Details";
            }
        }
        //*

        //*replaceforcheckbox
        void CheckedPrio_Click(object sender, EventArgs e)
        {
            this.CheckedPrio.Visible = false;
            this.UncheckPrio.Visible = true;
        }

        void UncheckPrio_Click(object sender, EventArgs e)
        {
            this.UncheckPrio.Visible = false;
            this.CheckedPrio.Visible = true;
        }

        void UncheckHabit_Click(object sender, EventArgs e)
        {
            this.UncheckHabit.Visible = false;
            this.CheckedHabit.Visible = true;
            this.CheckedSpec.Visible = false;
            this.CheckedWork.Visible = false;
            this.UncheckSpec.Visible = true;
            this.UncheckWork.Visible = true;
            this.txtStart.ReadOnly = true;
            this.txtStart.Text = "9:00 AM...";
            this.txtStart.ForeColor = Color.DimGray;
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Text = "9:00 PM...";
            this.txtEnd.ForeColor = Color.DimGray;
            this.TxtLocation.ReadOnly = true;
            this.TxtLocation.Text = "Location";
            this.TxtLocation.ForeColor = Color.DimGray;
        }

        void UncheckSpec_Click(object sender, EventArgs e)
        {
            this.UncheckSpec.Visible = false;
            this.CheckedSpec.Visible = true;
            this.CheckedHabit.Visible = false;
            this.CheckedWork.Visible = false;
            this.UncheckHabit.Visible = true;
            this.UncheckWork.Visible = true;
            this.txtStart.ReadOnly = false;
            this.txtStart.ForeColor = Color.White;
            this.txtEnd.ReadOnly = false;
            this.txtEnd.ForeColor = Color.White;
            this.TxtLocation.ReadOnly = false;
            this.TxtLocation.ForeColor = Color.White;
        }

        void UncheckWork_Click(object sender, EventArgs e)
        {
            this.UncheckWork.Visible = false;
            this.CheckedWork.Visible = true;
            this.CheckedHabit.Visible = false;
            this.CheckedSpec.Visible = false;
            this.UncheckHabit.Visible = true;
            this.UncheckSpec.Visible = true;
            this.txtStart.ReadOnly = true;
            this.txtStart.Text = "9:00 AM...";
            this.txtStart.ForeColor = Color.DimGray;
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Text = "9:00 PM...";
            this.txtEnd.ForeColor = Color.DimGray;
            this.TxtLocation.ReadOnly = true;
            this.TxtLocation.Text = "Location";
            this.TxtLocation.ForeColor = Color.DimGray;
        }
        //*

        //*control
        void PnlControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
                this.Opacity = 1;
            }
        }

        void PnlControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (drag)
                {
                    this.Opacity = 0.75;
                    this.Top = Cursor.Position.Y - posY;
                    this.Left = Cursor.Position.X - posX;
                }
                this.Cursor = Cursors.Default;
            }
        }

        void PnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    drag = true;
                    posX = Cursor.Position.X - this.Left;
                    posY = Cursor.Position.Y - this.Top;
                }
            }
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            var date = this.DTPDate.Value;
            var title = this.TxtTitle.Text;
            var location = "";
            if (this.TxtLocation.Text != "Location")
            {
                location = this.TxtLocation.Text;
            }
            var start = "";
            if (this.txtStart.Text != "09:00 AM...")
            {
                start = this.txtStart.Text;
            }
            var end = "";
            if (this.txtEnd.Text != "09:00 PM...")
            {
                end = this.txtEnd.Text;
            }
            var detail = "";
            if (this.TxtDetails.Text != "09:00 PM...")
            {
                detail = this.TxtDetails.Text;
            }
            var prio = false;
            if (CheckedPrio.Visible == true)
            {
                prio = true;
            }
            var sta = false;
            if ((this.CheckedHabit.Visible == false && this.CheckedSpec.Visible == false
                && this.CheckedWork.Visible == false && this.TxtTitle.Text == "Title") ||
                (this.CheckedHabit.Visible == false && this.CheckedSpec.Visible == false
                && this.CheckedWork.Visible == false && this.TxtTitle.Text == ""))
            {
                MessageBox.Show("Please enter title and choose category");
            }
            else if (this.TxtTitle.Text == "Title" || this.TxtTitle.Text == "")
            {
                MessageBox.Show("Please enter title");
            }
            else if (this.CheckedHabit.Visible == false && this.CheckedSpec.Visible == false
                && this.CheckedWork.Visible == false)
            {
                MessageBox.Show("Please choose category");
            }
            else
            {
                if (this.CheckedHabit.Visible == true)
                {
                    this.Management.CreateHabit(date, title, detail, prio, sta);
                    MessageBox.Show("Create successfuly");
                    this.Close();
                }
                else if (this.CheckedSpec.Visible == true)
                {
                    this.Management.CreateSpecEvent(date, title,location, start, end, detail, sta, false);
                    MessageBox.Show("Create successfuly");
                    this.Close();
                }
                else if (this.CheckedWork.Visible == true)
                {
                    this.Management.CreateTask(date, title, detail, sta, false);
                    MessageBox.Show("Create successfuly");
                    this.Close();
                }
            }
        }

        void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.TxtTitle.Text = "Title";
                this.txtStart.Text = "9:00 AM";
                this.txtEnd.Text = "9:00 PM";
                this.TxtLocation.Text = "Location";
                this.TxtDetails.Text = "Details";
                this.DTPDate.Value = DateTime.Now;
                this.UncheckHabit.Visible = true;
                this.UncheckPrio.Visible = true;
                this.UncheckSpec.Visible = true;
                this.UncheckWork.Visible = true;
                this.CheckedHabit.Visible = false;
                this.CheckedPrio.Visible = false;
                this.CheckedSpec.Visible = false;
                this.CheckedWork.Visible = false;
            }
        }

        void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                AddForm.ActiveForm.Close();
            }
        }
        //*
    }
}
