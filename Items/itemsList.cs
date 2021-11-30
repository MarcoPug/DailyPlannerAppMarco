using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerAppMarco.Items
{
    static public class itemsList
    {
        static public List<itemToDo> toDoItems = new List<itemToDo>();
        static public List<itemToDo> toDoItemsDeleted = new List<itemToDo>();

        static public List<FitnessItem> FitnessItems = new List<FitnessItem>();
        static public List<FitnessItem> FitnessItemsDeleted = new List<FitnessItem>();
        static public List<FitnessItem> FitnessWorkoutTimes = new List<FitnessItem>();

        public static List<List<CalorieItem>> calListList = new List<List<CalorieItem>>();
        public static List<CalorieItem> CaloriesDailyList = new List<CalorieItem>();
        public static List<CalorieItem> CalsMonthly = new List<CalorieItem>();

        static public List<SleepItem> SleepDailyList = new List<SleepItem>();
        public static List<List<SleepItem>> SleepDailyListList = new List<List<SleepItem>>();
    }

}
