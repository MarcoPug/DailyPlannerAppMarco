using DailyPlannerAppMarco.AddItemForms;
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
    public partial class UC_Fitness : UserControl 
    {

        public List<CalorieItem> FitnessDailyList = new List<CalorieItem>();

        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();

        BindingList<FitnessItem> myObjList = new BindingList<FitnessItem>();
        public UC_Fitness()
        {
            InitializeComponent();

            setData();


            addColor();
            addFilter();
            setWeekdayText();
        }




        private void addFilter()
        {
            cbFilter.Items.Clear();
            var DistinctItems = itemsList.FitnessItems.GroupBy(xx => xx.group).Select(yy => yy.First());
            foreach (var item in DistinctItems)
            {
                if (item.group != "")
                    cbFilter.Items.Add(item.group);
            }
        }

        private void setData()
        {

            


            foreach (var item in itemsList.FitnessItems)
                myObjList.Add(item);

            bs2.DataSource = myObjList;

            BindingList<FitnessItem> filtered = new BindingList<FitnessItem>(myObjList.Where(obj => obj.isRecycled == false).ToList());


            bs.DataSource = itemsList.FitnessItems;

            listWorkouts.DataSource = bs;

            listWorkouts.DisplayMember = "title";
        }
        private void addColor()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Items.FitnessItem.color;


            btnDown.FillColor = Items.FitnessItem.color;
            btnUp.FillColor = Items.FitnessItem.color;

            btnPrev.FillColor = Items.FitnessItem.color;

            btnUp.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            btnHistory.FillColor = Items.FitnessItem.color;

            btnEdit.FillColor = Items.FitnessItem.color;

            btnAddDay.FillColor = Items.FitnessItem.color;
            btnStart.FillColor = Items.FitnessItem.color;

            btnAddDay.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);
            btnStart.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);


            cbFilter.BorderColor = ControlPaint.Light(Items.FitnessItem.color);

            shapeWeekday.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shapeWeekday.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            tableLayoutPanel1.BackColor = ControlPaint.Light(Items.FitnessItem.color);



        }

        private void UC_Fitness_Load(object sender, EventArgs e)
        {

            dayofWeek.Text = "";
            addFilter();



        }
        public void MoveItem(ListBox listBox, int direction)
        {
            setData();

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

        private void UC_Fitness_Click(object sender, EventArgs e)
        {

            listWorkouts.ClearSelected();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(listWorkouts, -1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(listWorkouts, 1);
        }
        private void setWeekdayText()
        {
            for (int i = 0; i < FitnessItem.workoutDayNames.Length; i++)
            {
                if (FitnessItem.workoutDayNames[i] != null && FitnessItem.workoutDayNames[i] != "Empty")
                {
                    switch (i)
                    {
                        case 0:
                            lblMonName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 1:
                            lblTuesName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 2:
                            lblWedName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 3:
                            lblThurName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 4:
                            lblFriName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 5:
                            lblSatName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        case 6:
                            lblSunName.Text = FitnessItem.workoutDayNames[i];
                            break;
                        default:
                            break;
                    }
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            workoutDayCheck();
            AddFitnessItem formadd = new AddFitnessItem();
            formadd.ShowDialog();
            bs.ResetBindings(false);


            listWorkouts.ClearSelected();
            myObjList.ResetBindings();




            bs2.ResetBindings(false);


            
            addFilter();
            setData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Items.itemsList.FitnessItems.Count >= 1 && listWorkouts.SelectedIndex != -1)
            {

                ((FitnessItem)listWorkouts.SelectedItem).dateRecycled = Form1.theCurrentDT();


                ((FitnessItem)listWorkouts.SelectedItem).isRecycled = true;
                itemsList.FitnessItemsDeleted.Add((FitnessItem)listWorkouts.SelectedItem);
                itemsList.FitnessItems.Remove((FitnessItem)listWorkouts.SelectedItem);
                bs.ResetBindings(false);
            }
            setData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(listWorkouts.SelectedIndex == -1))
            {
                AddFitnessItem formadd = new AddFitnessItem(listWorkouts.SelectedIndex);
                formadd.ShowDialog();
                bs.ResetBindings(false);
            }
            listWorkouts.ClearSelected();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (!(listWorkouts.SelectedIndex == -1))
            {

                MessageBox.Show(itemsList.FitnessItems[listWorkouts.SelectedIndex].ToString());
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FitnessHistory historyform = new FitnessHistory();
            historyform.ShowDialog();
            bs.ResetBindings(false);
            listWorkouts.ClearSelected();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FitnessPrev formadd = new FitnessPrev();
            formadd.ShowDialog();


            bs.ResetBindings(false);



        }

        private bool istodayDeleted()
        {
            for (int i = 0; i < Items.FitnessItem.weekdayNames.Length; i++)
            {
                if (Form1.theCurrentDT().DayOfWeek.ToString() == Items.FitnessItem.weekdayNames[i])
                {
                    if (Items.FitnessItem.workoutDayNames[i] == null || Items.FitnessItem.workoutDayNames[i] == "Empty")
                    {
                        return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!itemsList.FitnessItems.Any())
            {

                MessageBox.Show("You haven't created any workouts");
            }
            else if (istodayDeleted())
            {
                MessageBox.Show("You haven't created any workout days for today");
            }
            else
            {
                bool hasWorkoutToday = false;
                for (int i = 0; i < itemsList.FitnessItems.Count; i++)
                {
                    if (itemsList.FitnessItems[i].dayofweek == Form1.theCurrentDT().DayOfWeek.ToString())
                    {
                        hasWorkoutToday = true;
                        break;
                    }

                }

                if (hasWorkoutToday)
                {
                    StartWorkout startform = new StartWorkout();
                    startform.ShowDialog();
                    bs.ResetBindings(false);
                    listWorkouts.ClearSelected();
                }
                else
                {
                    MessageBox.Show("You haven't created any workouts for today");
                }

            }
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            AddFitnessItem formadd = new AddFitnessItem(true);
            formadd.ShowDialog();
            bs.ResetBindings(false);

            listWorkouts.ClearSelected();

            setWeekdayText();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            myObjList.Clear();


            foreach (var item in itemsList.FitnessItems)
                myObjList.Add(item);
            //cb.SelectedItem
            string group = (string)cbFilter.SelectedItem;
            if (cbFilter.SelectedIndex == -1) //if no group is selected and pressed filter
            {

            }
            else //if a group is selected and pressed filter
            {
                BindingList<FitnessItem> filtered = new BindingList<FitnessItem>(myObjList.Where(objj => objj.group == group).ToList());
                bs.DataSource = myObjList;
                listWorkouts.DataSource = myObjList;
                listWorkouts.DataSource = filtered;
                listWorkouts.DisplayMember = "title";
                listWorkouts.Update();

                dayofWeek.Text = "on " + filtered[0].dayofweek;
            }
            listWorkouts.ClearSelected();

            

        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            bs.DataSource = itemsList.FitnessItems;
            listWorkouts.DataSource = bs;
            dayofWeek.Text = "";

            cbFilter.SelectedIndex = -1;
        }


        private void workoutDayCheck()
        {



            if (lblSunName.Text == "" && lblMonName.Text == "" && lblTuesName.Text == "" &&
                lblWedName.Text == "" && lblThurName.Text == "" && lblFriName.Text == "" && lblSatName.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("No workout days. Add a workout day first?", "Add Workout Day", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddFitnessItem formadd = new AddFitnessItem(true);
                    formadd.ShowDialog();
                    bs.ResetBindings(false);

                    listWorkouts.ClearSelected();

                    setWeekdayText();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }



        }

        private void delWorkoutDay(Label label, int index)
        {

            if (label.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Delete this workout day?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    

                    for (int i = 0; i < itemsList.FitnessItems.Count; i++)
                    {
                        if (itemsList.FitnessItems[i].group == label.Text)
                        {
                            itemsList.FitnessItems[i].group = "Empty";

                        }
                    }

                    FitnessItem.workoutDayNames[index] = "Empty";

                    label.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }

        private void monDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblMonName,0);
            
        }

        private void tuesDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblTuesName, 1);
        }

        private void wedDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblWedName, 2);
        }

        private void thurDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblThurName, 3);
        }

        private void friDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblFriName, 4);
        }

        private void satDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblSatName, 5);
        }

        private void sunDelete_Click(object sender, EventArgs e)
        {
            delWorkoutDay(lblSunName, 6);
        }
    }
}
