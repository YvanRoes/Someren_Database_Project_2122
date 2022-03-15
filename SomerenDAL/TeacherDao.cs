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
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT Teacher_ID, name FROM TEACHER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Teacher teacher = new Teacher()
                    {
                        Number = (int)dr["Teacher_ID"],
                        Name = (string)(dr["name"].ToString())
                    };
                    teachers.Add(teacher);
                }
                return teachers;
            }
            catch (Exception ex)
            {
                throw new Exception("query column names do not correspond with the database column names");
                throw ex;
            }

        }
    }
}
