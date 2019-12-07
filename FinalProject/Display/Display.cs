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
        public Display()
        {
            InitializeComponent();
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
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(new Add());
        }

        void BtnHome_Click(object sender, EventArgs e)
        {
            PnlMain.Show();
        }

        void BtnHabit_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new Habit());
        }

        void BtnStatis_Click(object sender, EventArgs e)
        {
            
        }

        void BtnSpecial_Click(object sender, EventArgs e)
        {
            PnlFuntion.Controls.Clear();
            PnlFuntion.Controls.Add(new Listtask());
        }

        void BtnMonth_Click(object sender, EventArgs e)
        {
            
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
