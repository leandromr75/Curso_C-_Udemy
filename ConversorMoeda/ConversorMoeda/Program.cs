using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotação: ");
            double cot = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            double qt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Total: R$ " + ConversorMoeda.Calculo(cot, qt),CultureInfo.InvariantCulture);
            Console.ReadKey();
        }
    }
}
