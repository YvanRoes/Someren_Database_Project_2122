using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class ActivitySuperviserDao : BaseDao
    {
        public List<ActivitySuperviser> GetAllActivities()
        {
            string query = "SELECT Activity_ID, ActivityDescription FROM ACTIVITY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ActivitySuperviser> ReadTables(DataTable dataTable)
        {
            List<ActivitySuperviser> activities = new List<ActivitySuperviser>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivitySuperviser activity = new ActivitySuperviser();
                activity.ActivityId = (int)dr["Activity_ID"];
                activity.ActivityDescription = (string)(dr["ActivityDescription"].ToString());
                
                activities.Add(activity);
            }
            return activities;

        }
    }
}
