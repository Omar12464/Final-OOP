using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    internal class Maths
    {
        public int Result { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public static Maths operator +(Maths x, int seconds)
        {
            return new Maths() {
                Result= x.X +  seconds,
            };
        }
        public static Maths operator -(Maths x, Maths y)
        {
            return new Maths()
            {
                Result = x.X - y.Y,
            };
        }
        public static Maths operator *(Maths x, Maths y)
        {
            return new Maths()
            {
                Result = x.X * y.Y,
            };
        }
        public static Maths operator /(Maths x, Maths y)
        {
            return new Maths()
            {
                Result = x.X / y.Y,
            };
        }
    }
}
