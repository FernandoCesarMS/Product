using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Product.Entities
{
    class ImportedProduct : Product_
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string Pricetag()
        {
            StringBuilder returnPriceTag = new StringBuilder();
            returnPriceTag.Append(Name + " $ ");
            returnPriceTag.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            returnPriceTag.Append(" (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");
            return returnPriceTag.ToString();
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
