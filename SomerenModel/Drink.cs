using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Number { get; set; } // Drink ID, e.g. 9
        public string Name { get; set; } // Name of drink, e.g. Coca Cola, Heineken
        public bool Type { get; set; } // non alc = false, alc = true
        public decimal Price { get; set; } // price
        public int Stock { get; set; } // amount of this drink in stock
    }
}