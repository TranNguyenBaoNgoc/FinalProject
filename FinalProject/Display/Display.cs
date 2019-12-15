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
    public partial class Display : Form
    {
        private LogicLayer Management;
        private int posX;
        private int posY;
        private bool drag;
        public Display()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            //day
            this.BtnDay.Click += BtnDay_Click;
            //month
            this.BtnMonth.Click += BtnMonth_Click;
            //Special
            this.BtnSpecial.Click += BtnSpecial_Click;
            //statistic
            this.BtnStatis.Click += BtnStatis_Click;
            //habit
            this.BtnHabit.Click += BtnHabit_Click;
            //control
            this.BtnHome.Click += BtnHome_Click;
            this.BtnAdd.Click += BtnAdd_Click;
            this.Load += Display_Load;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.PnlTilteBar.MouseDown += PnlTilteBar_MouseDown;
            this.PnlTilteBar.MouseMove += PnlTilteBar_MouseMove;
            this.PnlTilteBar.MouseUp += PnlTilteBar_MouseUp;
            this.BtnExit.Click += BtnExit_Click;
            this.BtnMinimize.Click += BtnMinimize_Click;
        }

        void PnlTilteBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
                this.Opacity = 1;
            }
        }

        void PnlTilteBar_MouseMove(object sender, MouseEventArgs e)
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

        void PnlTilteBar_MouseDown(object sender, MouseEventArgs e)
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

        void Display_Load(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Add(new Home());
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            var add = new AddForm();
            add.ShowDialog();
        }

        void BtnHome_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new Home());
        }

        void BtnHabit_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new Habit());
        }

        void BtnStatis_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new StatisticWork());
        }

        void BtnSpecial_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new SpecialEvent());
        }

        void BtnMonth_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new MonthView());
        }

        void BtnDay_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new Day());
        }

        void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Display.ActiveForm.Close();
            }
        }
    }
}
