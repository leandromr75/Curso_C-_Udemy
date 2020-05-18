using Exercicio_composicao_netcore.Entities;
using Exercicio_composicao_netcore.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio_composicao_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salario_base = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            Department dep = new Department(dept);
            Worker wk = new Worker(nome, salario_base, level, dep);

            Console.WriteLine("how many contracts to this worker?");
            int qtde = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int horas = int.Parse(Console.ReadLine());

                HourContract hc = new HourContract(data, valor, horas);
                wk.AddContract(hc);
            }

            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string busca = Console.ReadLine();
            int month = int.Parse(busca.Substring(0, 2));
            int year = int.Parse(busca.Substring(3));

            Console.WriteLine("Name: " + wk.Name);
            Console.WriteLine("Department: " + wk.Department.Name);
            Console.WriteLine("Income for " + busca + ": " + wk.Income(year, month).ToString(CultureInfo.InvariantCulture));
        }
    }
}
