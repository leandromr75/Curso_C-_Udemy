using System;
using System.Collections.Generic;
using System.Text;

namespace Fixação_Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            base.Name = name;
            base.Price = price;
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(Name);
            sb1.Append(" $ ");
            sb1.Append(Price + CustomsFee);
            sb1.Append(" (Customs fee: $ ");
            sb1.Append(CustomsFee);
            sb1.Append(")");
            return sb1.ToString();
        }
    }
}
