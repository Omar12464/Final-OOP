namespace ConsoleApp6
{
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        public abstract double CalArea();
        public abstract double Perimeter();

    }
    internal class Rectangle : Shape
    {

        public override double CalArea()
        {
            return Dim01 * Dim02;
        }
        public override double Perimeter()
        {
            return Dim02 + Dim01;
        }

    }
    internal abstract class RectBase : Shape
    {
        public override double CalArea()
        {
            return Dim01 * Dim02;
        }

        //public override double Perimeter()
        //{
        //    throw new NotImplementedException();
        //}
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Demo
            Complex c1 = new Complex()
            {
                Real = 3,
                Image = 4
            };
            Complex c2 = new Complex()
            {
                Real = 1,
                Image = 2
            };
            Complex c3 = c2;
            #region Binary Expression
            c3 = c1 + c2;
            c3 = c1 - c2;
            #endregion
            #region Unary Operators
            //c3 = c1++;
            //c3 = ++c1;
            #endregion
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.GetHashCode());
            //c2.GetHashCode();
            //Console.WriteLine(c2.GetHashCode());
            //Console.WriteLine(c3.GetHashCode());
            //c1.GetHashCode();
            //c3.GetHashCode();
            //if (c1 > c2)
            //    Console.WriteLine("c1 is greater");
            //else if(c1<c2)
            //    Console.WriteLine("c1 is greater");
            //else
            //    Console.WriteLine("Both Equal");
            //int z = (int)c1;

            //Console.WriteLine(z);

            //string str =(string) c1;
            //Console.WriteLine(str);

            #region Casting Operator
            //Employee e1 = new Employee()
            //{
            //    Id = 10,
            //    FullName = "Omar Ibrahim",
            //    Email = "maha@gmail.com",
            //    Password = "password"

            //};
            //EmployeeViewModel empview = (EmployeeViewModel)e1; 
            #endregion

            //Shape shape= new Shape();
            //shape.CalArea();

            Rectangle rectangle = new Rectangle() { Dim01 = 2, Dim02 = 3 };
            Console.WriteLine(rectangle.CalArea());
            Console.WriteLine(rectangle.Perimeter());


            #endregion
        }
    }
}
