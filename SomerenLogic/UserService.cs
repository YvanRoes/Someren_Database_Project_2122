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
    class UserService
    {
        UserDao userdb;
        public UserService()
        {
            userdb = new UserDao();
        }

        public User GetRecorveryPasswordUser(string username)
        {
            User u = new User();
            return userdb.GetRecoveryPasswordUser(username);
        }
    }
}
