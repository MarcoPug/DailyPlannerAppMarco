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
    public partial class FitnessPrev : Form
    {
        private int index = 0;
        public FitnessPrev()
        {
            InitializeComponent();

            //MessageBox.Show("count: " + itemsList.FitnessWorkoutTimes.Count);
            for (int i = 0; i < itemsList.FitnessWorkoutTimes.Count; i++)
            {
                //MessageBox.Show("number : " + i + ":  " +itemsList.FitnessWorkoutTimes[i].workoutTime + " : " + itemsList.FitnessWorkoutTimes[i].itemDate);
            }

            index = itemsList.FitnessWorkoutTimes.Count - 1;
            //int itemInList = 0;

            if (index != -1)
            {

                displayList();


            }
            else
            {
                lblFitnessGoal.Text = "";
            }

            addColors();
        }

        private void addColors()
        {
            btnLeft.FillColor = Items.FitnessItem.color;
            btnRight.FillColor = Items.FitnessItem.color;


            btnRight.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            btnLeft.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            shape.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            shape2.FillColor = ControlPaint.Light(Items.FitnessItem.color);
            shape2.BorderColor = ControlPaint.Dark(Items.FitnessItem.color);

            lblFitnessGoal.BackColor = ControlPaint.Light(Items.FitnessItem.color);
        }



        private void displayList()
        {
            //MessageBox.Show("count: "+itemsList.calListList.Count);

            //listBox.Items.Add(itemsList.FitnessWorkoutTimes[index].workoutTime + "");
            lblFitnessGoal.Text = itemsList.FitnessWorkoutTimes[index].workoutTime.ToString();
            txtDate.Text = itemsList.FitnessWorkoutTimes[index].itemDate.ToString("MM/dd/yyyy");

            for (int i = 0; i < itemsList.FitnessWorkoutTimes[index].workoutNamesToday.Count; i++)
            {
                if (itemsList.FitnessWorkoutTimes[index].workoutTime.ToString() != "00:00:00")
                {
                    listBox.Items.Add(itemsList.FitnessWorkoutTimes[index].workoutNamesToday[i]);
                }
                else
                {
                    listBox.Items.Clear();
                }
            }


        }



        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {


                index--;
                //txtDate.Text = itemsList.calListList[index][0].itemDate.ToShortDateString();
                //currList = itemsList.calListList[index];
                listBox.Items.Clear();
                displayList();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < itemsList.FitnessWorkoutTimes.Count - 1)
            {
                index++;

                //txtDate.Text = itemsList.calListList[index][0].itemDate.ToShortDateString();

                listBox.Items.Clear();
                displayList();

            }
        }
    }
}
