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
    public partial class Habit : UserControl
    {
        private LogicLayer Management;
        public Habit()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.Load += Habit_Load;
        }

        public void AddItem()
        {
            Point Point = new Point(0, 0);
            foreach (Task t in this.Management.GetTasks())
            {
                if (t.DateTime.ToString("MMMM yyyy,\ndddd") == this.LblMonthYear.Text && t.DateTime.ToString("dd") == this.LblDay.Text)
                {

                    var item = new Task_Item(t.Id);
                    item.Location = new Point(0, PnlList.AutoScrollPosition.Y + Point.Y);
                    Point.Y += item.Size.Height;
                    PnlList.Controls.Add(item);
                }
            }
        }

        void Habit_Load(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}
