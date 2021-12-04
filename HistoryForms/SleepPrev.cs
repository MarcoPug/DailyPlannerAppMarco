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
    public partial class SleepPrev : Form
    {
        private int index = 0;
        public SleepPrev()
        {
            InitializeComponent();

            index = itemsList.SleepDailyListList.Count - 1;

            if (index != -1)
            {
                txtDate.Text = itemsList.SleepDailyListList[index][0].wokeUp.ToShortDateString();
                displayList();



            }
            addColors();


        }

        private void addColors()
        {
            btnLeft.FillColor = Items.SleepItem.color;
            btnRight.FillColor = Items.SleepItem.color;


            btnRight.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            btnLeft.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            shape.FillColor = ControlPaint.Light(Items.SleepItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.SleepItem.color);

            shape2.FillColor = ControlPaint.Light(Items.SleepItem.color);
            shape2.BorderColor = ControlPaint.Dark(Items.SleepItem.color);

            lblSleepGoal.BackColor = ControlPaint.Light(Items.SleepItem.color);
        }

        private void displayList()
        {
            for (int i = 0; i < itemsList.SleepDailyListList[index].Count; i++)
            {
                if (!itemsList.SleepDailyListList[index][i].isEmpty)
                {
                    listBox.Items.Add(itemsList.SleepDailyListList[index][i].wokeUp.ToString("hh:mm:ss tt") ); //

                    lblSleepGoal.Text = "Woke up at " + itemsList.SleepDailyListList[index][i].wokeUp.ToString("h:mm tt on\nddd, dd MMM yyy");
                }
                else
                {
                    lblSleepGoal.Text = "";
                }

            }

            

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {


                index--;
                txtDate.Text = itemsList.SleepDailyListList[index][0].wokeUp.ToShortDateString();
                listBox.Items.Clear();
                displayList();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < itemsList.SleepDailyListList.Count - 1)
            {
                index++;

                txtDate.Text = itemsList.SleepDailyListList[index][0].wokeUp.ToShortDateString();

                listBox.Items.Clear();
                displayList();

            }
        }
    }
}
