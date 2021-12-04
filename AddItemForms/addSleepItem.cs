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

namespace DailyPlannerAppMarco.AddItemForms
{
    public partial class addSleepItem : Form
    {
        public addSleepItem()
        {
            InitializeComponent();

            lblWelcome.Text = "Good Morning!\nWhen did you wake up this morning?";

            setDefaultTime();


        }

       

        private void TryAddSleepItem()
        {
            SleepItem item = new SleepItem();
            addDate(item);
            itemsList.SleepDailyList.Add(item);
            this.Close();
        }

        private void addDate(SleepItem item)
        {
            var dateNow = DateTime.Now;
            DateTime date;

            int index = cbTimeDays.SelectedIndex;

            int pm = cbAMPM.SelectedIndex;

            if (pm == 1)
            {
                index = index + 12;
            }
            if (index == 11 || index == 23)
            {
                index = index - 12;

            }


            if (Form1.fakeTime)
            {
                date = new DateTime(Form1.curFakeTime.Year, Form1.curFakeTime.Month, Form1.curFakeTime.Day, index + 1, 0, 0);
            }
            else
            {
                date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, index + 1, 0, 0);
            }



            item.wokeUp = date;
            item.wokeUpTime = date.ToString("h:mm:ss tt");


        }

        private void setDefaultTime()
        {
            if (Form1.fakeTime)
            {

                if (Form1.curFakeTime.ToString("tt").Contains("AM"))
                {
                    cbAMPM.SelectedIndex = 0;
                }
                else if (Form1.curFakeTime.ToString("tt").Contains("PM"))
                {
                    cbAMPM.SelectedIndex = 1;
                }


                setWeekday(Form1.curFakeTime);

            }
            else
            {
                if (DateTime.Now.ToString("tt").Contains("AM"))
                {
                    cbAMPM.SelectedIndex = 0;
                }
                else if (DateTime.Now.ToString("tt").Contains("PM"))
                {
                    cbAMPM.SelectedIndex = 1;
                }

                setWeekday(DateTime.Now);

            }


        }

        private void setWeekday(DateTime dt)
        {

            if (dt.ToString("hh").Contains("01"))
                cbTimeDays.SelectedIndex = 0;
            if (dt.ToString("hh").Contains("02"))
                cbTimeDays.SelectedIndex = 1;
            if (dt.ToString("hh").Contains("03"))
                cbTimeDays.SelectedIndex = 2;
            if (dt.ToString("hh").Contains("04"))
                cbTimeDays.SelectedIndex = 3;
            if (dt.ToString("hh").Contains("05"))
                cbTimeDays.SelectedIndex = 4;
            if (dt.ToString("hh").Contains("06"))
                cbTimeDays.SelectedIndex = 5;
            if (dt.ToString("hh").Contains("07"))
                cbTimeDays.SelectedIndex = 6;
            if (dt.ToString("hh").Contains("08"))
                cbTimeDays.SelectedIndex = 7;
            if (dt.ToString("hh").Contains("09"))
                cbTimeDays.SelectedIndex = 8;
            if (dt.ToString("hh").Contains("10"))
                cbTimeDays.SelectedIndex = 9;
            if (dt.ToString("hh").Contains("11"))
                cbTimeDays.SelectedIndex = 10;
            if (dt.ToString("hh").Contains("12"))
                cbTimeDays.SelectedIndex = 11;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTimeDays.SelectedItem == null || cbAMPM.SelectedItem == null)
            {
                MessageBox.Show("Please dont leave information blank");

            }
            else if (itemsList.SleepDailyList.Any())
            {
                if (!itemsList.SleepDailyList[0].isEmpty)
                {
                    DialogResult dialogResult = MessageBox.Show("You already put a time waking up today. Overwrite?", "Overwrite time", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        itemsList.SleepDailyList.RemoveAt(0);
                        TryAddSleepItem();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else if (itemsList.SleepDailyList[0].isEmpty)
                {
                    itemsList.SleepDailyList.RemoveAt(0);
                    TryAddSleepItem();
                }



            }
            else
            {
                TryAddSleepItem();
            }

        }

        private void addSleepItem_Load(object sender, EventArgs e)
        {

            btnAdd.FillColor = Items.SleepItem.color;
            cbTimeDays.BorderColor = Items.SleepItem.color;
            cbAMPM.BorderColor = Items.SleepItem.color;



            cbTimeDays.BackColor = Items.SleepItem.color;
            cbAMPM.BackColor = ControlPaint.Light(Items.SleepItem.color);
            btnAdd.BackColor = ControlPaint.Light(Items.SleepItem.color);
            btnAdd.BorderColor = ControlPaint.Dark(Items.SleepItem.color);
            lblWelcome.BackColor = ControlPaint.Light(Items.SleepItem.color);


            shape.FillColor = ControlPaint.Light(Items.SleepItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.SleepItem.color);

        }
    }

    
}
