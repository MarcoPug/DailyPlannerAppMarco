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
using System.Linq;

namespace DailyPlannerAppMarco.HistoryForms
{
    public partial class HomePrev : Form
    {
        DateTime chosenMonth = Form1.theCurrentDT();
        public HomePrev()
        {
            InitializeComponent();

            chosenMonth = chosenMonth.AddMonths(-1);

            

            displayInfo();
            addColors();



        }

        private void addColors()
        {
            btnLeft.FillColor = Color.FromArgb(120, 179, 84);
            btnRight.FillColor = Color.FromArgb(120, 179, 84);


            btnRight.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            btnLeft.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            shape.FillColor = ControlPaint.Light(Color.FromArgb(120, 179, 84));
            shape.BorderColor = ControlPaint.Dark(Color.FromArgb(120, 179, 84));

            lblAvgSleep.BackColor = ControlPaint.Light(Color.FromArgb(120, 179, 84));
            avgWorkoutTime.BackColor = ControlPaint.Light(Color.FromArgb(120, 179, 84));
            lblMonthCalTotal.BackColor = ControlPaint.Light(Color.FromArgb(120, 179, 84));
        }

        private void displayInfo()
        {
            txtDate.Text = chosenMonth.ToString("MM/yyyy");
            displayMonthlyCalsTotal();
            displayAvgFitness();
            avgSleepDay();
        }

        private void displayMonthlyCalsTotal()
        {
            int monthlyCalsTotal = 0;
            if (itemsList.CalsMonthly.Any())
            {
                for (int i = 0; i < itemsList.CalsMonthly.Count; i++)
                {
                    if (itemsList.CalsMonthly[i].itemDate.Month == chosenMonth.Month && itemsList.CalsMonthly[i].itemDate.Year == chosenMonth.Year)
                    {
                        monthlyCalsTotal = monthlyCalsTotal + itemsList.CalsMonthly[i].calories;
                    }

                }

                lblMonthCalTotal.Text = "Average cals per day: " + (monthlyCalsTotal / System.DateTime.DaysInMonth(chosenMonth.Year, chosenMonth.Month));

            }
        }

        private void displayAvgFitness()
        {
            TimeSpan workoutTimesTotal = TimeSpan.Zero;
            if (itemsList.FitnessWorkoutTimes.Any())
            {
                for (int i = 0; i < itemsList.FitnessWorkoutTimes.Count; i++)
                {
                    if (itemsList.FitnessWorkoutTimes[i].itemDate.Month == chosenMonth.Month && itemsList.FitnessWorkoutTimes[i].itemDate.Year == chosenMonth.Year)
                    {
                        workoutTimesTotal = workoutTimesTotal + itemsList.FitnessWorkoutTimes[i].workoutTime;
                    }

                }
                avgWorkoutTime.Text = "Time spent working out this month: " + workoutTimesTotal.ToString();
            }


        }

        private void avgSleepDay()
        {
            
            if (itemsList.SleepDailyListList.Any())
            {
                string[] sleepTimes = new string[itemsList.SleepDailyListList.Count];
                for (int i = 0; i < itemsList.SleepDailyListList.Count; i++)
                {
                    if (itemsList.SleepDailyListList[i][0].wokeUp.Month == chosenMonth.Month && itemsList.SleepDailyListList[i][0].wokeUp.Year == chosenMonth.Year)
                    {
                        sleepTimes[i] = itemsList.SleepDailyListList[i][0].wokeUp.ToString("hh:mm:ss tt");
                    }
                }

                var mostCommonValue = sleepTimes.GroupBy(v => v)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();

                lblAvgSleep.Text = "Most common time woken up at is: " + mostCommonValue;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            chosenMonth = chosenMonth.AddMonths(1);
            displayInfo();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            chosenMonth = chosenMonth.AddMonths(-1);
            displayInfo();


        }
    }
}
