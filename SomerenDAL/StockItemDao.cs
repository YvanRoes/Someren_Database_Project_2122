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
            string query = "SELECT Drink_ID, [Name], Price, Stock, Sold, Is_Alcoholic FROM DRINK ORDER BY Drink_ID";
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

        public void UpdateItem(int id,string nm, decimal pr, int alc)
        {   
            //making query and adding args
            string query = "UPDATE DRINK SET [Name] = @nm, Price = @pr, Is_Alcoholic = @alc WHERE Drink_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[4] { new SqlParameter("nm", nm) , new SqlParameter("pr", pr), new SqlParameter("alc", alc), new SqlParameter("id", id) };


            //exe query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddItem(int id, string nm, decimal pr, int alc, int st)
        {
            string query = "INSERT INTO DRINK VALUES( @nm ,@pr, @alc, @st, @so)";
            int so = 0;
            SqlParameter p1 = new SqlParameter("nm", nm);
            SqlParameter p2 = new SqlParameter("pr", pr);
            SqlParameter p3 = new SqlParameter("alc", alc);
            SqlParameter p4 = new SqlParameter("st", st);
            SqlParameter p5 = new SqlParameter("so", so);
            SqlParameter[] sqlParameters = new SqlParameter[5] { p1, p2, p3, p4, p5};

            //exe query
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DelItem(int id)
        {
            string query = "DELETE FROM DRINK WHERE Drink_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("id", id)};
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
