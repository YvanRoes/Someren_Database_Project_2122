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
            u.SecretQuestionId = (int)dr["Sec_Question"];
            u.SecretQuestionAnswer = (string)dr["Sec_Answer"];

            return u;
        }
        public void AddUser(User user)
        {
            SqlParameter[] sqlParameters =
            {
               new SqlParameter("@name",   user.Name),
               new SqlParameter("@username",    user.email),
               new SqlParameter("@password",    User.PasswordTosha256(user.password)),
            };
            string query = $"INSERT INTO [USER]([Name], [Role], [Username], [Password]) " +
                            $"VALUES( @name, 0, @username, @password);";
            ExecuteEditQuery(query, sqlParameters);
        }

        //Password recovery
        public User GetRecoveryPasswordUser(string username)
        {
            string query = "SELECT [User_ID], [Username], [Sec_Question], [Sec_Answer] FROM [USER] WHERE @uName = [Username]";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("Uname", username) };
            return GetRow(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateUserPassword(string password, string username)
        {
            string query = "UPDATE [USER] SET [Password] = @p WHERE [Username] = @u";
            SqlParameter[] sqlParameters = new SqlParameter[2] { new SqlParameter("p", password), new SqlParameter("u", username) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateUserQnA(int question_id, string answer, string username)
        {
            string query = "UPDATE [USER] SET [Sec_Question] = @q, [Sec_Answer] = @a WHERE [Username] = @u";
            SqlParameter[] sqlParameters = new SqlParameter[3] { new SqlParameter("q", question_id), new SqlParameter("a", answer), new SqlParameter("u", username) };
            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
