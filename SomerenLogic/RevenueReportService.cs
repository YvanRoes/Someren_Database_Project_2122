using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class RevenueReportService
    {
        RevenueReportDao revenueReportdb;

        public RevenueReportService()
        {
            revenueReportdb = new RevenueReportDao();
        }

        public RevenueReport GetRevenueReport(DateTime startDate, DateTime endDate)
        {
            return revenueReportdb.GetRevenue(startDate, endDate);
        }
    }
}

