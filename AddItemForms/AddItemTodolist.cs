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

namespace DailyPlannerAppMarco.AddItemForms
{
    public partial class AddItemTodolist : Form
    {
        public AddItemTodolist()
        {
            InitializeComponent();

            txtDays.Visible = false;
            label5.Visible = false;
            cbTimeDays.Visible = false;
            cbAMPM.Visible = false;

            

            var DistinctItems = itemsList.toDoItems.GroupBy(x => x.group).Select(y => y.First());
            foreach (var item in DistinctItems)
            {
                if (item.group != "")
                    cGroup.Items.Add(item.group);
            }



        }
        int listIndex = 0;
        bool editing = false;

        public AddItemTodolist(int x)//is editing
        {
            InitializeComponent();
            listIndex = x;
            editing = true;
            txtDays.Visible = false;
            label5.Visible = false;
            cbTimeDays.Visible = false;
            cbAMPM.Visible = false;
            btnAdd.Text = "Done";


            var DistinctItems = itemsList.toDoItems.GroupBy(xx => xx.group).Select(yy => yy.First());
            foreach (var item in DistinctItems)
            {
                if (item.group != "")
                    cGroup.Items.Add(item.group);
            }

            //MessageBox.Show(itemsList.toDoItems[listIndex].getDueDate());

            txtName.Text = itemsList.toDoItems[listIndex].title;
            cGroup.Text = itemsList.toDoItems[listIndex].group;
            txtDesc.Text = itemsList.toDoItems[listIndex].description;
            //txtName.ReadOnly = true;


            if (itemsList.toDoItems[listIndex].important)
                cbImportant.Checked = true;
            if (itemsList.toDoItems[listIndex].repetitive)
            {
                cbRepeating.Checked = true;
                txtDays.Visible = true;
                label5.Visible = true;
                txtDays.Text = itemsList.toDoItems[listIndex].repeatDays.ToString();
            }
            if (itemsList.toDoItems[listIndex].hasDueDate)
            {
                cbTime.Checked = true;
                cbTimeDays.Visible = true;
                cbAMPM.Visible = true;

                if (itemsList.toDoItems[listIndex].getDueDate().Contains("1:"))
                    cbTimeDays.SelectedIndex = 0;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("2:"))
                    cbTimeDays.SelectedIndex = 1;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("3:"))
                    cbTimeDays.SelectedIndex = 2;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("4:"))
                    cbTimeDays.SelectedIndex = 3;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("5:"))
                    cbTimeDays.SelectedIndex = 4;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("6:"))
                    cbTimeDays.SelectedIndex = 5;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("7:"))
                    cbTimeDays.SelectedIndex = 6;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("8:"))
                    cbTimeDays.SelectedIndex = 7;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("9:"))
                    cbTimeDays.SelectedIndex = 8;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("10:"))
                    cbTimeDays.SelectedIndex = 9;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("11:"))
                    cbTimeDays.SelectedIndex = 10;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("12:"))
                    cbTimeDays.SelectedIndex = 11;

                if (itemsList.toDoItems[listIndex].getDueDate().Contains("AM"))
                    cbAMPM.SelectedIndex = 0;
                if (itemsList.toDoItems[listIndex].getDueDate().Contains("PM"))
                    cbAMPM.SelectedIndex = 1;


            }

        }

        private void tryAddItem()
        {
            

            int test = 0;
            bool success = Int32.TryParse(txtDays.Text, out test);
            //MessageBox.Show(test + ": <-- tryparse");
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a valid name");

            }
            else if (cbRepeating.Checked && (!success || test == 0))
            {
                MessageBox.Show("Please enter a valid number for Days");
            }
            else if (cbTime.Checked && (cbTimeDays.SelectedItem == null || cbAMPM.SelectedItem == null))
            {
                MessageBox.Show("Please dont leave information blank");

            }
            else if (test > 7)
            {
                MessageBox.Show("Please have your task fit in a weekly schedule");

            }
            else if(editing == false)
            {
                itemToDo item = new itemToDo();
                

                //var dateNow = DateTime.Now;
                DateTime date;

                int index = cbTimeDays.SelectedIndex;

                int pm = cbAMPM.SelectedIndex;

                if (pm == 1)
                {
                    index = index + 12;
                }
                if (index == 11 || index == 23 )
                {
                    index = index - 12;
                    //MessageBox.Show("IN 12 IF STATEMENT, INDEX: " + index);
                }
                //MessageBox.Show("index: "+ index);

                //date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, index+1, 0, 0);
                date = new DateTime(Form1.theCurrentDT().Year, Form1.theCurrentDT().Month, Form1.theCurrentDT().Day, index + 1, 0, 0);

                item.title = txtName.Text;
                item.description = txtDesc.Text;
                item.important = cbImportant.Checked;
                item.repetitive = cbRepeating.Checked;
                item.repeatDays = test;
                item.hasDueDate = cbTime.Checked;
                item.dueDate = date;

                item.group = cGroup.Text;




                itemsList.toDoItems.Add(item);
                //MessageBox.Show("Due Date: " + item.getDueDate());
                //MessageBox.Show("Name: " + item.title);
                //MessageBox.Show("important: " + item.important);
                //MessageBox.Show("repetitve: " + item.repeatDays);
                //MessageBox.Show("Desc: " + item.description);
                //MessageBox.Show("ID: "   + item.MyId);
                this.Close();
            }
            else if(editing == true)
            {
             
                //var dateNow = DateTime.Now;
                DateTime date;

                int index = cbTimeDays.SelectedIndex;

                int pm = cbAMPM.SelectedIndex;

                if (pm == 1)
                {
                    index = index + 12;
                }
                if (index == 11 || index == 23)
                {
                    index = index - 12;
                    //MessageBox.Show("IN 12 IF STATEMENT, INDEX: " + index);
                }
                //MessageBox.Show("index: "+ index);

                //date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, index+1, 0, 0);
                date = new DateTime(Form1.theCurrentDT().Year, Form1.theCurrentDT().Month, Form1.theCurrentDT().Day, index + 1, 0, 0);

                itemsList.toDoItems[listIndex].title = txtName.Text;
                itemsList.toDoItems[listIndex].important = cbImportant.Checked;
                itemsList.toDoItems[listIndex].repetitive = cbRepeating.Checked;
                itemsList.toDoItems[listIndex].repeatDays = test;
                itemsList.toDoItems[listIndex].hasDueDate = cbTime.Checked;
                itemsList.toDoItems[listIndex].dueDate = date;
                itemsList.toDoItems[listIndex].description = txtDesc.Text;
                itemsList.toDoItems[listIndex].group = cGroup.Text;

                this.Close();
            }


        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
            {
                cbTimeDays.Visible = true;
                cbAMPM.Visible = true;
            }
            else
            {
                cbTimeDays.Visible = false;
                cbAMPM.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRepeating.Checked)
            {
                txtDays.Visible = true;
                label5.Visible = true;
            }
            else
            {
                txtDays.Visible = false;
                label5.Visible = false;
            }
        }

        private void cbImportant_CheckedChanged(object sender, EventArgs e)
        {
            if (cbImportant.Checked)
            {
                importantNotif.Visible = true;
            }
            else
            {
                importantNotif.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tryAddItem();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid number for Time");
                throw ex;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddItemTodolist_Load(object sender, EventArgs e)
        {
            btnAdd.FillColor = Items.itemToDo.color;
            this.BackColor = ControlPaint.Light(Items.itemToDo.color);

        }
    }
}
