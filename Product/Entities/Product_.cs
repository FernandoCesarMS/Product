using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;

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
            StringBuilder returnPriceTag = new StringBuilder();
            returnPriceTag.Append(Name + " $ ");
            returnPriceTag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            return returnPriceTag.ToString();
        }
    }
}
