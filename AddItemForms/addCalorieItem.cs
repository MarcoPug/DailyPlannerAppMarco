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
    public partial class addCalorieItem : Form
    {
        readonly MongoCRUD db;
        public addCalorieItem()
        {
            InitializeComponent();

            btnAdd.FillColor = Items.CalorieItem.color;
            
        }
        bool addingCalorieGoal;
        public addCalorieItem(bool addingGoal)
        {
            db = new MongoCRUD(Form1.dbName);
            addingCalorieGoal = addingGoal;
            InitializeComponent();

            txtName.Visible = false;
            label1.Visible = false;

            btnAdd.FillColor = Items.CalorieItem.color;

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addingCalorieGoal)
            {
                bool testCals = Int32.TryParse(txtCalories.Text, out int calgoal);

                var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);
                if (testCals && calgoal != 0 && calgoal > 0)
                {
                    UC_Calories.calorieGoal = calgoal;
                    currRecord.bmrInfo.calorieGoal = calgoal;
                    this.Close();
                }
                db.UpsertRecord(Form1.dbName, Form1.currId, currRecord);
            }
            else
            {
                int test = 0;
                bool success = Int32.TryParse(txtCalories.Text, out test);


                if (txtName.Text == "")
                {
                    MessageBox.Show("Please don't leave empty information");
                }
                else if (!success || test == 0)
                {
                    MessageBox.Show("Please enter accurate information");
                }
                else if (test > 9999)
                {
                    MessageBox.Show("Too many calories! what are you eating???");
                }
                else
                {
                    CalorieItem food = new CalorieItem(test, txtName.Text);
                    itemsList.CaloriesDailyList.Add(food);
                    this.Close();

                }
            }
            
        }

        private void addCalorieItem_Load(object sender, EventArgs e)
        {
            this.BackColor = ControlPaint.Light(Items.CalorieItem.color);
        }
    }
}
