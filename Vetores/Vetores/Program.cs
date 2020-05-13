using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] p = new Produto[3];
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produto { Nome = name, Preco = preco};
            }

            double sum = 0.0;
            for (int i = 0; i < 3; i++)
            {
                sum += p[i].Preco;
            }

            Console.WriteLine("Total: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
