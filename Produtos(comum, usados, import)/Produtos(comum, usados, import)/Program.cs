using System;
using System.Globalization;
using Produtos_comum__usados__import_.Entities;
using System.Collections.Generic;

namespace Produtos_comum__usados__import_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();


            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, Used or Imported(c/u/i)? ");
                char tip = char.Parse(Console.ReadLine());

                if(tip == 'i')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Customs fee: ");
                    double cFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, cFee));

                }
                if(tip == 'c')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
                if(tip == 'u')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Manufacture date: ");
                    DateTime manu = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manu));
                }
                else
                {
                    Console.WriteLine("Error... ");
                }

                foreach(Product prod in list)
                {
                    Console.WriteLine(prod.Name+" - $"+prod.Price+" - ");
                }


            }
        }
    }
}
