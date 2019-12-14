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
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
            this.BtnOut.Click += BtnOut_Click;
        }

        void BtnOut_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            var D = new Display();
            D.Show();
            D.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
        }
    }
}
