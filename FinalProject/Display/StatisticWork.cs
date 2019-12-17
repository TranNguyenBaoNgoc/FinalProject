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
        private LogicLayer Management;

        public StatisticWork()
        {
            InitializeComponent();
            this.Mc1.DateSelected += monthCalendar1_DateSelected;
            this.Management = new LogicLayer();
        }


        void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var Date = this.Mc1.SelectionRange.Start.ToString("dd-MM-yyyy");
            double count1 = 0;
            foreach (Task t in this.Management.GetTasks())
            {
                if (t.DateTime.ToString("dd-MM-yyyy") == Date)
                {
                    count1++;
                }
            }

            double count2 = 0;
            foreach (Task t in this.Management.GetTasks())
            {
                if (t.DateTime.ToString("dd-MM-yyyy") == Date)
                {
                    if (t.Status == true)
                    {
                        count2++;
                    }
                }
            }
            double Productivity = count2 / count1 * 100;
            C1.Series["Your Productivity"].Points.AddXY(Date, Productivity);
        }
    }
}