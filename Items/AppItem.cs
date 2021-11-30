using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    public class AppItem
    {
        public DateTime dueDate;

        public string getDueDate()
        {
            return dueDate.ToString("h:mm tt");

        }
        public DateTime DateCreated
        {
            get
            {
                if (!Form1.fakeTime)
                {
                    return this.dateCreated.HasValue
                    ? this.dateCreated.Value
                    : DateTime.Now;
                }
                else
                {
                    return this.dateCreated.HasValue
                  ? this.dateCreated.Value
                  : Form1.curFakeTime;
                }

            }

            set { this.dateCreated = value; }
        }

        private DateTime? dateCreated = null;

        public DateTime dateRecycled;
        public bool isRecycled;

        public string title { get; set; }
        public bool hasDueDate;
        public string group = "";
    }
}
