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
    public partial class UC_Calories : UserControl
    {

        BindingSource bs = new BindingSource();
        public static int calorieGoal = 2000;

        public UC_Calories()
        {
            InitializeComponent();

            bs.DataSource = itemsList.CaloriesDailyList;

            checkBindingSource();

            bs.ResetBindings(false);

            updateCaloriesLeft();

            addColor();
        }
        private void addColor()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Items.CalorieItem.color;


            btnDown.FillColor = Items.CalorieItem.color;
            btnUp.FillColor = Items.CalorieItem.color;

            btnPrev.FillColor = Items.CalorieItem.color;

            btnUp.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            btnCalGoal.FillColor = Items.CalorieItem.color;
            btnCalGoal.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);

            calGoalInput.FillColor = Items.CalorieItem.color;
            calGoalInput.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);

            lblCalorieGoal.BackColor = ControlPaint.Light(Items.CalorieItem.color);

            shape.FillColor = ControlPaint.Light(Items.CalorieItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.CalorieItem.color);




        }
        public static int getCalsLeft()
        {
            int left = 0;
            for (int i = 0; i < itemsList.CaloriesDailyList.Count; i++)
            {
                left = left + itemsList.CaloriesDailyList[i].calories;
            }
            left = calorieGoal - left;
            return left;
        }
        private void updateCaloriesLeft()
        {
            int left = getCalsLeft();

            if (left <= 0)
            {

                left = (Math.Abs(left));
                lblCalorieGoal.Text = "Reached Daily Goal!\n" + left.ToString() + " cals over";
            }
            else
            {
                lblCalorieGoal.Text = "Calories Remaining Today\n" + left.ToString();
            }
            
        }

       

        private void checkBindingSource()
        {
            if (itemsList.CaloriesDailyList.Count > 1)
            {
                for (int i = 0; i < itemsList.CaloriesDailyList.Count; i++)
                {
                    if (itemsList.CaloriesDailyList[i].isEmpty)
                    {
                        itemsList.CaloriesDailyList.RemoveAt(i);
                    }
                }
            }

            if (itemsList.CaloriesDailyList.Count == 1 && itemsList.CaloriesDailyList[0].isEmpty)
            {
                listBoxCals.DataSource = null;
                listBox.DataSource = null;
            }
            else
            {
                listBoxCals.DataSource = bs;
                listBox.DataSource = bs;

                listBox.DisplayMember = "title";
                listBoxCals.DisplayMember = "calories";
            }
        }

        private void UC_Calories_Load(object sender, EventArgs e)
        {

        }

        private void UC_Calories_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
            listBoxCals.ClearSelected();
        }

        private void btnAddCalories_Click(object sender, EventArgs e)
        {
            addCalorieItem formadd = new addCalorieItem();
            formadd.ShowDialog();

            checkBindingSource();


            bs.ResetBindings(false);

            listBox.ClearSelected();
            listBoxCals.ClearSelected();

            updateCaloriesLeft();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                itemsList.CaloriesDailyList.RemoveAt(listBox.SelectedIndex);

                bs.ResetBindings(false);
                updateCaloriesLeft();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CaloriePrev formadd = new CaloriePrev();
            formadd.ShowDialog();


            bs.ResetBindings(false);

            listBox.ClearSelected();
            listBoxCals.ClearSelected();
        }

        int selectedIndex;
        private void btnUp_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox.SelectedIndex;

            if (selectedIndex - 1 != -1 && selectedIndex != -1)
            {
                selectedIndex--;

                MoveItem(listBox, -1);

                listBox.SetSelected(selectedIndex, true);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (selectedIndex + 1 != listBox.Items.Count && selectedIndex != -1)
            {


                selectedIndex++;

                MoveItem(listBox, 1);

            }
        }

        public void MoveItem(ListBox listBox, int direction)
        {



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

        private void btnCalGoal_Click(object sender, EventArgs e)
        {
            StartCalGoal formadd = new StartCalGoal();
            formadd.ShowDialog();

            bs.ResetBindings(false);

            updateCaloriesLeft();
        }

        private void calGoalInput_Click(object sender, EventArgs e)
        {
            addCalorieItem formadd = new addCalorieItem(true);
            formadd.ShowDialog();

            bs.ResetBindings(false);

            updateCaloriesLeft();
        }
    }
}
