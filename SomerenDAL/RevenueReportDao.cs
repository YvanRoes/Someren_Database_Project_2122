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
    public class RevenueReportDao : BaseDao
    {
        public RevenueReport GetRevenue(DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT COUNT(DRINK.Sold) as Sales, COUNT(Student_Id) * DRINK.Price as Turnover, COUNT(Student_Id) as [Number of customers] FROM BUY, DRINK WHERE BUY.Drink_Id = DRINK.Drink_Id GROUP BY DRINK.Price";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private RevenueReport ReadTable(DataTable dataTable)
        {
            RevenueReport revenueReport = new RevenueReport();
            DataRow dr = dataTable.Rows[0];
            if (dr["Sales"] == DBNull.Value)
                throw new Exception("No orders");

            revenueReport.Sales = (int)(dr["Sales"]);
            revenueReport.Turnover = (decimal)(dr["Turnover"]);
            revenueReport.NumberOfCustomers = (int)(dr["Number of customers"]);
            return revenueReport;
        }
    }
}
