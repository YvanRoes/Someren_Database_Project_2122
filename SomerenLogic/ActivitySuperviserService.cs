using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;


namespace SomerenLogic
{
    public class ActivitySuperviserService
    {
        TeacherDao superviserdb;
        ActivitySuperviserDao activities;

        public ActivitySuperviserService()
        {
            superviserdb = new TeacherDao();
            activities = new ActivitySuperviserDao();
        }
        public List<Teacher> GetParticipants()
        {
            List<Teacher> supervisers = superviserdb.GetParticipants();
            return supervisers;
        }
        public List<Teacher> GetNonParticipants()
        {
            List<Teacher> supervisers = superviserdb.GetNonParticipants();
            return supervisers;
        }
        public List<ActivitySuperviser> GetActivities()
        {
            List<ActivitySuperviser> activitiesSuperviser = activities.GetAllActivities();
            return activitiesSuperviser;
        }
        public void AddSuperviserActivity(int s_id, int a_id)
        {
            superviserdb.AddSuperviserActivity(s_id, a_id);
        }
        public void RemoveSuperviserActivity(int s_id)
        {
            superviserdb.RemoveSuperviserActivity(s_id);
        }
    }
}
