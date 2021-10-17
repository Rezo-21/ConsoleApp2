using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ford", Number = "111"},
                new Car() {Name = "Golf", Number = "222"}
            };
            var parking = new Parking();
            foreach(var car in cars)
            {
                parking.Add(car);
            }

            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            foreach (var item in parking)
            {
                Console.Write(item + "");
            }

            Console.WriteLine();

            foreach (var name in parking.GetNames())
            {
                Console.WriteLine("saxeli" + name);
            }

            Console.WriteLine();

            Console.WriteLine(parking["111"].Name);
            Console.WriteLine(parking["211"]?.Name);

            Console.WriteLine("sheiyvanet axali nomeri");
            var num = Console.ReadLine();

            parking[1] = new Car { Name = "BMW", Number = num };
            Console.WriteLine(parking[1]);

            Console.ReadLine();
        }      
    }
}