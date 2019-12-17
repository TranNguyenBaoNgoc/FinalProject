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
    public partial class Day : UserControl
    {
        int i = 1;
        int j = 1;
        private LogicLayer Management;
        public Day()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.BtnNext.Click += BtnNext_Click;
            this.BtnPre.Click += BtnPre_Click;
            this.Load += Day_Load;
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

        void Day_Load(object sender, EventArgs e)
        {
            this.LblMonthYear.Text = DateTime.Now.ToString("MMMM yyyy,\ndddd");
            this.LblDay.Text = DateTime.Now.ToString("dd");
            AddItem();
        }

        void BtnPre_Click(object sender, EventArgs e)
        {
            this.LblDay.Text = DateTime.Now.AddDays(--i).ToString("dd");
            this.LblMonthYear.Text = DateTime.Now.AddDays(--j).ToString("MMMM yyyy,\ndddd");
            PnlList.Controls.Clear();
            AddItem();
        }

        void BtnNext_Click(object sender, EventArgs e)
        {
            this.LblDay.Text = DateTime.Now.AddDays(i++).ToString("dd");
            this.LblMonthYear.Text = DateTime.Now.AddDays(j++).ToString("MMMM yyyy,\ndddd");
            PnlList.Controls.Clear();
            AddItem();
        }
    }
}
