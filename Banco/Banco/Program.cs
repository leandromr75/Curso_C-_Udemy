using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            Console.WriteLine("Entre com o nº da conta:");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular:");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? s/n");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine("Valor do depósito:");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c = new Conta(conta, nome, valor);
            }
            else
            {
                c = new Conta(conta, nome);
            }
            Console.WriteLine(c);

            Console.WriteLine("Entre com um valor para depósito:");
            c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c);
            Console.WriteLine("Entre com um valor para saque:");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
