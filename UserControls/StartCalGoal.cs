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
    public partial class StartCalGoal : Form
    {
        readonly MongoCRUD db;


        public StartCalGoal()
        {
            InitializeComponent();

            db = new MongoCRUD(Form1.dbName);

            fillAppInfo();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            checkInfo();

        }
        string gender;
        int weight;
        int feet;
        int inches;
        int height;
        int age;
        double BMR;
        double calGoal;
        private void checkInfo()
        {
  
            bool testWeight = Int32.TryParse(txtWeight.Text, out weight);


            bool testFeet = Int32.TryParse(txtFeet.Text, out feet);


            bool testInches = Int32.TryParse(txtInches.Text, out inches);


            bool testAge = Int32.TryParse(txtAge.Text, out age);

            if (
                txtWeight.Text == "" || txtFeet.Text == "" || txtInches.Text == "" || txtAge.Text == "" ||
                !testWeight || !testFeet || !testInches || !testAge ||
                (!rbMale.Checked && !rbFemale.Checked) ||
                cbWorkout.SelectedIndex == -1 || cbType.SelectedIndex == -1
                )
            {
                MessageBox.Show("Invalid Information");
            }
            else
            {

                calculateInfo();
                UC_Calories.calorieGoal = (int)calGoal;
                MessageBox.Show("Your new calorie goal is " + (int)calGoal + "!");
                holdUserInfo();
                this.Close();
            }
        }

        private void calculateInfo()
        {
            height = (feet * 12) + inches;



            if (rbMale.Checked)
            {
                BMR = 65 + (6.2 * weight) + (12.7 * height) - (6.8 * age);
                gender = "Male";


            }
            else if (rbFemale.Checked)
            {
                BMR = 655 + (4.3 * weight) + (4.3 * height) - (4.7 * age);
                gender = "Female";
            }

            double type = 1;
            switch (cbType.SelectedIndex)
            {
                case 0:
                    if (BMR > 1000)
                    {
                        type = 1.0;
                    }
                    break;
                case 1:
                    type = 1.1;
                    break;
                case 2:
                    type = 1.2;
                    break;
                default:
                    break;
            }

            //MessageBox.Show("bmr1: " + BMR);
            BMR = BMR * type;
            //MessageBox.Show("bmr2: " + BMR);
            switch (cbWorkout.SelectedIndex)
            {
                case 0:
                    calGoal = BMR * 1.2;
                    break;
                case 1:
                    calGoal = BMR * 1.375;
                    break;
                case 2:
                    calGoal = BMR * 1.55;
                    break;
                case 3:
                    calGoal = BMR * 1.725;
                    break;
                case 4:
                    calGoal = BMR * 1.9;
                    break;
                default:
                    break;
            }



        }

        private void holdUserInfo()
        {
            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);
            currRecord.bmrInfo.TypeCB = cbType.SelectedIndex;
            currRecord.bmrInfo.Weight = weight;
            currRecord.bmrInfo.Feet = feet;
            currRecord.bmrInfo.Inches = inches;
            currRecord.bmrInfo.Age = age;
            currRecord.bmrInfo.Gender = gender;
            currRecord.bmrInfo.WorkoutCB = cbWorkout.SelectedIndex;

            currRecord.bmrInfo.calorieGoal = (int)calGoal;
            db.UpsertRecord(Form1.dbName, Form1.currId, currRecord);


        }

        private void fillAppInfo()
        {
            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);

            if (currRecord.appInfo.leftBefore)
            {
                currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);


                cbType.SelectedIndex = currRecord.bmrInfo.TypeCB;
                txtWeight.Text = currRecord.bmrInfo.Weight.ToString();
                txtFeet.Text = currRecord.bmrInfo.Feet.ToString();
                txtInches.Text = currRecord.bmrInfo.Inches.ToString();
                txtAge.Text = currRecord.bmrInfo.Age.ToString();
                cbWorkout.SelectedIndex = currRecord.bmrInfo.WorkoutCB;

                if (currRecord.bmrInfo.Gender == "Male")
                {
                    rbMale.Checked = true;
                }
                else if (currRecord.bmrInfo.Gender == "female")
                {
                    rbFemale.Checked = true;
                }

            }

        }
    }
}
