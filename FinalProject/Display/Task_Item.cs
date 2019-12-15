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
    public partial class Task_Item : UserControl
    {
        private LogicLayer Management;
        public Task_Item()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.ChBUnchecked.Click += ChBUnchecked_Click;
            this.ChBChecked.Click += ChBChecked_Click;
            this.BtnDelete.Click += BtnDelete_Click;
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        void ChBChecked_Click(object sender, EventArgs e)
        {
            this.ChBChecked.Visible = false;
            this.ChBUnchecked.Visible = true;
        }

        void ChBUnchecked_Click(object sender, EventArgs e)
        {
            this.ChBUnchecked.Visible = false;
            this.ChBChecked.Visible = true;
        }
    }
}
