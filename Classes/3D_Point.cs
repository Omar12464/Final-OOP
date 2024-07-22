using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    internal class Point3D:IComparable,ICloneable
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
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y && p1.Z != p2.Z;
        }
        // Override ToString method
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D p = (Point3D)obj;
            if (X != p.X) { return X.CompareTo(p.X); }
            else {return Y.CompareTo(p.Y); }
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        #endregion

    }
}
