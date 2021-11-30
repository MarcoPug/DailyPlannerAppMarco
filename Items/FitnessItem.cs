using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    public class FitnessItem : AppItem
    {
        public static Color color = Color.FromArgb(179, 86, 86);

        public static bool addWorkouts = true;

        public int[] workouts = new int[] { };

        public static string[] workoutDayNames = new string[7];

        public static string[] weekdayNames = new string[7] { "Sunday" , "Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public string dayofweek { get; set; }

        public int sets, reps = 0;

        public List<string> workoutNamesToday = new List<string>();

        public DateTime itemDate { get; set; }
        public TimeSpan workoutTime { get; set; }// NEW

        public FitnessItem()
        {


            if (Form1.fakeTime)
                this.itemDate = Form1.curFakeTime;
            else
                this.itemDate = DateTime.Now;


        }
        public override string ToString()
        {
            return string.Format(
                "name: {0}\n\n" +
                "On {1}\n" +
                "{2} Day\n\n" +
                "{3} Sets\n{4} Reps"
                , this.title, this.dayofweek, this.group, this.sets, this.reps);
        }
    }
}
