using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashEquals.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public int Price { get; set; }

        
        public Product (string name, int price){
            Nome = name;
            Price = price;
        }



        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;
            return Nome.Equals(other.Nome) && Price.Equals(other.Price);

        }
    }
}
