using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Buy
    {
        public int BuyId { get; set; } // order id, e.g. 1, 2, 3 ...
        public int PurchaserId { get; set; } // id of student who purchased, e.g. 474791
        public int DrinkId { get; set; } // Drink ID, e.g. 9
        public DateTime PurchaseTime { get; set; } // Time of purchase, e.g. 01/08/2003
    }
}
