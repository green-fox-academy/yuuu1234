using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndTuple
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Product(string name, double price, double discount)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }
        public (string, double, double) GetDiscount()
        {
            return (this.Name, this.Price, (1-this.Discount/100) * this.Price);
        }
    }
}
