using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class BuyService
    {
        BuyDao buydb = new BuyDao();

        public void AddNewOrder(Buy order) 
        {
            buydb.AddNewOrder(order);
        }
        public void DecreaseStock(int drinkId) 
        {
            buydb.DecreaseStock(drinkId);
        }
    }
}
