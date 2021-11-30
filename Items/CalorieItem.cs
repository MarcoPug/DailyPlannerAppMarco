using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    public class CalorieItem : AppItem
    {
        public static Color color = Color.FromArgb(179, 133, 86);

        public DateTime itemDate { get; set; }
        public int calories { get; set; }

        public bool isEmpty = false;

        public CalorieItem(int cals, string name)
        {
            this.calories = cals;
            this.title = name;
            
            
            
            if (Form1.fakeTime)
                this.itemDate = Form1.curFakeTime;
            else
                this.itemDate = DateTime.Now;


        }


    }
}
