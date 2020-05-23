using System;
using System.Collections.Generic;
using System.Text;

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
            return base.Pricetag();
        }
    }
}
