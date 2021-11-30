﻿using DailyPlannerAppMarco.AddItemForms;
using DailyPlannerAppMarco.HistoryForms;
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

namespace DailyPlannerAppMarco.UserControls
{
    public partial class UC_ToDoList : UserControl
    {
        BindingSource bs = new BindingSource();

        
        readonly MongoCRUD db;
        public UC_ToDoList()
        {
            InitializeComponent();
            setBind();
            //listBox.DisplayMember = "title";

            db = new MongoCRUD(Form1.dbName);


            addColor();

            //setTasks();
            

        }

        private void setBind()
        {
            bs.DataSource = itemsList.toDoItems;
            listBox.DataSource = bs;


            cGroup.SelectedIndex = -1;
            //cGroup.SelectionLength = 0;
            //cGroup.Text = "Filter";

        }


        private void addColor()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Items.itemToDo.color;


            btnDown.FillColor = Items.itemToDo.color;
            btnUp.FillColor = Items.itemToDo.color;

            btnUp.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            btnHistory.FillColor = Items.itemToDo.color;

            btnEdit.FillColor = Items.itemToDo.color;

            //listBox.ForeColor = Items.itemToDo.color;
            cGroup.BorderColor = ControlPaint.Light(Items.itemToDo.color);

        }

       

        int selectedIndex;

        public void MoveItem( ListBox listBox, int direction)
        {
            setBind();


            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return; 

            int newIndex = listBox.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return; 

            bool isBindingSource = listBox.DataSource is BindingSource;

            System.Collections.IList list = isBindingSource ? ((BindingSource)listBox.DataSource).List : listBox.Items;

            object selected = listBox.SelectedItem;

            list.Remove(selected);

            list.Insert(newIndex, selected);

            listBox.SetSelected(newIndex, true);

            if (isBindingSource)
            {
                ((BindingSource)listBox.DataSource).ResetBindings(false);
            }

            

        }

        private void UC_ToDoList_Load(object sender, EventArgs e)
        {


            
            bs.ResetBindings(false);
            setChecked();

            addFilter();
        }

        private void setChecked()
        {
            listBox.ClearSelected();
            for (int i = 0; i < itemsList.toDoItems.Count; i++)
            {
                
                if (itemsList.toDoItems[i].isChecked)
                {
                    //MessageBox.Show(itemsList.toDoItems[i].title + "  set to true?: " + itemsList.toDoItems[i].isChecked);
                    

                    for (int x = 0; x < listBox.Items.Count; x++)
                    {
                        if (listBox.Items[x].ToString() == itemsList.toDoItems[i].ToString())
                        {
                            //MessageBox.Show(itemsList.toDoItems[i].title + "  which is also: " + listBox.Items[x].ToString() + "\nbeing set to: " + itemsList.toDoItems[i].isChecked);
                            listBox.SetItemChecked(x, itemsList.toDoItems[i].isChecked);
                        }

                    }
                }
            }
        }

        private void listBox_Leave(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox.Items.Count; ++i)
            {
                if (listBox.GetItemChecked(i))
                {
                    itemsList.toDoItems[i].isChecked = true;
                }
                else
                {
                    itemsList.toDoItems[i].isChecked = false;
                    //MessageBox.Show("unchecked at position " + i as string);
                }
                //MessageBox.Show(itemsList.toDoItems[i].MyId + ""); //count all ids
            }
        }


        private void UC_ToDoList_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
        }

        static bool addRecc = true;
        private void addDefaultTasks()
        {


            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);
            if (!currRecord.appInfo.leftBefore && addRecc)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to add reccomended tasks?", "Add Tasks", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    itemToDo breakfast = new itemToDo();
                    breakfast.title = "eat Breakfast";
                    breakfast.description = "eat a nice breakfast";
                    breakfast.important = true;
                    breakfast.repetitive = true;
                    breakfast.repeatDays = 1;
                    breakfast.hasDueDate = true;
                    breakfast.dueDate = new DateTime(Form1.theCurrentDT().Year, Form1.theCurrentDT().Month, Form1.theCurrentDT().Day, 6, 0, 0);
                    breakfast.group = "meals";
                    itemsList.toDoItems.Add(breakfast);

                    itemToDo lunch = new itemToDo();
                    lunch.title = "eat Lunch";
                    lunch.description = "eat a nice lunch";
                    lunch.important = true;
                    lunch.repetitive = true;
                    lunch.repeatDays = 1;
                    lunch.hasDueDate = true;
                    lunch.dueDate = new DateTime(Form1.theCurrentDT().Year, Form1.theCurrentDT().Month, Form1.theCurrentDT().Day, 12, 0, 0);
                    lunch.group = "meals";
                    itemsList.toDoItems.Add(lunch);

                    itemToDo dinner = new itemToDo();
                    dinner.title = "eat Dinner";
                    dinner.description = "eat a nice dinner";
                    dinner.important = true;
                    dinner.repetitive = true;
                    dinner.repeatDays = 1;
                    dinner.hasDueDate = true;
                    dinner.dueDate = new DateTime(Form1.theCurrentDT().Year, Form1.theCurrentDT().Month, Form1.theCurrentDT().Day, 18, 0, 0);
                    dinner.group = "meals";
                    itemsList.toDoItems.Add(dinner);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            addRecc = false;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox.SelectedIndex;

            if (selectedIndex + 1 != listBox.Items.Count)
            {


                selectedIndex++;

                MoveItem(listBox, 1);

                setChecked();

                listBox.SetSelected(selectedIndex, true);
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox.SelectedIndex;

            if (selectedIndex - 1 != -1 && selectedIndex != -1)
            {
                selectedIndex--;

                MoveItem(listBox, -1);

                setChecked();

                listBox.SetSelected(selectedIndex, true);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            TaskHistory historyform = new TaskHistory();
            historyform.ShowDialog();
            bs.ResetBindings(false);
            setChecked();

            setBind();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (!(listBox.SelectedIndex == -1))
                MessageBox.Show(itemsList.toDoItems[listBox.SelectedIndex].ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(listBox.SelectedIndex == -1))
            {
                AddItemTodolist formadd = new AddItemTodolist(listBox.SelectedIndex);
                formadd.ShowDialog();
                bs.ResetBindings(false);
            }
            setChecked();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addDefaultTasks();
            setBind();

            AddItemTodolist formadd = new AddItemTodolist();
            formadd.ShowDialog();
            bs.ResetBindings(false);
            setChecked();



            addFilter();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setBind();
            if (listBox.SelectedIndex != -1)
            {
                ((itemToDo)listBox.SelectedItem).dateRecycled = Form1.theCurrentDT();


                ((itemToDo)listBox.SelectedItem).isRecycled = true;
                itemsList.toDoItemsDeleted.Add((itemToDo)listBox.SelectedItem);
                itemsList.toDoItems.Remove((itemToDo)listBox.SelectedItem);
                bs.ResetBindings(false);
            }
        }

        private void addFilter()
        {
            cGroup.Items.Clear();
            var DistinctItems = itemsList.toDoItems.GroupBy(xx => xx.group).Select(yy => yy.First());
            foreach (var item in DistinctItems)
            {
                if (item.group != "")
                    cGroup.Items.Add(item.group);
            }
        }

        BindingList<itemToDo> myObjList = new BindingList<itemToDo>();

        private void cGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            myObjList.Clear();

            foreach (var item in itemsList.toDoItems)
                myObjList.Add(item);
            //cb.SelectedItem
            string group = (string)cGroup.SelectedItem;
            if (cGroup.SelectedIndex == -1) //if no group is selected and pressed filter
            {

            }
            else //if a group is selected and pressed filter
            {
                BindingList<itemToDo> filtered = new BindingList<itemToDo>(myObjList.Where(objj => objj.group == group).ToList());
                bs.DataSource = myObjList;
                listBox.DataSource = myObjList;
                listBox.DataSource = filtered;
                listBox.DisplayMember = "title";
                listBox.Update();
            }
            listBox.ClearSelected();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            setBind();
        }
    }
}