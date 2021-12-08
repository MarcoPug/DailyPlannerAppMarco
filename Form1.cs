using DailyPlannerAppMarco.AddItemForms;
using DailyPlannerAppMarco.Items;
using DailyPlannerAppMarco.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;

namespace DailyPlannerAppMarco
{
    public partial class Form1 : Form
    {
        public static bool fakeTime = false;
        public static DateTime current;
        public static DateTime curFakeTime = DateTime.Now;
        DateTime enterFormDate = new DateTime(); 


        public static bool loggedIn = false;
        public static string dbName = "UserAccounts";
        public static Guid currId;


        MongoCRUD database = new MongoCRUD(dbName);


        public Form1()
        {
            InitializeComponent();

            logInForm formadd = new logInForm();
            formadd.ShowDialog();

            if (loggedIn)
            {


                UC_Home uc = new UC_Home();
                AddUserControl(uc);



                current = DateTime.Now;
                enterFormDate = DateTime.Now;

                setColors();


                MongoCRUD db = database;
                var currRecord = db.LoadRecordById<User>(dbName, currId);
                if (currRecord.appInfo.leftBefore)
                {

                    db.UpsertRecord(dbName, currId, currRecord);
                   

                }


                //cals default
                if (itemsList.CaloriesDailyList.Count == 0)
                {
                    CalorieItem food = new CalorieItem(0, "");
                    food.isEmpty = true;
                    itemsList.CaloriesDailyList.Add(food);
                }

                ////
                //int count = 0;

                //var recs = db.LoadRecords<User>(Form1.dbName);
                //foreach (var rec in recs)
                //{

                //    if ("jackSmith@gmail.com" == rec.Email)
                //    {
                //        count++;
                //        CalorieItem cal = new CalorieItem(1000, "Food");

                //        for (int i = 15; i <= 30; i++)
                //        {
                //            newDayCalorie();
                //            cal.title = "Food";
                //            cal.calories = 1000;
                //            cal.itemDate = new DateTime(2021, 11, i, 0, 00, 0);
                //            itemsList.CaloriesDailyList.Add(cal);
                            
                //        }
                //        setNewMonth();

                //    }
                //}

                //if (count == 0)
                //{

                //    User user = new User
                //    {
                //        Email = "jackSmith@gmail.com",
                //        Password = "brookdale1234",
                //        listInfo = new userListInfo
                //        {

                //        },
                //        appInfo = new userAppInfo
                //        {
                //            leftBefore = false,
                //            Admin = true

                //        },
                //        bmrInfo = new userBMRinfo
                //        {

                //        }
                //    };
                //    db.InsertRecord(Form1.dbName, user);
                //}
                ////
            }


        }

        private void setColors()
        {
            btnHome.CheckedState.CustomBorderColor = Color.DarkSlateGray;
            btnHome.HoverState.CustomBorderColor = Color.DarkSlateGray;

            guna2Button1.CheckedState.CustomBorderColor = itemToDo.color;
            guna2Button1.HoverState.CustomBorderColor = itemToDo.color;

            guna2Button2.CheckedState.CustomBorderColor = FitnessItem.color;
            guna2Button2.HoverState.CustomBorderColor = FitnessItem.color;

            guna2Button3.CheckedState.CustomBorderColor = CalorieItem.color;
            guna2Button3.HoverState.CustomBorderColor = CalorieItem.color;

            guna2Button4.CheckedState.CustomBorderColor = SleepItem.color;
            guna2Button4.HoverState.CustomBorderColor = SleepItem.color;
        }

        private void AddUserControl(UserControl userControl)
        {
            
            if (!usingAdminTools)
            {
                checkItemDue();
            }
            

            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

            
        }

        private void checkItemDue()
        {
            for (int i = 0; i < itemsList.toDoItems.Count; i++)//check if deadline passed
            {
                System.TimeSpan diff = DateTime.Now.Subtract(itemsList.toDoItems[i].dueDate);
                System.TimeSpan diff2 = current.Subtract(itemsList.toDoItems[i].dueDate);


                if ((itemsList.toDoItems[i].canShowMessage && itemsList.toDoItems[i].important) && (itemsList.toDoItems[i].hasDueDate && itemsList.toDoItems[i].isChecked == false && diff.Hours >= 0))
                {//if item is important and has a due date and item is Not checked and missed by 0 or more hours (more than 60 minutes since fail to complete)
                    if ((diff.Hours < 6 && diff.Hours >= 1) || (diff2.Hours < 6 && diff2.Hours >= 1))//missed within 1-6 hours
                        MessageBox.Show("You Missed: " + itemsList.toDoItems[i].title + " By " + diff.Hours + " Hours");
                    else if ((diff.Hours <= 0) || (diff2.Hours <= 0))// missed within the hour
                        MessageBox.Show("You Should do: " + itemsList.toDoItems[i].title);
                    else if ((diff.Hours >= 6) || (diff2.Hours >= 6))//missed over 6 hours ago
                        MessageBox.Show("You Forgot to do: " + itemsList.toDoItems[i].title + " Today!");
                    itemsList.toDoItems[i].canShowMessage = false;

                }


            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            checkNewDay();
            UC_Home uc = new UC_Home();
            AddUserControl(uc);

            btnUserAcc.FillColor = Color.FromArgb(120, 179, 84);
            panel1.BackColor = Color.FromArgb(120, 179, 84);





        }

        private void checkNewDay()
        {
            MongoCRUD db = database;
            var currRecord = db.LoadRecordById<User>(dbName, currId);



            if (!usingAdminTools)
            {
                current = DateTime.Now;

            }



            if (currRecord.appInfo.leftBefore)
            {
                DateTime temp = theCurrentDT();
                temp = temp.AddDays(0);
                currRecord.appInfo.UserleaveFormDate = temp;
                db.UpsertRecord(dbName, currId, currRecord);

            }
            

            DateTime leaveFormDate = currRecord.appInfo.UserleaveFormDate.Date;


            if (((enterFormDate.Month != leaveFormDate.Month) && currRecord.appInfo.leftBefore) || (enterFormDate.Month != current.Month))//new month
            {

                setNewMonth();

            }

            if (((enterFormDate.Date != leaveFormDate) && currRecord.appInfo.leftBefore) || (enterFormDate.Date != current.Date))//New day opening app
            {
                newDayCalorie();
                newDaySleep();
                newFitnessDay();
                enterFormDate = current;
                updateItemDetails();
                askTimeWoke();


            }

        }

        private void askTimeWoke()
        {
            if (!usingAdminTools)
            {
                addSleepItem formadd2 = new addSleepItem();
                formadd2.ShowDialog();
            }
        }


        private void setNewMonth()
        {

            int monthlyCals = 0;

            DateTime lastMonth = theCurrentDT();
            lastMonth = lastMonth.AddMonths(-1);


            for (int i = 0; i < itemsList.calListList.Count; i++)
            {
                for (int x = 0; x < itemsList.calListList[i].Count; x++)
                {



                    if (itemsList.calListList[i][x].itemDate.Month == lastMonth.Month)
                    {
                        monthlyCals = monthlyCals + itemsList.calListList[i][x].calories;

                    }


                }

            }



            CalorieItem monthCalItem = new CalorieItem(monthlyCals, "");
            monthCalItem.itemDate = lastMonth;
            if (monthlyCals == 0)
            {
                monthCalItem.isEmpty = true;

            }
            itemsList.CalsMonthly.Add(monthCalItem);





        }

        private void newDaySleep()
        {
            List<SleepItem> tempList = new List<SleepItem>(itemsList.SleepDailyList);
            itemsList.SleepDailyListList.Add(tempList);
            //
            itemsList.SleepDailyList.Clear();
            //
            if (itemsList.SleepDailyList.Count == 0)
            {
                //
                SleepItem sleep = new SleepItem();
                sleep.wokeUp = theCurrentDT();
                //
                sleep.isEmpty = true;
                //
                itemsList.SleepDailyList.Add(sleep);

            }
        }


        private void newDayCalorie()
        {
            List<CalorieItem> tempList = new List<CalorieItem>(itemsList.CaloriesDailyList);
            itemsList.calListList.Add(tempList);
            itemsList.CaloriesDailyList.Clear();
            if (itemsList.CaloriesDailyList.Count == 0)
            {
                CalorieItem food = new CalorieItem(0, "");
                food.isEmpty = true;
                itemsList.CaloriesDailyList.Add(food);
            }
        }

        private void newFitnessDay()
        {


            StartWorkout.completed = false;

            FitnessItem item = new FitnessItem();


            for (int i = 0; i < StartWorkout.workoutsToday.Count; i++)
            {
                item.workoutNamesToday.Add(StartWorkout.workoutsToday[i].title);

            }


            item.workoutTime = StartWorkout.workoutTimeToday;
            DateTime dt = theCurrentDT();
            dt = dt.AddDays(-1);
            item.itemDate = dt;

            itemsList.FitnessWorkoutTimes.Add(item);
            StartWorkout.workoutTimeToday = TimeSpan.Zero;
        }

        private void updateItemDetails()
        {
            for (int i = 0; i < itemsList.toDoItems.Count; ++i)
            {


                if (itemsList.toDoItems[i].canShowMessage == false) 
                {

                    itemsList.toDoItems[i].canShowMessage = true;

                }


                if (itemsList.toDoItems[i].isChecked)
                {


                    if (itemsList.toDoItems[i].repetitive == false)
                    {

                        itemsList.toDoItems[i].dateRecycled = theCurrentDT();



                        itemsList.toDoItems[i].isRecycled = true;
                        itemsList.toDoItemsDeleted.Add(itemsList.toDoItems[i]);
                        itemsList.toDoItems.Remove(itemsList.toDoItems[i]);

                    }


                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            btnUserAcc.FillColor = Items.itemToDo.color;
            panel1.BackColor = Items.itemToDo.color;

            checkNewDay();
            UC_ToDoList uc = new UC_ToDoList();
            AddUserControl(uc);

            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            checkNewDay();
            UC_Fitness uc = new UC_Fitness();
            AddUserControl(uc);


            btnUserAcc.FillColor = Items.FitnessItem.color;
            panel1.BackColor = Items.FitnessItem.color;



        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");


        }

        bool oneMessage = true;
        private void Form1_Load(object sender, EventArgs e)
        {

            if (loggedIn)
            {
                timer.Start();

                checkIfAdmin();

                MongoCRUD db = database;
                var currRecord = db.LoadRecordById<User>(dbName, currId);
                if (!currRecord.appInfo.leftBefore && oneMessage)
                {
                    askTimeWoke();
                }
                oneMessage = false;
            }
            else
            {
                this.Close();
            }




        }

        private void checkIfAdmin()
        {
            this.BeginInvoke((MethodInvoker)delegate {
                MongoCRUD db = database;
                var currRecord = db.LoadRecordById<User>(dbName, currId);
                if (currRecord.appInfo.Admin)
                {

                    btnAdminPanel.Visible = true;
                    button1.Visible = true;
                    button4.Visible = true;


                }
                else
                {

                    btnAdminPanel.Visible = false;
                    button1.Visible = false;
                    button4.Visible = false;
                }
            });
        }

        bool usingAdminTools = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //addTime("hour");
            addTime("minus");
        }

        public void addTime(string timeUnit)
        {
            UC_Home uc = new UC_Home();
            AddUserControl(uc);
            btnHome.PerformClick();

            usingAdminTools = true;
            checkNewDay();
            timer.Stop();
            fakeTime = true;


            switch (timeUnit)
            {
                case "hour":
                    current = current.AddHours(1);
                    break;
                case "day":
                    current = current.AddDays(1);
                    break;
                case "minus":
                    current = current.AddDays(-1);
                    break;
                default:
                    break;

            }

            curFakeTime = current;

            lblTime.Text = current.ToLongTimeString();
            lblDate.Text = current.ToString("MMM dd yyyy");
            lblDay.Text = current.ToString("dddd");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addTime("day");
        }
        private void Form1_Leave(object sender, EventArgs e)
        {


        }

        private void fillUserArrayDB() //leaving
        {
            MongoCRUD db = database;

            var currRecord = db.LoadRecordById<User>(dbName,currId);

            currRecord.listInfo.userToDoItems = itemsList.toDoItems;

            currRecord.listInfo.usertoDoItemsDeleted = itemsList.toDoItemsDeleted;


            currRecord.listInfo.userFitnessItems = itemsList.FitnessItems;

            currRecord.listInfo.userFitnessItemsDeleted = itemsList.FitnessItemsDeleted;

            currRecord.listInfo.FitnessWorkoutTimes = itemsList.FitnessWorkoutTimes;


            currRecord.listInfo.usercalListList = itemsList.calListList;

            currRecord.listInfo.userCaloriesDailyList = itemsList.CaloriesDailyList;

            currRecord.listInfo.userCalsMonthly = itemsList.CalsMonthly;


            currRecord.listInfo.userSleepDailyList = itemsList.SleepDailyList;

            currRecord.listInfo.userSleepDailyListList = itemsList.SleepDailyListList;

            db.UpsertRecord(dbName, currId, currRecord);



        }


        public static void fillAppArrayDB() //entering
        {



            MongoCRUD db = new MongoCRUD(dbName);
            var currRecord = db.LoadRecordById<User>(dbName, currId);

            if (currRecord.appInfo.leftBefore)
            {
                currRecord = db.LoadRecordById<User>(dbName, currId);

                itemsList.toDoItems = currRecord.listInfo.userToDoItems;
                itemsList.toDoItemsDeleted = currRecord.listInfo.usertoDoItemsDeleted;

                itemsList.FitnessItems = currRecord.listInfo.userFitnessItems;
                itemsList.FitnessItemsDeleted = currRecord.listInfo.userFitnessItemsDeleted;
                itemsList.FitnessWorkoutTimes = currRecord.listInfo.FitnessWorkoutTimes;


                itemsList.calListList = currRecord.listInfo.usercalListList;
                itemsList.CaloriesDailyList = currRecord.listInfo.userCaloriesDailyList;
                itemsList.CalsMonthly = currRecord.listInfo.userCalsMonthly;



                itemsList.SleepDailyList = currRecord.listInfo.userSleepDailyList;
                itemsList.SleepDailyListList = currRecord.listInfo.userSleepDailyListList;
            }




        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            checkNewDay();
            UC_Calories uc = new UC_Calories();
            AddUserControl(uc);


            btnUserAcc.FillColor = Items.CalorieItem.color;
            panel1.BackColor = Items.CalorieItem.color;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            checkNewDay();
            UC_Sleep uc = new UC_Sleep();
            AddUserControl(uc);


            btnUserAcc.FillColor = Items.SleepItem.color;
            panel1.BackColor = Items.SleepItem.color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addTime("month");
        }

        public static DateTime theCurrentDT()
        {
            if (fakeTime)
            {
                return curFakeTime;
            }
            else
            {
                return DateTime.Now;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            AppClosing();
            this.Close();
        }

        private void AppClosing()
        {
            bool save = true;
            if (usingAdminTools)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "You used admin tools to change date of application. Saving could result in data errors and inaccurate data. Save anyways? "
                    , "Save Changes?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    save = false;
                }
            }

            if (save)
            {
                MongoCRUD db = database;

                var currRecord = db.LoadRecordById<User>(dbName, currId);

                currRecord.appInfo.leftBefore = true;
                db.UpsertRecord(dbName, currId, currRecord);

                currRecord.appInfo.UserleaveFormDateString = theCurrentDT().ToString();
                db.UpsertRecord(dbName, currId, currRecord);




                DateTime myDate = DateTime.Parse(currRecord.appInfo.UserleaveFormDateString);

                currRecord.appInfo.UserleaveFormDate = myDate;
                db.UpsertRecord(dbName, currId, currRecord);

                fillUserArrayDB();

            }
            
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel();
            form.ShowDialog();
        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {

            checkNewDay();
            UC_UserAcc uc = new UC_UserAcc();
            AddUserControl(uc);


            btnUserAcc.FillColor = Color.FromArgb(120, 179, 84);
            panel1.BackColor = Color.FromArgb(120, 179, 84);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppClosing();
            Application.Restart();
            Environment.Exit(0);


        }
    }
}