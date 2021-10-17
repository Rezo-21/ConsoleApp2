using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

            int i = 5;
            int j = 4;

            Console.WriteLine(i.Equals(j));

            var oi = (object)i;
            object oj = j;

            Console.WriteLine(oi.Equals(oj));

            var p1 = new Point() {x = 5};
            var p2 = new Point() {x = 5};

            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(oj.GetHashCode());
            Console.WriteLine(p1.GetHashCode());

            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(p1.GetType());

            Console.WriteLine(typeof(Point) == p1.GetType());

            Console.WriteLine(object.Equals(5, 5));
            Console.WriteLine(object.ReferenceEquals(5,5));
            Console.WriteLine(object.ReferenceEquals(p2, p2));

            var pp = new Point() {x = 7, y = new Point()};
            var pp2 = pp;
            pp2.x = 77;
            pp2.y = new Point() {x = 99};
            Console.WriteLine(pp);
            Console.WriteLine(pp.y);

            var pp3 = pp.Clone();
            pp3.x = 88;
            pp3.y.x = 222;
            Console.WriteLine(pp);

            Console.ReadLine();

        }
    }
}