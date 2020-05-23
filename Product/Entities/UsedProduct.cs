using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Product.Entities
{
    class UsedProduct : Product_
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name,double price, DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }
        public sealed override string Pricetag()
        {
            StringBuilder returnPriceTag = new StringBuilder();
            returnPriceTag.Append(Name + " (used) $ ");
            returnPriceTag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            returnPriceTag.Append(" (Manufacture date: ");
            returnPriceTag.Append(ManufactureDate.ToString("dd/MM/yyyy") + ")");
            return returnPriceTag.ToString();
        }
    }
}
