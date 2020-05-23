using System;
using System.Collections.Generic;
using Product.Entities;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product_> list = new List<Product_>();
            Console.Write("Enter the number of products: ");
            int amountProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amountProducts; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char kind = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (kind == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct aux = new UsedProduct(name, price, manufactureDate);
                    list.Add(aux);
                }
                else if (kind =='i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    ImportedProduct aux = new ImportedProduct(name, price, customsFee);
                    list.Add(aux);
                }
                else if (kind == 'c')
                {
                    Product_ aux = new Product_(name, price);
                    list.Add(aux);
                }
            }
            Console.WriteLine("\n PRICE TAGS");
            foreach (Product_ product in list)
            {
                product.Pricetag();
            }
        }
    }
}
