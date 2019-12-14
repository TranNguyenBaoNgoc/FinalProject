using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using Display;

namespace Display
{
    public partial class StatisticWork : UserControl
    {
        public StatisticWork()
        {
            InitializeComponent();
            this.BtnWork.Click += btnWork_Click;
            this.BtnHabit.Click += btnHabit_Click;
            this.BtnShow.Click += btnShow_Click;
            this.Mc1.DateSelected += monthCalendar1_DateSelected;
        }

        void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            this.C1.Series["Your Productivity"].Points.AddXY("MONDAY", 50);
            this.C1.Series["Your Productivity"].Points.AddXY("TUESDAY", 60);
            this.C1.Series["Your Productivity"].Points.AddXY("WEDNESDAY", 20);
            this.C1.Series["Your Productivity"].Points.AddXY("THURSDAY", 10);
            this.C1.Series["Your Productivity"].Points.AddXY("FRIDAY", 30);
            this.C1.Series["Your Productivity"].Points.AddXY("SATURDAY", 80);
            this.C1.Series["Your Productivity"].Points.AddXY("SUNDAY", 100);
        }

        void btnHabit_Click(object sender, EventArgs e)
        {
            var H = new StatisticHabit();
            this.Hide();
            this.Parent.Controls.Add(H);
        }

        void btnWork_Click(object sender, EventArgs e)
        {
        }
    }
}