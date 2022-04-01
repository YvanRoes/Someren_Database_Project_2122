using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;
        public UserService()
        {
            userdb = new UserDao();
        }
        //add user to database
        public void AddUser(User user)
        {
            userdb = new UserDao();
            userdb.AddUser(user);
        }

        //get user
        public User GetRecorveryPasswordUser(string username)
        {
            User u = new User();
            return userdb.GetRecoveryPasswordUser(username);
        }
        //update password
        public void UpdateUserPassword(string password, string username)
        {
            userdb.UpdateUserPassword(password, username);
        }

        //update QnA
        public void UpdateUserQnA(int question_id, string answer, string username)
        {
            userdb.UpdateUserQnA(question_id, answer, username);
        }
    }
}
