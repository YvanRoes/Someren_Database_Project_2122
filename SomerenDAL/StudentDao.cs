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
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
            string query = "SELECT Student_ID, name FROM STUDENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["Student_ID"],
                    Name = (string)(dr["name"].ToString()),                   
                };
                students.Add(student);
            }
            return students;
        }

        private List<Student> ReadTablesActivities(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["Student_ID"],
                    Name = (string)(dr["name"].ToString()),
                    Activity = (string)(dr["Activity"].ToString())
                };
                students.Add(student);
            }
            return students;
        }

        //Week 4
        public List<Student> GetParticipants()
        {
            string query = "SELECT STUDENT.Student_ID, [name] , ACTIVITY.ActivityDescription as Activity FROM STUDENT,ACTIVITY, ACTIVITYSTUDENT WHERE STUDENT.Student_ID = ACTIVITYSTUDENT.Student_ID AND ACTIVITY.Activity_ID = ACTIVITYSTUDENT.Activity_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTablesActivities(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Student> GetNonParticipants()
        {
            string query = "SELECT STUDENT.Student_ID, STUDENT.[name] FROM STUDENT LEFT JOIN ACTIVITYSTUDENT ON ACTIVITYSTUDENT.Student_ID = STUDENT.Student_ID WHERE ACTIVITYSTUDENT.Student_ID IS NULL";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        public void AddStudentActivity(int Student_id, int Activity_id)
        {
            string query = "INSERT INTO ACTIVITYSTUDENT VALUES(@Student_id, @Activity_id)";
            SqlParameter[] sqLParameters = new SqlParameter[2] { new SqlParameter("Student_Id", Student_id), new SqlParameter("Activity_id", Activity_id)};
            ExecuteEditQuery(query, sqLParameters);
        }


        public void RemoveStudentActivity(int Student_Id)
        {
            string query = "DELETE FROM ACTIVITYSTUDENT WHERE Student_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("id", Student_Id) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
