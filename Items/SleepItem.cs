using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    public class SleepItem : AppItem
    {
        public static Color color = Color.FromArgb(86, 109, 179);

        public bool isEmpty = false;

        public DateTime wokeUp { get; set; }

        public string wokeUpTime { get; set; }

        public SleepItem()
        {


            

               
        }
    
    }
}
