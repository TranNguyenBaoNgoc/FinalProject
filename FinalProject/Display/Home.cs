using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display
{
    public partial class Home : UserControl
    {
        private LogicLayer Management;
        Timer t = new Timer();
        //int sec = DateTime.Now.Second;
        public Home()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.Load += Home_Load;
            //day
            this.PnlDay.Click += PnlDay_Click;
            this.LblDay.Click += PnlDay_Click;
            this.DayIcon.Click += PnlDay_Click;
            //month
            this.PnlMonth.Click += PnlMonth_Click;
            this.LblMonth.Click += PnlMonth_Click;
            this.MonthIcon.Click += PnlMonth_Click;
            //Special
            this.PnlSpecial.Click += PnlSpecial_Click;
            this.LblSpec.Click += PnlSpecial_Click;
            this.SpecIcon.Click += PnlSpecial_Click;
            //statistic
            this.PnlStatic.Click += PnlStatic_Click;
            this.LblStatis.Click += PnlStatic_Click;
            this.StatisIcon.Click += PnlStatic_Click;
            //habit
            this.PnlHabit.Click += PnlHabit_Click;
            this.HabitIcon.Click += PnlHabit_Click;
            this.LblHabit.Click += PnlHabit_Click;
        }

        void Home_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            this.LblMonthYear.Text = DateTime.Now.ToString("MMMM yyyy,\ndddd");
            this.LblDate.Text = DateTime.Now.ToString("dd");
            this.LblHour.Text = Management.GetHour();
            this.LblMinute.Text = Management.GetMinute();
            this.BarSec1.Width = (this.Width/2) * DateTime.Now.Second / 60;
            this.BarSec2.Width = (this.Width/2) * DateTime.Now.Second / 60;
            this.BarSec2.Left = this.Width - BarSec2.Width;
        }

        void PnlDay_Click(object sender, EventArgs e)
        {
            var W = new Day();
            this.Hide();
            this.Parent.Controls.Add(W);
        }

        void PnlHabit_Click(object sender, EventArgs e)
        {
            var W = new Habit();
            this.Hide();
            this.Parent.Controls.Add(W);
        }

        void PnlStatic_Click(object sender, EventArgs e)
        {
            var W = new StatisticWork();
            this.Hide();
            this.Parent.Controls.Add(W);
        }

        void PnlSpecial_Click(object sender, EventArgs e)
        {
            var W = new SpecialEvent();
            this.Hide();
            this.Parent.Controls.Add(W);
        }

        void PnlMonth_Click(object sender, EventArgs e)
        {
            var W = new MonthView();
            this.Hide();
            this.Parent.Controls.Add(W);
        }

    }
}