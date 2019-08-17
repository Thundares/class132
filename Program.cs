using System;
using System.Collections.Generic;
using class132.Entities;

namespace aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char temp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(temp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine());

                    Product imported = new ImportedProduct(name, price, cf);
                    list.Add(imported);
                }
                else if(temp == 'u')
                {
                    Console.Write("Manufacture date (yyyy/mm/dd): ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());

                    Product used = new UsedProduct(name, price, dt);
                    list.Add(used);
                }
                else if(temp == 'c')
                {
                    Product commom = new Product(name, price);
                    list.Add(commom);
                }
            }

            System.Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product obj in list)
            {
                Console.WriteLine(obj.priceTag());
            }
        }
    }
}
