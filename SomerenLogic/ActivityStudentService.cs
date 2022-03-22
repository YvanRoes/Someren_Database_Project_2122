using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityStudentService
    {
        StudentDao studentdb;
        ActivityStudentDao activities;


        public ActivityStudentService()
        {
            studentdb = new StudentDao();
            activities = new ActivityStudentDao();
        }

        public List<Student> GetParticipants()
        {
            List<Student> students = studentdb.GetParticipants();
            return students;
        }


        public List<Student> GetNonParticipants()
        {
            List<Student> students = studentdb.GetNonParticipants();
            return students;
        }


        public List<ActivityStudent> GetActivities()
        {
            List<ActivityStudent> ac = activities.GetAllActivities();
            return ac;
        }

        public void AddStudentActivity(int s_id, int a_id)
        {
            studentdb.AddStudentActivity(s_id, a_id);
        }

        public void RemoveStudentActivity(int s_id)
        {
            studentdb.RemoveStudentActivity(s_id);
        }
    }
}
