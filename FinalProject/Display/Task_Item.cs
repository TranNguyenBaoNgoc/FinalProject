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
        private int ID;
        public Task_Item(int id)
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
            this.Load += Task_Item_Load;
        }

        void CheckedPrioIcon_Click(object sender, EventArgs e)
        {
            this.CheckedPrioIcon.Visible = false;
            this.UncheckedPrioIcon.Visible = true;
            var prio = false;
            this.Management.EditPrioTask(Int32.Parse(this.LblId.Text), prio);
        }

        void UncheckedPrioIcon_Click(object sender, EventArgs e)
        {
            this.UncheckedPrioIcon.Visible = false;
            this.CheckedPrioIcon.Visible = true;
            var prio = true;
            this.Management.EditPrioTask(Int32.Parse(this.LblId.Text), prio);
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
                this.Management.EditTask(Int32.Parse(this.LblId.Text), title, detail);
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

        void Task_Item_Load(object sender, EventArgs e)
        {
            var work = this.Management.GetTask(ID);
            this.LblId.Text = work.Id.ToString();
            this.txtTitle.Text = work.Title;
            this.txtDetails.Text = work.Details;
            if (work.Prio == false)
            {
                this.UncheckedPrioIcon.Visible = true;
                this.CheckedPrioIcon.Visible = false;
            }
            else
            {
                this.UncheckedPrioIcon.Visible = false;
                this.CheckedPrioIcon.Visible = true;
            }
            if (work.Status == false)
            {
                this.ChBChecked.Visible = false;
                this.ChBUnchecked.Visible = true;
            }
            else
            {
                this.ChBChecked.Visible = true;
                this.ChBUnchecked.Visible = false;
            }
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Management.DeleteTask(Int32.Parse(this.LblId.Text));
                MessageBox.Show("Delete successfuly");
                this.Hide();
            }
        }

        void ChBChecked_Click(object sender, EventArgs e)
        {
            this.ChBChecked.Visible = false;
            this.ChBUnchecked.Visible = true;
            var sta = false;
            this.Management.EditStaTask(Int32.Parse(this.LblId.Text), sta);

        }

        void ChBUnchecked_Click(object sender, EventArgs e)
        {
            this.ChBUnchecked.Visible = false;
            this.ChBChecked.Visible = true;
            var sta = true;
            this.Management.EditStaTask(Int32.Parse(this.LblId.Text), sta);
        }
    }
}