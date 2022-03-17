using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class StockService
    {
        StockItemDao stockdb;
        public StockService()
        {
            stockdb = new StockItemDao();
        }

        public List<StockItem> GetItems()
        {
            List<StockItem> stock = stockdb.GetAllItems();
            return stock;
        }
    }
}
