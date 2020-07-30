using System;
using FixacaoExcessoes.Entities;
using FixacaoExcessoes.Entities.Exceptions;

namespace FixacaoExcessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string nome = Console.ReadLine();
                Console.Write("Initial balance: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double saqueLimite = double.Parse(Console.ReadLine());

                Account conta = new Account(n, nome, saldo, saqueLimite);

                Console.Write("Enter amount for withdraw: ");
                double retirada = double.Parse(Console.ReadLine());
                conta.Withdraw(retirada);
                Console.WriteLine("New balance: " + conta.Balance);            
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
