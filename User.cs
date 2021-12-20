using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyPlannerAppMarco.Items;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DailyPlannerAppMarco
{
    [Serializable]
    public class User
    {
        [BsonId] // _id
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public userListInfo listInfo { get; set; }
        public userAppInfo appInfo { get; set; }
        public userBMRinfo bmrInfo { get; set; }

    }

    public class userBMRinfo
    {
        public int calorieGoal { get; set; }
        public int Weight { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int TypeCB { get; set; }
        public int WorkoutCB { get; set; }
    }

    public class userAppInfo
    {
        public bool leftBefore { get; set; }
        public DateTime UserleaveFormDate { get; set; }
        public string UserleaveFormDateString { get; set; }
        public bool Admin { get; set; }
    }

    public class userListInfo
    {
        public List<itemToDo> userToDoItems { get; set; }
        public List<itemToDo> usertoDoItemsDeleted { get; set; }
        //
        public List<FitnessItem> userFitnessItems { get; set; }
        public List<FitnessItem> userFitnessItemsDeleted { get; set; }
        public List<FitnessItem> FitnessWorkoutTimes { get; set; }
        public string[] userWorkoutNames { get; set; }
        //
        public List<List<CalorieItem>> usercalListList { get; set; }
        public List<CalorieItem> userCaloriesDailyList { get; set; }
        public List<CalorieItem> userCalsMonthly { get; set; }
        //
        public List<SleepItem> userSleepDailyList { get; set; }
        public List<List<SleepItem>> userSleepDailyListList { get; set; }
    }
}
