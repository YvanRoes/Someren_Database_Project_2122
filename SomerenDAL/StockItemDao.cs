using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class StockItemDao : BaseDao
    {
        public List<StockItem> GetAllItems()
        {
            string query = "SELECT Drink_ID, [Name], Price, Stock, Sold, Is_Alcoholic FROM DRINK";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<StockItem> ReadTables(DataTable dataTable)
        {
            List<StockItem> Stock = new List<StockItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                StockItem item = new StockItem()
                {
                    Id = (int)dr["Drink_ID"],
                    Name = (string)(dr["Name"]),
                    Price = (decimal)(dr["Price"]),
                    Stock = (int)(dr["Stock"]),
                    Sold = (int)(dr["Sold"]),
                    Alcohol = (bool)(dr["Is_Alcoholic"])
                };
                Stock.Add(item);
            }
            return Stock;

        }
    }
}
