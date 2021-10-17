using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new
            {
                Name = "MIlk",
                Energy = 10
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };

            Console.WriteLine(product2 );

            Tuple<int, string> tuple = new Tuple<int, string>(5, "ok");
            Console.WriteLine(tuple.Item1);

            var tuple2 = (5, "ok");
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 60;

            var result = GetData();
            Console.WriteLine(result.Name);

            Console.ReadLine();
        }
        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 7821;//informaciis migeba
            var name = Guid.NewGuid().ToString();//informaciis migeba
            bool b = number > 500; //shemowmeba

            return (number, name, b);
        }
    }
}