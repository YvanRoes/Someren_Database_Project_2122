using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class RevenueReport
    {
        public int Sales { get; set; } // total number of drinks sold
        public decimal Turnover { get; set; } // sales * price of those drinks
        public int NumberOfCustomers { get; set; } // students who purchased at least one drink
    }
}
