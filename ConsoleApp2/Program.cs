using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random rnd = new Random();

            var products = new Product();

            var collection = new List<Product>();

            products.Energy = rnd.Next(10, 500);
            for (var i = 0; i < 10; i++)
            {
                products.Name = "product" + i;
                collection.Add(products);
            }           

            var result = from item in collection
                         where item.Energy < 200
                         orderby item.Energy
                         select item;

            var result2 = collection.Where(item => item.Energy < 200);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = collection.OrderBy(product => product.Energy)
                                              .ThenByDescending(Product => Product.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = collection.GroupBy(product => product.Energy);

           

            Console.ReadLine();
        }
    }
}
