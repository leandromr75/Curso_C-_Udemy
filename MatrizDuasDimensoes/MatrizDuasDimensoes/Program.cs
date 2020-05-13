using System;
using System.Runtime.InteropServices;

namespace MatrizDuasDimensoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nº N de linhas e colunas:");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a primeira linha:");
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine("\n\n");
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                    Console.Write("    " + mat[i,j].ToString() + " ");
                }
                Console.Write("\n\n");
            }
            Console.WriteLine("Nºs negativos: " + count);

        }
    }
}
