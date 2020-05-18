using Exercício1_Composição_Objetos.Entities.Enums;
using Exercício1_Composição_Objetos.Entities;
using System.Collections.Generic;
using System;


namespace Exercício1_Composição_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dept = Console.ReadLine();
            
            Console.Write("Enter worker data: ");
            string nome = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            
        }
    }
}
