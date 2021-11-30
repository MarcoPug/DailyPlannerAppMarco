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
    public partial class TaskHistory : Form
    {
        BindingSource bs = new BindingSource();
        public TaskHistory()
        {
            InitializeComponent();
            bs.DataSource = itemsList.toDoItemsDeleted;
            lbTaskList.DataSource = bs;
            lbTaskList.DisplayMember = "title";

            ManuallyClear();

            setColors();


        }

        private void setColors()
        {
            btnClear.BackColor = ControlPaint.Light(Items.itemToDo.color);
            btnClear.FillColor = Items.itemToDo.color;
            btnClear.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            btnDelete.BackColor = ControlPaint.Light(Items.itemToDo.color);
            btnDelete.FillColor = Items.itemToDo.color;
            btnDelete.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            btnDetails.BackColor = ControlPaint.Light(Items.itemToDo.color);
            btnDetails.FillColor = Items.itemToDo.color;
            btnDetails.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            btnRestore.BackColor = ControlPaint.Light(Items.itemToDo.color);
            btnRestore.FillColor = Items.itemToDo.color;
            btnRestore.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            //shape.FillColor = ControlPaint.Light(Items.itemToDo.color);
            //shape.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            this.BackColor = ControlPaint.Light(Items.itemToDo.color);

            shape2.BackColor = ControlPaint.Light(Items.itemToDo.color);
            shape2.FillColor = Items.itemToDo.color;
            shape2.BorderColor = ControlPaint.Dark(Items.itemToDo.color);
        }

        private void ManuallyClear()
        {


                for (int i = 0; i < itemsList.toDoItemsDeleted.Count; i++)
                {
                
                    
                    DateTime rValue;
                    rValue = Form1.theCurrentDT();


                    DateTime lValue = itemsList.toDoItemsDeleted[i].dateRecycled;
                    TimeSpan answer = lValue.Date - rValue.Date;
                    if (answer.TotalDays <= -30) //over 30 days
                        itemsList.toDoItemsDeleted.RemoveAt(i);
                }



        }


        private void TaskHistory_Click(object sender, EventArgs e)
        {
            lbTaskList.ClearSelected();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(lbTaskList.SelectedIndex == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Permanently Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    itemsList.toDoItemsDeleted.Remove((itemToDo)lbTaskList.SelectedItem);
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
            if (!(lbTaskList.SelectedIndex == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Restore this Item?", "Restore Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ((itemToDo)lbTaskList.SelectedItem).isRecycled = false;
                    itemsList.toDoItems.Add((itemToDo)lbTaskList.SelectedItem);
                    itemsList.toDoItemsDeleted.Remove((itemToDo)lbTaskList.SelectedItem);
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
            if (itemsList.toDoItemsDeleted.Any())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete every item?", "Permanently Delete Items", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    itemsList.toDoItemsDeleted.Clear();
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
            if (!(lbTaskList.SelectedIndex == -1))
                MessageBox.Show(itemsList.toDoItemsDeleted[lbTaskList.SelectedIndex].ToString());
        }
    }
}
