using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> l1 = new List<Empregados>();

            Console.WriteLine("Quantos cadastros?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNome do funcionário:");
                string nome = Console.ReadLine();
                Console.WriteLine("\nSalário:");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                l1.Add(new Empregados(id, nome, sal));
                
            }

            foreach (var item in l1)
            {
                Console.WriteLine("\n\n" + item.ToString());
            }

            Console.WriteLine("\n\nDigite o nº do Id desejado para aumento do salário");
            int idCheck = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigito o percentual do aumento:");
            double percentual = double.Parse(Console.ReadLine());

            Empregados emp = l1.Find(x => x.Id == idCheck);
            if (emp != null)
            {
                emp.Aumento(percentual);
                
            }

            foreach (var item in l1)
            {
                Console.WriteLine("\n\n" + item.ToString());
            }
        }
    }
}
