using DailyPlannerAppMarco.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DailyPlannerAppMarco.UserControls
{
    public partial class StartWorkout : Form
    {
        
        System.Timers.Timer t;
        //System.Timers.Timer tBreak;
        int h, m, s;
        //static bool didAlready = false;

        List<string> workoutTimes = new List<string>();

        //List<int> workoutIndex = new List<int>();



        //DateTime workoutsTodayDate;

        public static bool completed = false;

        
        int workout = 0;

        
        private void StartWorkout_Load(object sender, EventArgs e)
        {
            addColors();

            //workoutsTodayDate = Form1.theCurrentDT();

            //MessageBox.Show(workoutsTodayDate.DayOfWeek.ToString());


            //var sb = new System.Text.StringBuilder();
            //for (int i = 0; i < itemsList.FitnessItems.Count; i++)
            //{
            //    if (itemsList.FitnessItems[i].dayofweek == workoutsTodayDate.DayOfWeek.ToString())
            //    {
            //        //sb.AppendLine(itemsList.FitnessItems[i].title + "\n");

            //        //workouts[i] = itemsList.FitnessItems[i].title;
            //        workouts.Add(itemsList.FitnessItems[i].title);


            //    }

            //}

            //for (int i = 0; i < workouts.Count; i++)
            //{
            //    MessageBox.Show("workout #" + i + " is " + workouts[i]);
            //}

            //label1.Text = sb.ToString();

            workoutsToday.Clear();
            getWorkouts();

            if (workoutsToday.Count <= 0)
            {
                MessageBox.Show("You have no workouts scheduled today");
                this.Close(); ////
            }
            else
            {
                txtWorkout.Text = workoutsToday[0].title;
            }


            //MessageBox.Show("number of workouts we will do: " + workouts.Count);

            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;

            


            if (workoutTimeToday.ToString() != "00:00:00")
            {
                
                DialogResult dialogResult = MessageBox.Show("You already did this workout today. Overwrite data?", "Overwrite data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    workoutTimeToday = TimeSpan.Zero;
                    
                    completed = false;

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }

            for (int i = 0; i < workoutsToday.Count; i++)
            {
                //MessageBox.Show((i + 1) + " workout is : " + workoutsToday[i].title + "\nsets: " + workoutsToday[i].sets + "\nreps: " + workoutsToday[i].reps);
            }

        }

        private void getWorkouts()
        {
            for (int i = 0; i < itemsList.FitnessItems.Count; i++)
            {
                if (itemsList.FitnessItems[i].dayofweek == Form1.theCurrentDT().DayOfWeek.ToString())
                {
                    workoutsToday.Add(itemsList.FitnessItems[i]);
                    //workoutIndex[i] = i;
                }

            }



            tempSets = workoutsToday[0].sets;
            tempReps = workoutsToday[0].reps;
            //MessageBox.Show(tempSets.ToString() + " sets and " + tempReps + " reps!");

            totalSets.Text = tempSets.ToString();
            totalReps.Text = tempReps.ToString();

            currSets.Text = tempSets.ToString();
            currReps.Text = tempReps.ToString();
        }

        private void addColors()
        {
            shape.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            shape2.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shape2.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            label5.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            label3.BackColor = ControlPaint.Light(Items.FitnessItem.color);

            totalSets.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            totalReps.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            currReps.BackColor = ControlPaint.Light(Items.FitnessItem.color);
            currSets.BackColor = ControlPaint.Light(Items.FitnessItem.color);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void StartWorkout_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        static int tempSets;
        static int tempReps;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!t.Enabled || txtResult.Text == "00:00:00")
            {
                MessageBox.Show("Cannot proceed with workout while timer is stopped");
            }
            else
            {

                //MessageBox.Show("if " + itemsList.FitnessItems[workout].reps + " != " + tempReps);
                if ((workoutsToday[0].reps != 0 || workoutsToday[0].reps != tempReps) && tempReps != 1)
                {
                    //MessageBox.Show("entered reps");
                    tempReps--;
                    currReps.Text = tempReps.ToString();
                    //MessageBox.Show(tempReps + ": remaining reps");

                }
                else if ((workoutsToday[workout].sets != 0 || workoutsToday[workout].sets != tempSets) && tempSets != 1)
                {
                    //MessageBox.Show("entered sets");
                    tempSets--;
                    tempReps = workoutsToday[workout].reps;//reset reps
                    currSets.Text = tempSets.ToString();
                    currReps.Text = tempReps.ToString();
                    //MessageBox.Show(tempSets + ": remaining sets");

                    //currSets.Text = totalSets.Text = tempSets.ToString();
                    //currReps.Text = itemsList.FitnessItems[0].reps.ToString();

                }
                else
                {
                    NextWorkout();

                }
            }
            
            

        }

        private void NextWorkout()
        {
            t.Stop();
            workout++;

            //MessageBox.Show(txtWorkout.Text + " : " + txtResult.Text);
            workoutTimes.Add(txtResult.Text);

            h = 0;
            m = 0;
            s = 0;
            txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));


            if (workout < workoutsToday.Count)
            {

                //MessageBox.Show(workouts[i] + "\n");
                txtWorkout.Text = workoutsToday[workout].title;


                
                tempSets = workoutsToday[workout].sets;
                tempReps = workoutsToday[workout].reps;

                totalSets.Text = tempSets.ToString();
                totalReps.Text = tempReps.ToString();

                currSets.Text = totalSets.Text = tempSets.ToString();
                currReps.Text = totalReps.Text = tempReps.ToString();
                //t.Start();

            }
            else
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("You finished todays workout with,\n ");

                TimeSpan times = new TimeSpan();

                for (int i = 0; i < workoutTimes.Count; i++)
                {
                    sb.AppendLine(workoutsToday[i].title + " : " + workoutTimes[i] + "\n");
                    times = times.Add(TimeSpan.Parse(workoutTimes[i]));
                }
                MessageBox.Show(sb.ToString() + "\nWith a total time of " + times.ToString());

                workoutTimeToday = times;
                //MessageBox.Show("workoutTimeToday.workoutTime: " + workoutTimeToday.workoutTime);

                //didAlready = true;
                completed = true;
                this.Close();
            }
        }
        public static List<FitnessItem> workoutsToday = new List<FitnessItem>();
        public static TimeSpan workoutTimeToday = TimeSpan.Zero;
        //public static List<string> workouts = new List<string>(); ///
        //List<FitnessItem> workoutTimesToday = new List<FitnessItem>();
        private void btnNextSet_Click(object sender, EventArgs e)
        {
            if (!t.Enabled || txtResult.Text == "00:00:00")
            {
                MessageBox.Show("Cannot proceed with workout while timer is stopped");
            }
            else
            {
                //MessageBox.Show("workout: " + workout);
                //MessageBox.Show("(workoutsToday[workout].sets: " + workoutsToday[workout].sets);

                if ((workoutsToday[workout].sets != 0 || workoutsToday[workout].sets != tempSets) && tempSets != 1)
                {
                    //MessageBox.Show("entered sets");
                    tempSets--;
                    tempReps = workoutsToday[workout].reps;//reset reps
                    currSets.Text = tempSets.ToString();
                    currReps.Text = tempReps.ToString();
                    //MessageBox.Show(tempSets + ": remaining sets");

                    //currSets.Text = totalSets.Text = tempSets.ToString();
                    //currReps.Text = itemsList.FitnessItems[0].reps.ToString();

                }
                else
                {
                    NextWorkout();

                }
            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = string.Format("{0}:{1}:{2}",h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
       
        public StartWorkout()
        {
            InitializeComponent();



           

        }
    }
}
