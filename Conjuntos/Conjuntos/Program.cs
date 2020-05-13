using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("Digite o Nº de alunos do curso A:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Código curso A:");
                A.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Digite o Nº de alunos do curso B:");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Código curso B:");
                B.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Digite o Nº de alunos do curso C:");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Código curso C:");
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(A);
            novo.UnionWith(B);
            novo.UnionWith(C);

            Console.WriteLine("Total: " + novo.Count);

        }
    }
}
