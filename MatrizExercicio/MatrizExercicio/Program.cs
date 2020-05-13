using System;

namespace MatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite nº linhas e nº colunas(separado por espaço)");
            string[] n = Console.ReadLine().Split(' ');
            int linhas = int.Parse(n[0]);
            int colunas = int.Parse(n[1]);
            
            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Entre com o valor para: " + "[" + i + ", " + j + "] :");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\n\n");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("  " + mat[i,j].ToString());
                   
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Digite um valor da matriz");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Posição encontrada: " + "[" + i + ", " + j + "]");
                        if (i > 0 )
                        {
                            Console.WriteLine("Valor acima: " + mat[i -1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Valor à esquerda: " + mat[i, j - 1]);
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Valor à direita: " + mat[i, j + 1]);
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine("Valor abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine("\n\n");
                    }
                }
            }
        }
    }
}
