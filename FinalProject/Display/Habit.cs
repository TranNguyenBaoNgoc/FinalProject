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
            this.PnlList.Click += PnlList_Click;
            this.Load += Habit_Load;
        }

        void PnlList_Click(object sender, EventArgs e)
        {
            PnlList.Controls.Clear();
            AddItem();
        }

        public void AddItem()
        {
            Point Point = new Point(0, 0);
            foreach (Routine t in this.Management.GetHabits())
            {
                var item = new Habit_Item(t.Id);
                item.Location = new Point(0, PnlList.AutoScrollPosition.Y + Point.Y);
                Point.Y += item.Size.Height;
                PnlList.Controls.Add(item);
            }
        }

        void Habit_Load(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}