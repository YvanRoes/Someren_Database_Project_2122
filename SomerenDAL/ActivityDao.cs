using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;


namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        //Adding an activity to the database
        public void AddActivity(Activity activity)
        {
            string query = "INSERT INTO [ACTIVITY] VALUES (@description,@startDateTime, @endDateTime)";
            SqlParameter[] sqlParameters = { new SqlParameter("@startDateTime", activity.StartDateTime), new SqlParameter("@endDateTime", activity.EndDateTime), new SqlParameter("@description", activity.ActivityDescription) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT Activity_ID, ActivityDescription, StartDateTime, EndDateTime FROM ACTIVITY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        //Deleting an activity from the database
        public void DeleteActivity(Activity activity)
        {
            string query = "DELETE FROM [ACTIVITY] WHERE Activity_ID = @id;";
            SqlParameter[] sqlParameters = { new SqlParameter("@id", activity.ActivityId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        //Editing an activity from the database
        public void UpdateActivity(Activity activity)
        {
            string query = $"UPDATE [ACTIVITY] SET ActivityDescription = @description, startDateTime = @startDateTime, endDateTime = @endDateTime WHERE Activity_ID = @ID";
            SqlParameter[] sqlParameters = { new SqlParameter("ID", activity.ActivityId), new SqlParameter("@startDateTime", activity.StartDateTime), new SqlParameter("@endDateTime", activity.EndDateTime), new SqlParameter("@description", activity.ActivityDescription) };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity();
                activity.ActivityId = (int)dr["Activity_ID"];
                activity.ActivityDescription = (string)(dr["ActivityDescription"].ToString());
                activity.StartDateTime = (DateTime)dr["StartDateTime"];
                activity.EndDateTime = (DateTime)dr["EndDateTime"];

                activities.Add(activity);
            }
            return activities;
        }
    }
}

