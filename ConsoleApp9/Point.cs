using System;
using System.Dynamic;

namespace ConsoleApp9
{
    class Point
    {
        public int x { get; set; }

        public Point y { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Point point)
            {
                return point.x == x;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return x;
        }

        public override string ToString()
        {
            return x.ToString();
        }

        public Point Clone()
        {
            return MemberwiseClone() as Point;
        }

        public Type GetType()
        {
            return typeof(UInt16);
        }


    }
}