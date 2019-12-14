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
    public partial class StatisticHabit : UserControl
    {
        public StatisticHabit()
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
        }

        void btnHabit_Click(object sender, EventArgs e)
        {
        }

        void btnWork_Click(object sender, EventArgs e)
        {
            var W = new StatisticWork();
            this.Hide();
            this.Parent.Controls.Add(W);
        }
    }
}
