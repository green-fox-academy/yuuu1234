using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndTuple
{
    class Order
    {
        public string Name { get; set; }
        public int OrderdTimes { get; set; }
        private double Price { get; set; }

        public Dictionary<string,double> NamePrice { get; set; }
        public Order()
        {
            this.NamePrice.Add(this.Name,this.Price);
        }
    }
}
