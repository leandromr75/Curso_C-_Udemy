using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comparison.Entities;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Celular", 700));
            list.Add(new Product("Videogame", 1700));
            list.Add(new Product("TV", 1900));
            list.Add(new Product("Abajur", 190));

            //ordenando a lista com sort + expressão lambda
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()) );

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();

        }
    }
}
