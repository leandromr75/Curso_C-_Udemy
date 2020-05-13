using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Carro", 20);
            p.Descricao = "Ferrari";
            
            Console.WriteLine(p);
            Console.ReadKey();
        }
        
        
    }
}
