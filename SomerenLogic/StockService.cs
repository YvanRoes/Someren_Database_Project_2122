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

        public StockItem ItemById(int id)
        {
            List<StockItem> stock = stockdb.GetAllItems();
            StockItem item = stock[stock.FindIndex(x => x.Id == id)];
            return item;
        }

        public void UpdateItem(StockItem s)
        {         
            stockdb.UpdateItem(s.Id, s.Name, s.Price, s.Alcohol ? 1 : 0);
        }

        public void AddItem(StockItem s)
        {
            stockdb.AddItem(s.Id, s.Name, s.Price, s.Alcohol ? 1 : 0, s.Stock);
        }


        public void DelItem(StockItem s)
        {
            stockdb.DelItem(s.Id);
        }
    }
}
