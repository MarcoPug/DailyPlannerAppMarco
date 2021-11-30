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
    public partial class UC_Home : UserControl
    {
        int itemsW1, itemsW2, itemsW3, itemsW4, itemsW5, itemsW6, itemsW7 = 0;
        int fitnessW1, fitnessW2, fitnessW3, fitnessW4, fitnessW5, fitnessW6, fitnessW7 = 0;

        private void btnPrev_Click(object sender, EventArgs e)
        {
            HomePrev newform = new HomePrev();
            newform.ShowDialog();
        }

        private void tasksNotDone_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Home_Click(object sender, EventArgs e)
        {
            tasksNotDone.ClearSelected();
        }


        BindingSource bs = new BindingSource();
        BindingList<itemToDo> myObjList = new BindingList<itemToDo>();

        private void tasksNotDone_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (!(tasksNotDone.SelectedIndex == -1))
            {
                if (itemsList.toDoItems[tasksNotDone.SelectedIndex].hasDueDate)
                {
                    MessageBox.Show(itemsList.toDoItems[tasksNotDone.SelectedIndex].title + " Is due today at " +
                    itemsList.toDoItems[tasksNotDone.SelectedIndex].dueDate.ToLongTimeString());
                }
                else
                {
                    MessageBox.Show(itemsList.toDoItems[tasksNotDone.SelectedIndex].title + " Is due today!");
                }

            }

        }


        public UC_Home()
        {
            InitializeComponent();

           

            setTasks();
            setCals();
            setFitness();

            setCalender();

            addColors();


        }

        private void setFitness()
        {

            if (itemsList.FitnessItems.Any())
            {
                if (!StartWorkout.completed)
                {
                    for (int i = 0; i < itemsList.FitnessItems.Count; i++)
                    {
                        if (itemsList.FitnessItems[i].dayofweek == Form1.theCurrentDT().DayOfWeek.ToString())
                        {
                            listboxFitness.Items.Add(itemsList.FitnessItems[i].title);
                        }
                    }
                    lblWorkoutsLeft.Text = "Workouts Today";
                    WorkoutsCount.Text = listboxFitness.Items.Count.ToString();
                }
                else
                {
                    lblWorkoutsLeft.Text = "Completed at";
                    WorkoutsCount.Text = StartWorkout.workoutTimeToday.ToString();
                }

            }
            else
            {
                lblWorkoutsLeft.Text = "No Workouts";
                WorkoutsCount.Text = "";
            }


            

        }

        private void setCals()
        {
            int left = 0;
            left = UC_Calories.getCalsLeft();
            if (left <= 0)
            {
                left = (Math.Abs(left));
                lblCalsRemaining.ForeColor = Color.DarkGreen;
                lblCalsLeft.Text = "Calories Over";
                lblCalsRemaining.Text = "+" + left.ToString();
            }
            else
            {
                lblCalsLeft.Text = "Calories Left";
                lblCalsRemaining.Text = left.ToString();
            }
            
            if (itemsList.CaloriesDailyList.Any())
            {
                for (int i = 0; i < itemsList.CaloriesDailyList.Count; i++)
                {
                    if (!itemsList.CaloriesDailyList[i].isEmpty)
                    {
                        listBoxCals.Items.Add(itemsList.CaloriesDailyList[i].title + " (" + itemsList.CaloriesDailyList[i].calories + " cals)");
                    }
                    
                }
            }

            
        }

        private void setTasks()
        {
            

            foreach (var item in itemsList.toDoItems)
                myObjList.Add(item);


            bs.DataSource = myObjList;
            tasksNotDone.DataSource = myObjList;//////
            BindingList<itemToDo> filtered = new BindingList<itemToDo>(myObjList.Where(obj => obj.isChecked != true).ToList());
            tasksNotDone.DataSource = filtered;



            tasksNotDone.Update();
            tasksNotDone.DisplayMember = "title";
            //if (!itemsList.toDoItems[i].isChecked)
            //tasksNotDone.Items.Add(itemsList.toDoItems[i].title);

            //var DistinctItems = itemsList.toDoItems.GroupBy(xx => xx.group).Select(yy => yy.First());
            //foreach (var item in DistinctItems)
            //{
            //    if (item.group != "")
            //        cGroup.Items.Add(item.group);
            //}

            if (tasksNotDone.Items.Count == 0 && !itemsList.toDoItems.Any())
            {
                lblTasks.ForeColor = Color.Black;
                lblTasks.Text = "No Tasks";
                tasksLeft.Text = "";
            }
            else if(tasksNotDone.Items.Count == 0 && itemsList.toDoItems.Any())
            {
                lblTasks.ForeColor = Color.DarkGreen;
                lblTasks.Text = "Completed";
                tasksLeft.Text = "";
            }
            else
            {
                lblTasks.ForeColor = Color.Black;
                lblTasks.Text = "Tasks left";
                tasksLeft.Text = tasksNotDone.Items.Count.ToString();
            }
            
        }

        private void addColors()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Color.FromArgb(120, 179, 84);

            shapeTask.FillColor = ControlPaint.Light(Items.itemToDo.color);
            shapeTask.BorderColor = ControlPaint.Dark(Items.itemToDo.color);

            lblTasks.BackColor = ControlPaint.Light(Items.itemToDo.color);
            tasksLeft.BackColor = ControlPaint.Light(Items.itemToDo.color);

            shapeCals.FillColor = ControlPaint.Light(Items.CalorieItem.color);
            shapeCals.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);

            lblCalsLeft.BackColor = ControlPaint.Light(Items.CalorieItem.color);
            lblCalsRemaining.BackColor = ControlPaint.Light(Items.CalorieItem.color);

            shapeFitness.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shapeFitness.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            lblWorkoutsLeft.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            WorkoutsCount.BackColor = ControlPaint.Light(Items.FitnessItem.color);

            btnPrev.FillColor = Color.FromArgb(120, 179, 84);
        }

        private void setCalender()
        {
            //if (Form1.fakeTime == true)
            //{
            //    week1.Text = Form1.current.AddDays(-3).DayOfWeek.ToString();
            //    week2.Text = Form1.current.AddDays(-2).DayOfWeek.ToString();
            //    week3.Text = Form1.current.AddDays(-1).DayOfWeek.ToString();
            //    week4.Text = Form1.current.DayOfWeek.ToString();
            //    week5.Text = Form1.current.AddDays(+1).DayOfWeek.ToString();
            //    week6.Text = Form1.current.AddDays(+2).DayOfWeek.ToString();
            //    week7.Text = Form1.current.AddDays(+3).DayOfWeek.ToString();
            //}
            //else
            //{
            //    week1.Text = DateTime.Now.AddDays(-3).DayOfWeek.ToString();
            //    week2.Text = DateTime.Now.AddDays(-2).DayOfWeek.ToString();
            //    week3.Text = DateTime.Now.AddDays(-1).DayOfWeek.ToString();
            //    week4.Text = DateTime.Now.DayOfWeek.ToString();
            //    week5.Text = DateTime.Now.AddDays(+1).DayOfWeek.ToString();
            //    week6.Text = DateTime.Now.AddDays(+2).DayOfWeek.ToString();
            //    week7.Text = DateTime.Now.AddDays(+3).DayOfWeek.ToString();
            //}

            week1.Text = Form1.theCurrentDT().AddDays(-3).DayOfWeek.ToString();
            week2.Text = Form1.theCurrentDT().AddDays(-2).DayOfWeek.ToString();
            week3.Text = Form1.theCurrentDT().AddDays(-1).DayOfWeek.ToString();
            week4.Text = Form1.theCurrentDT().DayOfWeek.ToString();
            week5.Text = Form1.theCurrentDT().AddDays(+1).DayOfWeek.ToString();
            week6.Text = Form1.theCurrentDT().AddDays(+2).DayOfWeek.ToString();
            week7.Text = Form1.theCurrentDT().AddDays(+3).DayOfWeek.ToString();


            foreach (var item in itemsList.FitnessItems)
            {
                if (item.dayofweek == week1.Text)
                {
                    fitnessW1++;
                }
                if (item.dayofweek == week2.Text)
                {
                    fitnessW2++;
                }
                if (item.dayofweek == week3.Text)
                {
                    fitnessW3++;
                }
                if (item.dayofweek == week4.Text)
                {
                    fitnessW4++;
                }
                if (item.dayofweek == week5.Text)
                {
                    fitnessW5++;
                }
                if (item.dayofweek == week6.Text)
                {
                    fitnessW6++;
                }
                if (item.dayofweek == week7.Text)
                {
                    fitnessW7++;
                }

            }

            //int taskCount = itemsList.toDoItems.Count;
            int taskCount = itemsList.toDoItems.Count;
            for (int i = 0; i < taskCount; i++) //MessageBox.Show(itemsList.toDoItems[i].DateCreated.ToShortDateString());
            {
                if (itemsList.toDoItems[i].repeatDays == 0)
                {
                    itemsW4++;
                }
                if (itemsList.toDoItems[i].repeatDays == 1)
                {
                    itemsW1++;
                    itemsW2++;
                    itemsW3++;
                    itemsW4++;
                    itemsW5++;
                    itemsW6++;
                    itemsW7++;
                }
                if (itemsList.toDoItems[i].repeatDays == 2)
                {
                    itemsW4++;
                    itemsW6++;
                    itemsW1++;
                    itemsW3++;
                }
                if (itemsList.toDoItems[i].repeatDays == 3)
                {
                    itemsW4++;
                    itemsW7++;
                    itemsW3++;
                }
                if (itemsList.toDoItems[i].repeatDays == 4)
                {
                    itemsW4++;
                    itemsW1++;
                }
                if (itemsList.toDoItems[i].repeatDays == 5)
                {
                    itemsW4++;
                    itemsW2++;
                }
                if (itemsList.toDoItems[i].repeatDays == 6)
                {
                    itemsW4++;
                    itemsW3++;
                }
                if (itemsList.toDoItems[i].repeatDays == 7)
                {
                    itemsW4++;
                }
                //day of week numbers % repeatdays



            }



        }

        private void weekDays_MouseClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in weekDays.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in weekDays.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        //MessageBox.Show("row  " +  row + "\ncolumn:  " + column);

                        if (row == 1)
                        {
                            switch (column)
                            {
                                case 0: //Sunday
                                    MessageBox.Show(itemsW1.ToString() + " tasks on " + week1.Text + "\n" 
                                        + fitnessW1.ToString() + " workouts on " + week1.Text + "\n"
                                    + UC_Calories.calorieGoal + " Calories on " + week1.Text);
                                    break;
                                case 1: //Monday
                                    MessageBox.Show(itemsW2.ToString() + " tasks on " + week2.Text + "\n" 
                                        + fitnessW2.ToString() + " workouts on " + week2.Text + "\n"
                                    + UC_Calories.calorieGoal + " Calories on " + week2.Text);
                                    break;
                                case 2: //Tuesday
                                    MessageBox.Show(itemsW3.ToString() + " tasks on " + week3.Text + "\n" 
                                        + fitnessW3.ToString() + " workouts on " + week3.Text + "\n"
                                    + UC_Calories.calorieGoal + " Calories on " + week3.Text);
                                    break;
                                case 3: //Wednesday
                                    MessageBox.Show(itemsW4.ToString() + " tasks today" + "\n" 
                                        + fitnessW4.ToString() + " workouts today " + "\n"
                                        + UC_Calories.getCalsLeft() + " Calories left today ");
                                    break;
                                case 4: //Thursday
                                    MessageBox.Show(itemsW5.ToString() + " tasks tomorrow" + "\n" 
                                        + fitnessW5.ToString() + " workouts tomorrow " + "\n"
                                    + UC_Calories.calorieGoal + " Calories tomorrow ");
                                    break;
                                case 5: //Friday
                                    MessageBox.Show(itemsW6.ToString() + " tasks on " + week6.Text + "\n" 
                                        + fitnessW6.ToString() + " workouts on " + week6.Text + "\n"
                                    + UC_Calories.calorieGoal + " Calories on " + week6.Text);
                                    break;
                                case 6: //Saturday
                                    MessageBox.Show(itemsW7.ToString() + " tasks on " + week7.Text + "\n" 
                                        + fitnessW7.ToString() + " workouts on " + week7.Text + "\n"
                                    + UC_Calories.calorieGoal + " Calories on " + week7.Text);
                                    break;
                                default:
                                    break;
                            }
                        }

                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }
    }
}
