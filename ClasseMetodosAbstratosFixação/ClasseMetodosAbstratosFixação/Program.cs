using System;
using System.Collections.Generic;
using ClasseMetodosAbstratosFixação.Entities;

namespace ClasseMetodosAbstratosFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            Console.Write("Enter the numbers of tax payers: ");
            int numPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i / c)? ");
                char op = char.Parse(Console.ReadLine());
                if (op == 'i')
                {
                    Console.Write("Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double inc = double.Parse(Console.ReadLine());
                    Console.Write("Health expendidures: ");
                    double heal = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(n, inc, heal));
                }
                if (op == 'c')
                {
                    Console.Write("Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double inc = double.Parse(Console.ReadLine());
                    Console.Write("Numbers of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(n, inc, emp));
                }
            }

            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p.Name + ": $ " + p.Tax().ToString());
                sum += p.Tax();
            }
            Console.WriteLine("Total Taxes: $ " + sum);
        }
    }
}
