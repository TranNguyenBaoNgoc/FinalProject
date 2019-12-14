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
        Timer t = new Timer();
        int sec = DateTime.Now.Second;
        public Display()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.BtnExit.Click += BtnExit_Click;
            this.BtnMinimize.Click += BtnMinimize_Click;
            this.BtnDay.Click += BtnDay_Click;
            this.PnlDay.Click += BtnDay_Click;
            this.BtnMonth.Click += BtnMonth_Click;
            this.PnlMonth.Click += BtnMonth_Click;
            this.BtnSpecial.Click += BtnSpecial_Click;
            this.PnlSpecial.Click += BtnSpecial_Click;
            this.BtnStatis.Click += BtnStatis_Click;
            this.PnlStatic.Click += BtnStatis_Click;
            this.BtnHabit.Click += BtnHabit_Click;
            this.PnlHabit.Click += BtnHabit_Click;
            this.BtnHome.Click += BtnHome_Click;
            this.BtnAdd.Click += BtnAdd_Click;
            this.Load += Display_Load;
            this.LblStatis.Click += LblStatis_Click;
            this.StatisIcon.Click += StatisIcon_Click;
            this.LblMonth.Click += LblMonth_Click;
            this.MonthIcon.Click += MonthIcon_Click;
        }

        void MonthIcon_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new MonthView());
        }

        void LblMonth_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new MonthView());
        }

        void StatisIcon_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new StatisticWork());
        }

        void LblStatis_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new StatisticWork());
        }

        void Display_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            this.BarSec1.Width = (this.Width + sec) / 60;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            this.LblMonthYear.Text = Management.GetMonthYear();
            this.LblDate.Text = Management.GetDay();
            this.LblHour.Text = Management.GetHour();
            this.LblMinute.Text = Management.GetMinute();
            if (sec == 0)
            {
                this.BarSec1.Width = 0;
            }
            else
                this.BarSec1.Width += (this.Width+sec)/60;
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(new Add());
        }

        void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var D = new Display();
            D.Closed += (s, args) => this.Close(); 
            D.Show();
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
            Display.ActiveForm.Close();
        }
    }
}
