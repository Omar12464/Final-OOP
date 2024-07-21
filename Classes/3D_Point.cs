using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    internal class Point3D
    {
        #region Q1
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x)
        {
            X = _x;
        }
        public Point3D(int _x, int _y) : this(_x) //Chaining from first Constructor 
        {
            X = _x; Y = _y;
        }
        public Point3D(int _x, int _y, int _z) : this(_x, _y)//Chaining from Second Constructor 
        {
            X = _x; Y = _y; Z = _z;
        }
        // Override ToString method
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        } 
        #endregion

    }
}
