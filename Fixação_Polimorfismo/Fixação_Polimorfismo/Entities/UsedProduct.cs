using System;
using System.Collections.Generic;
using System.Text;

namespace Fixação_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price) 
        {
            base.Name = name;
            base.Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(Name);
            sb1.Append(" (used) $ ");
            sb1.Append(Price);
            sb1.Append(" (Manufacture date: ");
            sb1.Append(ManufactureDate);
            return sb1.ToString();
        }
    }
}
