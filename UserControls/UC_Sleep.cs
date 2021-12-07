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
    public partial class UC_Sleep : UserControl
    {

        BindingSource bs = new BindingSource();
        public UC_Sleep()
        {
            InitializeComponent();

            bs.DataSource = itemsList.SleepDailyList;


            listBox.DataSource = bs;

            listBox.DisplayMember = "wokeUpTime" ;


            bs.ResetBindings(false);

            listBox.ClearSelected();

            SetNotifications();

            addColor();
        }
        private void addColor()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Items.SleepItem.color;

            shape.FillColor = ControlPaint.Light(Items.SleepItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.SleepItem.color);


            btnPrev.FillColor = Items.SleepItem.color;



        }


        private void UC_Sleep_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addSleepItem formadd = new addSleepItem();
            formadd.ShowDialog();




            bs.ResetBindings(false);

            listBox.ClearSelected();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SleepPrev formadd = new SleepPrev();
            formadd.ShowDialog();


            bs.ResetBindings(false);

            listBox.ClearSelected();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (itemsList.SleepDailyList.Any())
            {
                if (!itemsList.SleepDailyList[0].isEmpty)
                {
                    itemsList.SleepDailyList.RemoveAt(0);
                }
                bs.ResetBindings(false);

                listBox.ClearSelected();
            }

        }


        private void SetNotifications()
        {
            for (int i = 0; i < itemsList.toDoItems.Count; i++)//check if deadline passed
            {

                if (itemsList.toDoItems[i].hasDueDate)
                {

                    TimeSpan diff = Form1.theCurrentDT() - itemsList.toDoItems[i].dueDate;
                    double hours = diff.TotalHours;
                    int hoursAway = 24 - (int)hours;
                    if (hoursAway <= 7 && hoursAway > 0)
                    {
                        lbNotifications.Items.Add(itemsList.toDoItems[i].title + " Is in " + hoursAway + " hours!");
                    }


                }
            }
            if (lbNotifications.Items.Count == 0)
            {
                lbNotifications.Visible = false;
            }
        }
    }
}
