using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT Drink_ID, Name, Is_Alcoholic, Price, Stock FROM DRINK";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink d = new Drink()
                {
                    Number = (int)dr["Drink_ID"],
                    Name = (string)dr["Name"],
                    Type = (bool)dr["Is_Alcoholic"],
                    Price = (decimal)dr["Price"],
                    Stock = (int)dr["Stock"],
                };
                drinks.Add(d);
            }
            return drinks;
        }
    }
}