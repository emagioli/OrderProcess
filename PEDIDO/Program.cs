using System;
using System.Globalization;
using System.Collections.Generic;
using PEDIDO.Entities;
using PEDIDO.Entities.Enums;

namespace PEDIDO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine()); //number of items
            List<OrderItem> items = new List<OrderItem>();
            Order order = new Order(DateTime.Now, status, items, client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(itemQuantity, productPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine($"Order status: {order.Status}"); //aqui deve dar merda
            Console.Write($"Client: {client.Name}");
            Console.Write($" ({client.BirthDate.ToString("dd/MM/yyyy")})");
            Console.WriteLine($" - {client.Email}");//**************** writeline
            Console.WriteLine("Order items:");
            foreach (OrderItem i in order.Items)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine($"Total price: ${order.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
