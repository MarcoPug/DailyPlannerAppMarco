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

            for (int i = 0; i < itemsList.SleepDailyList.Count; i++)
            {
                //MessageBox.Show("time: "+itemsList.SleepDailyList[i].wokeUpTime);
            }

            addColor();
        }
        private void addColor()
        {
            panel.FillColor = Color.FromKnownColor(KnownColor.Control);
            panel.FillColor2 = Items.SleepItem.color;

            shape.FillColor = ControlPaint.Light(Items.SleepItem.color);
            shape.BorderColor = ControlPaint.Dark(Items.SleepItem.color);
            //btnDown.FillColor = Items.CalorieItem.color;
            //btnUp.FillColor = Items.CalorieItem.color;

            btnPrev.FillColor = Items.SleepItem.color;

            //btnUp.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            //btnHistory.FillColor = Items.itemToDo.color;

            //btnEdit.FillColor = Items.itemToDo.color;

            //listBox.ForeColor = Items.itemToDo.color;

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
    }
}
