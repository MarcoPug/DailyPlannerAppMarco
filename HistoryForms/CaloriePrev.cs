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
    public partial class CaloriePrev : Form
    {
        private int index = 0;

        public CaloriePrev()
        {
            
            InitializeComponent();

            index = itemsList.calListList.Count - 1;


            if (index != -1)
            {




                txtDate.Text = itemsList.calListList[index][0].itemDate.ToShortDateString();
                displayList();

                
            }
            else
            {
                lblCalGoal.Text = "";
            }



            addColors();
        }

        private void addColors()
        {
            btnLeft.FillColor = Items.CalorieItem.color;
            btnRight.FillColor = Items.CalorieItem.color;


            btnRight.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            btnLeft.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            shape.FillColor = ControlPaint.Light(Items.CalorieItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);

            shape2.FillColor = ControlPaint.Light(Items.CalorieItem.color);
            shape2.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);

            lblCalGoal.BackColor = ControlPaint.Light(Items.CalorieItem.color);
        }


        private void displayList()
        {

            checkIfReachedGoal();
            for (int i = 0; i < itemsList.calListList[index].Count; i++)
            {
                if (!itemsList.calListList[index][i].isEmpty)
                {
                    listBox.Items.Add(itemsList.calListList[index][i].title);
                    listBox2.Items.Add(itemsList.calListList[index][i].calories + " calories");
                }
            
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {

            }
        }

        private void checkIfReachedGoal()
        {
            int total = 0;
            for (int i = 0; i < itemsList.calListList[index].Count; i++)
            {
                total = total + itemsList.calListList[index][i].calories;
            }
            if (total < UserControls.UC_Calories.calorieGoal)
            {
                lblCalGoal.Text = total.ToString() + " Did not satisfy current \ncalorie goal of " + UserControls.UC_Calories.calorieGoal.ToString();
            }
            else
            {
                lblCalGoal.Text = total.ToString() + " Satisfied current \ncalorie goal of " + UserControls.UC_Calories.calorieGoal.ToString();
            }
        }

        private void CaloriePrev_Load(object sender, EventArgs e)
        {

        }


        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {


                index--;
                txtDate.Text = itemsList.calListList[index][0].itemDate.ToShortDateString();

                listBox.Items.Clear();
                listBox2.Items.Clear();
                displayList();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < itemsList.calListList.Count - 1)
            {
                index++;

                txtDate.Text = itemsList.calListList[index][0].itemDate.ToShortDateString();

                listBox.Items.Clear();
                listBox2.Items.Clear();
                displayList();

            }
        }
    }
}
