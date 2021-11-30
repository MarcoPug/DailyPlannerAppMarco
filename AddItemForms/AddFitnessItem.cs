using DailyPlannerAppMarco.Items;
using DailyPlannerAppMarco.UserControls;
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
    public partial class AddFitnessItem : Form
    {
        public static int prevIndexWorkout;
        public AddFitnessItem()
        {
            InitializeComponent();

            txtNameWorkout.Visible = false;
            onWhatWeekday.Visible = false;

            label2.Visible = false;
            label3.Visible = false;

            txtReps.Visible = false;
            txtSets.Visible = false;

            btnAdd.FillColor = Items.FitnessItem.color;

            btnAdd.Location = new Point(69, 183);//73,133

            this.Size = new Size(374, 284);

            shape.Size = new Size(448, 307);
            shape.Location = new Point(-45, -31);

            /*
            var DistinctItems = itemsList.FitnessItems.GroupBy(xx => xx.group).Select(yy => yy.First());
            foreach (var item in DistinctItems)
            {
                if (item.group != "")
                    workoutDay.Items.Add(item.group);
            }
            */


            populateWorkoutDays();

            //MessageBox.Show("count: " + itemsList.FitnessItems.Count);

            if (itemsList.FitnessItems.Count != 0)
            {
                workoutDay.SelectedIndex = prevIndexWorkout;
            }


        }

        bool isEditing;
        int editIndex;
        public AddFitnessItem(int x)//is editing
        {
            InitializeComponent();

            txtNameWorkout.Visible = false;
            onWhatWeekday.Visible = false;

            label2.Visible = false;
            label3.Visible = false;

            txtReps.Visible = false;
            txtSets.Visible = false;

            isEditing = true;

            editIndex = x;

            btnAdd.FillColor = Items.FitnessItem.color;

            btnAdd.Location = new Point(69, 183);//73,133

            this.Size = new Size(374, 284);

            shape.Size = new Size(448, 307);
            shape.Location = new Point(-45, -31);

            populateWorkoutDays();

            //workoutDay.SelectedIndex = itemsList.FitnessItems[editIndex].dayofweek;

            switch (itemsList.FitnessItems[editIndex].dayofweek)
            {
                case "Sunday":
                    workoutDay.SelectedIndex = 0;
                    break;
                case "Monday":
                    workoutDay.SelectedIndex = 1;
                    break;
                case "Tuesday":
                    workoutDay.SelectedIndex = 2;
                    break;
                case "Wednesday":
                    workoutDay.SelectedIndex = 3;
                    break;
                case "Thursday":
                    workoutDay.SelectedIndex = 4;
                    break;
                case "Friday":
                    workoutDay.SelectedIndex = 5;
                    break;
                case "Saturday":
                    workoutDay.SelectedIndex = 6;
                    break;
                default:
                    break;
            }

            txtName.Text = txtSets.Text = itemsList.FitnessItems[editIndex].title;
            if (itemsList.FitnessItems[editIndex].sets == 0)
            {
                cbSetsReps.Checked = false;
                txtSets.Text = "";
                txtReps.Text = "";
            }
            else
            {
                cbSetsReps.Checked = true;
                txtSets.Text = itemsList.FitnessItems[editIndex].sets.ToString();
                txtReps.Text = itemsList.FitnessItems[editIndex].reps.ToString();
            }

        }

        bool addingWorkoutDay = false;
        public AddFitnessItem(bool isWorkoutDay)
        {
            InitializeComponent();
            addingWorkoutDay = true;

            cbSetsReps.Visible = false;
            txtReps.Visible = false;
            txtSets.Visible = false;

            label1.Visible = false;
            label4.Visible = false;

            txtName.Visible = false;
            workoutDay.Visible = false;

            btnAdd.FillColor = Items.FitnessItem.color;

            btnAdd.Text = "Add Workout Day";

            label3.Location = new Point(label1.Left, label1.Top);
            label2.Location = new Point(label4.Left, label4.Top);

            txtNameWorkout.Location = new Point(txtName.Left, txtName.Top);
            onWhatWeekday.Location = new Point(workoutDay.Left, workoutDay.Top);

            btnAdd.Location = new Point(69, 150);//73,133

            this.Size = new Size(374, 254);

            shape.Size = new Size(448, 269);
            shape.Location = new Point(-45, -27);

            populateWorkoutDays();



        }

        private void populateWorkoutDays()
        {
            for (int i = 0; i < FitnessItem.workoutDayNames.Length; i++)
            {
                if (FitnessItem.workoutDayNames[i] != null)
                {
                    //MessageBox.Show(FitnessItem.workoutDayNames[i]);
                    workoutDay.Items.Add(FitnessItem.workoutDayNames[i]);
                    //workoutDay.Items.Add(FitnessItem.workoutDayNames[i]);
                    //MessageBox.Show(workoutDaysList.Items[workoutDaysList.SelectedIndex] + " should be " + FitnessItem.workoutDayNames[workoutDaysList.SelectedIndex]);
                    //workoutDaysList.Items[workoutDaysList.SelectedIndex] = FitnessItem.workoutDayNames[workoutDaysList.SelectedIndex];
                }
                else if (FitnessItem.workoutDayNames[i] == null)
                {
                    workoutDay.Items.Add("Empty");
                }



            }
        }

        private void tryAddWorkoutDay()
        {
            if (txtNameWorkout.Text == "" || txtNameWorkout.Text == "Empty")
            {
                MessageBox.Show("Please dont leave information empty");

            }
            else if (onWhatWeekday.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a weekday");

            }
            else//works
            {

                //int index = workoutDay.Items.IndexOf("Empty");
                //MessageBox.Show(workoutDay.Items[index] + " : sus");
                //int index = onWhatWeekday.SelectedIndex;
                bool overwrite = true;
                int index = onWhatWeekday.SelectedIndex;
                if (FitnessItem.workoutDayNames[index] != null && FitnessItem.workoutDayNames[index] != "Empty")
                {
                    DialogResult dialogResult = MessageBox.Show("Overwrite " + FitnessItem.workoutDayNames[index] + " with " + txtNameWorkout.Text + " ?", "Overwrite Items", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        for (int i = 0; i < itemsList.FitnessItems.Count; i++)
                        {
                            if (itemsList.FitnessItems[i].group == FitnessItem.workoutDayNames[index])
                            {
                                itemsList.FitnessItems[i].group = txtNameWorkout.Text;
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        overwrite = false;
                    }

                }

                // FitnessItem.workoutDayNames[onWhatWeekday.SelectedIndex]//cardio
                // txtNameWorkout.Text // cardio


                // FitnessItem.weekdayNames[onWhatWeekday.SelectedIndex] // Sunday
                // onWhatWeekday.SelectedItem // Sunday

                if (overwrite)
                {
                    FitnessItem.workoutDayNames[index] = txtNameWorkout.Text; // WorkoutNames[0] = Cardio
                    FitnessItem.weekdayNames[index] = onWhatWeekday.SelectedItem.ToString(); // WeekdayNames[0] = Sunday

                    this.Close();
                }

                





                /*
                for (int i = 0; i < FitnessItem.workoutDayNames.Length; i++)
                {
                    FitnessItem.workoutDayNames[i] = onWhatWeekday.SelectedItem.ToString();
                    MessageBox.Show(FitnessItem.workoutDayNames[i] = onWhatWeekday.SelectedItem.ToString());
                }*/
                
            }

        }

        private void tryAddItem()
        {
            int test = 0;
            bool success = Int32.TryParse(txtSets.Text, out test);
            int test2 = 0;
            bool success2 = Int32.TryParse(txtReps.Text, out test2);
            if (txtName.Text == "")
            {
                MessageBox.Show("Please dont leave information blank");

            }
            else if (workoutDay.SelectedIndex == -1)
            {
                MessageBox.Show("You must have a Workout Day before you can add workouts");

            }
            else if (workoutDay.SelectedItem.ToString() == "Empty")
            {
                MessageBox.Show("Please don't select an empty day");
            }
            else if (cbSetsReps.Checked && ((!success || test == 0) && (!success2 || test2 == 0)))
            {
                MessageBox.Show("Please have accurate sets and reps");
            }
            else
            {

                if (!isEditing)
                {
                    FitnessItem item = new FitnessItem();


                    if (cbSetsReps.Checked)
                    {
                        item.sets = test;
                        item.reps = test2;

                    }


                    //MessageBox.Show("weekday?: " + FitnessItem.weekdayNames[i]);
                    //item.dayofweek = FitnessItem.weekdayNames[i];


                    //MessageBox.Show("weekday?: " + item.dayofweek);
                    //item.dayofweek = 

                    item.title = txtName.Text;
                    item.group = workoutDay.SelectedItem.ToString();

                    item.dayofweek = FitnessItem.weekdayNames[workoutDay.SelectedIndex];
                    prevIndexWorkout = workoutDay.SelectedIndex;

                    //MessageBox.Show("worked properly");
                    itemsList.FitnessItems.Add(item);
                }
                else
                {
                    if (cbSetsReps.Checked)
                    {
                        itemsList.FitnessItems[editIndex].sets = test;
                        itemsList.FitnessItems[editIndex].reps = test2;

                    }
                    itemsList.FitnessItems[editIndex].title = txtName.Text;
                    itemsList.FitnessItems[editIndex].group = workoutDay.SelectedItem.ToString();

                    itemsList.FitnessItems[editIndex].dayofweek = FitnessItem.weekdayNames[workoutDay.SelectedIndex];
                    prevIndexWorkout = workoutDay.SelectedIndex;
                }
                
                this.Close();

            }

        }

        private void cbSetsReps_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSetsReps.Checked)
            {
                txtSets.Visible = true;
                txtReps.Visible = true;
            }
            else
            {
                txtSets.Visible = false;
                txtReps.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!addingWorkoutDay)
            {
                tryAddItem();
            }
            else
            {
                tryAddWorkoutDay();
            }
        }

        private void AddFitnessItem_Load(object sender, EventArgs e)
        {
            this.BackColor = ControlPaint.Light(Items.FitnessItem.color);


            shape.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);
        }
    }
}
