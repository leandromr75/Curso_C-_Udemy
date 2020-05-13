using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com nome completo, nº quartos, preço, "  
            + "e na mesma linha (último nome, idade, altura) ");

            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] tudo = Console.ReadLine().Split(' ');
            string ultimo = tudo[0];
            int idade = int.Parse(tudo[1]);
            double altura = double.Parse(tudo[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
