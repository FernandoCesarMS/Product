using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Entities
{
    class Product_
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product_()
        {
        }

        public Product_(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Pricetag()
        {
            return " ";
        }
    }
}
