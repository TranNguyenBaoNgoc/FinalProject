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
    public partial class SpecialEvent : UserControl
    {
        int i = 1;
        int j = 1;
        private LogicLayer Management;
        public SpecialEvent()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.BtnNext.Click += BtnNext_Click;
            this.BtnPre.Click += BtnPre_Click;
            this.Load += Day_Load;
        }

        void Day_Load(object sender, EventArgs e)
        {
            this.LblMonthYear.Text = DateTime.Now.ToString("MMMM yyyy,\ndddd");
            this.LblDay.Text = DateTime.Now.ToString("dd");
            var T = new Task_Item();
            PnlList.Controls.Add(T);
        }

        void BtnPre_Click(object sender, EventArgs e)
        {
            this.LblDay.Text = DateTime.Now.AddDays(--i).ToString("dd");
            this.LblMonthYear.Text = DateTime.Now.AddDays(--j).ToString("MMMM yyyy,\ndddd");
        }

        void BtnNext_Click(object sender, EventArgs e)
        {
            this.LblDay.Text = DateTime.Now.AddDays(i++).ToString("dd");
            this.LblMonthYear.Text = DateTime.Now.AddDays(j++).ToString("MMMM yyyy,\ndddd");
        }
    }
}
