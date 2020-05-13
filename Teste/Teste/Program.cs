using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 49.0;

            valor = (valor < 50.0) ? valor * 0.8 : valor * 0.9;

            Console.WriteLine(valor);
        }
    }
}
