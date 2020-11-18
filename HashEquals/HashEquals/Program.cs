using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashEquals.Entities;

namespace HashEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900));
            a.Add(new Product("Notebook", 1200));

            Product b = new Product("Notebook", 1200);

            Console.WriteLine(a.Contains(b));
            Console.ReadKey();
        }
    }
}
