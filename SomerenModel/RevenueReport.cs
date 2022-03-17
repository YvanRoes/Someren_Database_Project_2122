using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    class RevenueReport
    {
        public int sales; // total number of drinks sold - COUNT(BUY.PurchaseDateTime)
        public int turnover; // sales * sales price of those drinks - DRINK.Sold * DRINK.Price FROM DRINK, BUY WHERE BUY.Drink_Name = DRINK.[Name]
        public int numberOfCustomers; // students who purchased at least one drink
        //  @start < BUY.PurchaseDateTime AND @end > BUY.PurchaseDateTime
    }
}
