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

            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Student student = new Student()
                    {
                        Number = (int)dr["Student_ID"],
                        Name = (string)(dr["name"].ToString())
                    };
                    students.Add(student);
                }
                return students;
            }
            catch (Exception ex)
            {
                throw new Exception("query column names do not correspond with the database column names");
                throw ex;
            }
            
        }
    }
}
