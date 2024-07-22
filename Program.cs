using ConsoleApp6.Classes;
using System.Drawing;

namespace ConsoleApp6
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            #region Q2
            //Point3D _3D_Point = new _3D_Point(10, 10, 10);
            //Console.WriteLine(_3D_Point.ToString()); 
            #endregion
            #region Q3
            //Point3D p1;
            //Point3D p2;

            //Console.WriteLine("Enter 3 Points to P1:");
            //int x;
            //int y;
            //int z;
            //if (!int.TryParse(Console.ReadLine(), out x))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //if (!int.TryParse(Console.ReadLine(), out y))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //if (!int.TryParse(Console.ReadLine(), out z))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //p1 = new Point3D(x, y, z);
            //Console.WriteLine("Enter 3 Points to P1:");
            //if (!int.TryParse(Console.ReadLine(), out x))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //if (!int.TryParse(Console.ReadLine(), out y))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //if (!int.TryParse(Console.ReadLine(), out z))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //p2 = new Point3D(x, y, z);

            ///*
            // * With Parse
            // */
            //Console.WriteLine("Enter the point for p1:");
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //p1 = new Point3D(int.Parse(x), int.Parse(y), int.Parse(z));
            //Console.WriteLine("Enter the point for p2:");
            //x = Console.ReadLine();
            //y = Console.ReadLine();
            //z = Console.ReadLine();
            //p2 = new Point3D(int.Parse(x), int.Parse(y), int.Parse(z));

            //with Convert
            //Point3D p1;
            //Point3D p2;
            //Console.WriteLine("Enter the point for p1:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //int z = Convert.ToInt32(Console.ReadLine());
            //p1 = new Point3D(x, y, z);
            //Console.WriteLine("Enter the point for p2:");
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            //z = Convert.ToInt32(Console.ReadLine());
            //p2 = new Point3D(x, y, z);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #region q4
            //In this way it will not work
            //if (p1 == p2) { Console.WriteLine("It works"); }
            //In this way it will work
            //if (p1 == p2) { Console.WriteLine("It works"); }
            #endregion
            #region q5
            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(1, 2, 3),
            //new Point3D(3, 2, 1),
            //new Point3D(2, 3, 1),
            //new Point3D(1, 1, 1),
            //new Point3D(2, 2, 2)
            //};

            //    Array.Sort(points);

            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}


            #endregion
            #region q6
            //Point3D p1 = new Point3D(5, 5, 5);
            //Point3D clone =(Point3D) p1.Clone();
            //Console.WriteLine($"\nOriginal: {p1}");
            //Console.WriteLine($"Clone: {clone}");
            #endregion
            #endregion
            #region MyRegion

            #endregion


            #endregion
            #region Second Project
            //Maths maths = new Maths()
            //{ 
            //    X=2,Y=3
            //};
            //maths.Result = maths.X + maths.Y;
            //Console.WriteLine($"After addition {maths.Result}");
            //maths.Result = maths.X - maths.Y;
            //Console.WriteLine($"After Subtraction {maths.Result}");
            //maths.Result = maths.X / maths.Y;
            //Console.WriteLine($"After Division {maths.Result}");
            //maths.Result = maths.X * maths.Y;
            //Console.WriteLine($"After Multiplication {maths.Result}");
            #endregion
            #region Third Project
            //Duration D1 = new Duration(4500);
            //Duration D2 = new Duration(3600);
            //Duration D3;
            ////Console.WriteLine(D1.ToString());
            //////Duration D1 = new Duration(3600);
            //////D1.ToString();
            ////Duration D2 = new Duration(7800);
            ////Console.WriteLine(D2.ToString());
            ////Duration D3 = new Duration(666);
            ////Console.WriteLine(D3.ToString());
            //D3 = D1 + D2;
            //D3 = D1 + 7800;
            //D3 = ++D1;
            //D3 = --D2;
            //D1 = D1--;
            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 IS MORETHAN D2");
            //}
            //if (D1 <= D2) ;
            //if (D1) ;
            //DateTime obj = (DateTime) D1;

            #endregion
            Console.WriteLine("Part 2");
        }
    }
}
