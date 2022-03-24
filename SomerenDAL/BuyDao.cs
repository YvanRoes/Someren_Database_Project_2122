using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class BuyDao : BaseDao
    {
        public void AddNewOrder(Buy order) 
        {
            SqlParameter[] sqlParameters = { new SqlParameter("@buyerid", order.PurchaserId), new SqlParameter("@drinkid", order.DrinkId), new SqlParameter("@orderdate", order.PurchaseTime) };
            string query = $"INSERT INTO [BUY](Student_Id, Drink_Id, PurchaseDateTime) VALUES(@buyerid, @drinkid, @orderdate);";
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DecreaseStock(int drinkId) 
        {
            SqlParameter[] sqlParameters = { new SqlParameter("@drinkid", drinkId) };
            string query = $"UPDATE [DRINK] SET stock = stock - 1 WHERE Drink_Id = @drinkid";
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
