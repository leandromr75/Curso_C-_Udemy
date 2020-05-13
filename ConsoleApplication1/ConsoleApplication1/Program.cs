using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            int a;
            int b;
            int c;

            Console.WriteLine("Digite o valor de a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de b : ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de c : ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            //********************************************************

            double delta = (Math.Pow(b, 2)) - (4 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / ((double)2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / ((double)2 * a);

            //********************************************************
            
            Console.WriteLine("Calculando x1:");
            Console.WriteLine("Delta = (b . b) - (4 . a . c)");
            Console.WriteLine("Delta = " + delta);
            Console.WriteLine("Aplicando a fórmula:");
            Console.WriteLine("(x1 = -b + sqrt(Delta)) / (2 . a)" + "\n");
            Console.WriteLine(-b + Math.Sqrt(delta));
            Console.WriteLine("---");
            Console.WriteLine((double)2 * a + "\n");            
            Console.WriteLine("O valor de x1 é: " + x1 + "\n");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Calculando x2:");
            Console.WriteLine("Delta = (b . b) - (4 . a . c)");
            Console.WriteLine("Delta = " + delta);
            //Console.WriteLine("-----------------------------------");
            Console.WriteLine("Aplicando a fórmula:");
            Console.WriteLine("(x1 = -b - sqrt(Delta)) / (2 . a)" + "\n");
            Console.WriteLine(-b - Math.Sqrt(delta));
            Console.WriteLine("---");
            Console.WriteLine((double)2 * a + "\n");   
            Console.WriteLine("O valor de x2 é: " + x2);

            Console.ReadKey();
        }
    }
}
