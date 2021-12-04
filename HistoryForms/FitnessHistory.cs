using DailyPlannerAppMarco.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlannerAppMarco.HistoryForms
{
    public partial class FitnessHistory : Form
    {
        BindingSource bs = new BindingSource();
        public FitnessHistory()
        {
            InitializeComponent();
            bs.DataSource = itemsList.FitnessItemsDeleted;
            lbFitnessList.DataSource = bs;
            lbFitnessList.DisplayMember = "title";

            ManuallyClear();
            setColors();


        }

        private void setColors()
        {
            btnClear.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            btnClear.FillColor = Items.FitnessItem.color;
            btnClear.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            btnDelete.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            btnDelete.FillColor = Items.FitnessItem.color;
            btnDelete.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            btnDetails.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            btnDetails.FillColor = Items.FitnessItem.color;
            btnDetails.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            btnRestore.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            btnRestore.FillColor = Items.FitnessItem.color;
            btnRestore.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);


            this.BackColor = ControlPaint.Light(Items.FitnessItem.color);

            shape2.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            shape2.FillColor = Items.FitnessItem.color;
            shape2.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);
        }

        private void ManuallyClear()
        {


            for (int i = 0; i < itemsList.FitnessItemsDeleted.Count; i++)
            {
                DateTime rValue;
                rValue = Form1.theCurrentDT();

                DateTime lValue = itemsList.FitnessItemsDeleted[i].dateRecycled;
                TimeSpan answer = lValue.Date - rValue.Date;
                if (answer.TotalDays <= -30) //over 30 days
                    itemsList.FitnessItemsDeleted.RemoveAt(i);
            }



        }

        private void FitnessHistory_Click(object sender, EventArgs e)
        {
            lbFitnessList.ClearSelected();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(lbFitnessList.SelectedIndex == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Permanently Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    itemsList.FitnessItemsDeleted.Remove((FitnessItem)lbFitnessList.SelectedItem);
                    bs.ResetBindings(false);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!(lbFitnessList.SelectedIndex == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Restore this Item?", "Restore Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ((FitnessItem)lbFitnessList.SelectedItem).isRecycled = false;
                    itemsList.FitnessItems.Add((FitnessItem)lbFitnessList.SelectedItem);
                    itemsList.FitnessItemsDeleted.Remove((FitnessItem)lbFitnessList.SelectedItem);
                    bs.ResetBindings(false);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (itemsList.FitnessItemsDeleted.Any())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete every item?", "Permanently Delete Items", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    itemsList.FitnessItemsDeleted.Clear();
                    bs.ResetBindings(false);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (!(lbFitnessList.SelectedIndex == -1))
                MessageBox.Show(itemsList.FitnessItemsDeleted[lbFitnessList.SelectedIndex].ToString());
        }
    }
}
