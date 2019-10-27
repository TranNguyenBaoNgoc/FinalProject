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
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Display.ActiveForm.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpecialBtn_Click_1(object sender, EventArgs e)
        {
            Funtion.Controls.Clear();
            Funtion.Controls.Add(new SpecialEvent());
        }

        private void DayBtn_Click_1(object sender, EventArgs e)
        {
            Funtion.Controls.Clear();
            Funtion.Controls.Add(new Day());
        }

        private void HabitBtn_Click_1(object sender, EventArgs e)
        {
            Funtion.Controls.Clear();
            Funtion.Controls.Add(new SpecialEvent());
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            MainF.Controls.Clear();
            MainF.Controls.Add(new Add());
        }
    }
}
