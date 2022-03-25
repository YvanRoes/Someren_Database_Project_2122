using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();
            
                foreach (DataRow dr in dataTable.Rows)
                {
                    Teacher teacher = new Teacher();
                    teacher.Number = (int)dr["Teacher_ID"];
                    teacher.Name = (string)(dr["name"].ToString());
                    teachers.Add(teacher);
                }
                return teachers;
        }
        private List<Teacher> ReadTablesActivities(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher();
                teacher.Number = (int)dr["Teacher_ID"];
                teacher.Name = (string)(dr["name"].ToString());
                teacher.Activity = (string)(dr["Activity"].ToString());
                teachers.Add(teacher);
            }
            return teachers;
        }
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT Teacher_ID, name FROM TEACHER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetParticipants()
        {
            string query = "SELECT TEACHER.Teacher_ID, [name] , ACTIVITY.ActivityDescription as Activity FROM TEACHER, ACTIVITY, ACTIVITYSUPERVISER WHERE TEACHER.Teacher_ID = ACTIVITYSUPERVISER.Lecturer_ID AND ACTIVITY.Activity_ID = ACTIVITYSUPERVISER.Activity_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesActivities(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetNonParticipants()
        {
            string query = "SELECT TEACHER.Teacher_ID, TEACHER.[name] FROM TEACHER LEFT JOIN ACTIVITYSUPERVISER ON ACTIVITYSUPERVISER.Teacher_ID = TEACHER.Lecturer_ID WHERE ACTIVITYSUPERVISER.Lecturer_ID IS NULL";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddSuperviserActivity(int Superviser_Id, int Activity_id)
        {
            string query = "INSERT INTO ACTIVITYSUPERVISER VALUES(@Teacher_id, @Activity_id)";
            SqlParameter[] sqLParameters = new SqlParameter[2] { new SqlParameter("Teacher_Id", Superviser_Id), new SqlParameter("Activity_id", Activity_id) };
            ExecuteEditQuery(query, sqLParameters);
        }
        public void RemoveSuperviserActivity(int Superviser_Id)
        {
            string query = "DELETE FROM ACTIVITYSUPERVISER WHERE Lecturer_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("id", Superviser_Id) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
