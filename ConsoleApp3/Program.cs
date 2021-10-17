using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheiyvanet cifri: ");
            var input = Console.ReadLine();

            if (int.TryParse(input,out int result))
            {
                //var isEven = isEven(result);
                result.isEven();
                if (result.isEven())
                {
                    Console.WriteLine($"{result} - luwi.");
                }
                else
                {
                    Console.WriteLine($"{result} - kenti.");
                }
                int h = 182;
                h.isDividedBy(7);

                var list = new List<Road>();
            }
            else
            {
                Console.WriteLine("shecdoma!");
            }

            Console.ReadLine();

            var roads = new List<Road>();
            for (var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.convertTostring();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }       
    }
}
