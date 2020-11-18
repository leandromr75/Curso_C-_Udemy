using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Leandro Mendonça Ribeiro";
            Console.WriteLine(Cut.Cortar(s1, 25));
            Console.ReadKey();
        }
    }
}
