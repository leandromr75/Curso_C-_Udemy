using System;
using Exercicio_ComposiçãoObjetos_StringBuilder.Entities;
using Exercicio_ComposiçãoObjetos_StringBuilder.Entities.Enums;

namespace Exercicio_ComposiçãoObjetos_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine(); //nome
            Console.Write("Email: ");
            string email = Console.ReadLine(); //email
            Console.Write("Birth date (DD/MM/YYYY): ");
            string aniversario = Console.ReadLine(); // aniversário
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus stat = Enum.Parse<OrderStatus>(Console.ReadLine()); // status
            Console.Write("How many items to this order? ");
            Client c = new Client();
            //DateTime U = DateTime.Parse();
            c.Name = nome;
            c.Email = email;
            DateTime T = DateTime.Parse(aniversario);
            c.BirthDate = T;
            Order OS = new Order(DateTime.Now, stat, c);

            int od = int.Parse(Console.ReadLine()); // quantidade orders
            for (int i = 0; i < od; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qt = int.Parse(Console.ReadLine());

                Product p = new Product(name, price);
                OrderItem oi = new OrderItem(qt, price);
                oi.Product = p;
                OS.AddItem(oi);
            }

            Console.WriteLine(OS);
        }
    }
}
