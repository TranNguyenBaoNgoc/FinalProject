using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;

namespace Display
{
    public partial class MonthView : UserControl
    {
        private LogicLayer Management;
        public MonthView()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            calendar1.CalendarDate = new DateTime(2019, 12, 17, 0, 0, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = false;
            foreach (Task t in Management.GetTasks())
            {
                var tasks = new CustomEvent
                {
                    Date = t.DateTime,
                    EventText = t.Title,
                    EventTextColor = Color.Blue,
                    EventColor = Color.White,
                    TooltipEnabled = true
                };

                calendar1.AddEvent(tasks);
            }

            foreach (SpecEvent s in this.Management.GetSpecEvents())
            {
                var SpecialEvents = new CustomEvent
                {
                    Date = s.DateTime,
                    EventText = s.Title,
                    EventTextColor = Color.Orange,
                    EventColor = Color.White
                };

                calendar1.AddEvent(SpecialEvents);
            }
        }
    }
}
