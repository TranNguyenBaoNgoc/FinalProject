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
    public partial class Habit_Item : UserControl
    {
        private LogicLayer Management;
        private int ID;
        public Habit_Item(int id)
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.ID = id;
            this.ChBUnchecked.Click += ChBUnchecked_Click;
            this.ChBChecked.Click += ChBChecked_Click;
            this.BtnDelete.Click += BtnDelete_Click;
            this.BtnEdit.Click += BtnEdit_Click;
            this.BtnSave.Click += BtnSave_Click;
            this.UncheckedPrioIcon.Click += UncheckedPrioIcon_Click;
            this.CheckedPrioIcon.Click += CheckedPrioIcon_Click;
            this.Load += Habit_Item_Load;
        }

        void CheckedPrioIcon_Click(object sender, EventArgs e)
        {
            this.CheckedPrioIcon.Visible = false;
            this.UncheckedPrioIcon.Visible = true;
            var prio = false;
            this.Management.EditPrioHabit(Int32.Parse(this.LblId.Text), prio);
        }

        void UncheckedPrioIcon_Click(object sender, EventArgs e)
        {
            this.UncheckedPrioIcon.Visible = false;
            this.CheckedPrioIcon.Visible = true;
            var prio = true;
            this.Management.EditPrioHabit(Int32.Parse(this.LblId.Text), prio);
        }

        void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text == "")
            {
                MessageBox.Show("Please enter title");
            }
            else
            {
                var title = this.txtTitle.Text;
                var detail = this.txtDetails.Text;
                this.Management.EditHabit(Int32.Parse(this.LblId.Text), title, detail);
                MessageBox.Show("Edit successfuly");
                this.ChBChecked.Visible = false;
                this.ChBUnchecked.Visible = true;
                this.BtnEdit.Visible = true;
                this.BtnSave.Visible = false;
                this.txtTitle.ReadOnly = true;
                this.txtDetails.ReadOnly = true;
            }
        }

        void BtnEdit_Click(object sender, EventArgs e)
        {
            this.txtTitle.ReadOnly = false;
            this.txtDetails.ReadOnly = false;
            this.ChBChecked.Visible = false;
            this.ChBUnchecked.Visible = false;
            this.BtnEdit.Visible = false;
            this.BtnSave.Visible = true;
        }

        void Habit_Item_Load(object sender, EventArgs e)
        {
            var habit = this.Management.GetHabit(ID);
            this.LblId.Text = habit.Id.ToString();
            this.txtTitle.Text = habit.Title;
            this.txtDetails.Text = habit.Details;
            if (habit.Prio == false)
            {
                this.UncheckedPrioIcon.Visible = true;
                this.CheckedPrioIcon.Visible = false;
            }
            else
            {
                this.UncheckedPrioIcon.Visible = false;
                this.CheckedPrioIcon.Visible = true;
            }
            if (habit.Status == false)
            {
                this.ChBChecked.Visible = false;
                this.ChBUnchecked.Visible = true;
            }
            else
            {
                this.ChBChecked.Visible = true;
                this.ChBUnchecked.Visible = false;
            }
            if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 && DateTime.Now.Millisecond == 0)
            {
                this.ChBChecked.Visible = false;
                this.ChBUnchecked.Visible = true;
            }
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Management.DeleteHabit(Int32.Parse(this.LblId.Text));
                MessageBox.Show("Delete successfuly");
                this.Hide();
            }
        }

        void ChBChecked_Click(object sender, EventArgs e)
        {
            this.ChBChecked.Visible = false;
            this.ChBUnchecked.Visible = true;
            var sta = false;
            this.Management.EditStaHabit(Int32.Parse(this.LblId.Text), sta);

        }

        void ChBUnchecked_Click(object sender, EventArgs e)
        {
            this.ChBUnchecked.Visible = false;
            this.ChBChecked.Visible = true;
            var sta = true;
            this.Management.EditStaHabit(Int32.Parse(this.LblId.Text), sta);
        }
    }
}