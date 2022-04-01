using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class ActivityService
    {
        private ActivityDao activityDao;

        public ActivityService()
        {
            activityDao = new ActivityDao();
        }
        public List<Activity> GetAllActivities() => activityDao.GetAllActivities();
        public void AddActivity(Activity activity) => activityDao.AddActivity(activity);
        public void DeleteActivity(Activity activity) => activityDao.DeleteActivity(activity);
        public void UpdateActivity(Activity activity) => activityDao.UpdateActivity(activity);




    }
}
