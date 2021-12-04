using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    public class itemToDo : AppItem
    {
        public static Color color = Color.FromArgb(194, 194, 71);

        public bool isChecked = false;

        private static int ID = 0;
        private int myId = 0;


        public int MyId
        {
            get { return myId; }
        }


        public string description = "";
        public bool repetitive;
        public bool important;
        public int repeatDays;
        public bool canShowMessage = true;

        public itemToDo()
        {
            ID++;
            this.myId = ID;
        }

        public itemToDo(string name, string desc, bool imp, bool repeat)
        {
            this.title = name;

            ID++;
            this.myId = ID;

            this.repetitive = repeat;
            this.important = imp;
            isChecked = false;



        }


        public override string ToString()

        {
            if (hasDueDate && repetitive)
            {
                return string.Format(
                "{0}\n\n" +
                "Important? {1}\n" +
                "Repetitve? {2} every {3} days\n" +
                "Is Currently Checked? {4}\n" +
                "Day Created: {5}\n" +
                "Due Date: {6}\n\n" +
                "{7}"
                , this.title, important, repetitive, repeatDays ,isChecked, DateCreated, getDueDate(), description);
            }
            else if(!hasDueDate && !repetitive)
            {
                return string.Format(
                "{0}\n\n" +
                "Important? {1}\n" +
                "Repetitve? {2}\n" +
                "Is Currently Checked? {3}\n" +
                "Day Created: {4}\n" +
                "Doesn't have a due date\n\n" +
                "{5}"
                , this.title, important, repetitive, isChecked, DateCreated, description);
            }
            else if (!hasDueDate && repetitive)
            {
                return string.Format(
                "{0}\n\n" +
                "Important? {1}\n" +
                "Repetitve? {2} every {3} days\n" +
                "Is Currently Checked? {4}\n" +
                "Day Created: {5}\n" +
                "Doesn't have a due date\n\n" +
                "{6}"
                , this.title, important, repetitive, repeatDays, isChecked, DateCreated, description);
            }
            else //(hasDueDate && !repetitive)
            {
                return string.Format(
                "{0}\n\n" +
                "Important? {1}\n" +
                "Repetitve? {2}\n" +
                "Is Currently Checked? {3}\n" +
                "Day Created: {4}\n" +
                "Due Date: {5}\n\n" +
                "{6}"
                , this.title, important, repetitive, isChecked, DateCreated, getDueDate() , description);
            }



        }

    }
}
