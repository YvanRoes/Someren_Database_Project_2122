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
    public class UserDao : BaseDao
    {
        public User GetRow(DataTable datatable)
        {
            DataRow dr = datatable.Rows[0];
            User u = new User();
            u.Id = (int)dr["User_ID"];
            u.email = (string)dr["username"];
            u.SecretQuestionId = (int)dr["Seq_Question"];
            u.SecretQuestionAnswer = (string)dr["Seq_Answer"];

            return u;
        }

        public User GetRecoveryPasswordUser(string username)
        {
            string query = "SELECT [User_ID], [Username], [Sec_Question], [Sec_Answer] FROM [USER] WHERE @uName = [Username]";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("Uname", username) };
            return GetRow(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
