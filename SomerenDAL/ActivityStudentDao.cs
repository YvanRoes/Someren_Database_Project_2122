using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityStudentDao : BaseDao
    {

        public List<ActivityStudent> GetAllActivities()
        {
            string query = "SELECT Activity_ID, ActivityDescription FROM ACTIVITY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ActivityStudent> ReadTables(DataTable dataTable)
        {
            List<ActivityStudent> activities = new List<ActivityStudent>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivityStudent a = new ActivityStudent()
                {
                    Activity_ID = (int)dr["Activity_ID"],
                    Activity_Description = (string)(dr["ActivityDescription"].ToString())
                };
                activities.Add(a);
            }
            return activities;

        }
    }
}
