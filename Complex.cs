using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Image { get; set; }

        public static Complex operator +(Complex r, Complex i)
        {
            return new Complex()
            {
                Real = r?.Real ?? 0 + i?.Real ?? 0,
                Image = r?.Image ?? 0 + i?.Image ?? 0,
            };
        }
        public static Complex operator -(Complex r, Complex i)
        {
            return new Complex()
            {
                Real = r?.Real??0 - i?.Real??0,
                Image = r?.Image??0 - i?.Image??0,
            };
        }
        public static Complex operator ++(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real??0)+1,
                Image = (complex?.Image??0)+1
            };
        }
        public static Complex operator --(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real ?? 0) - 1,
                Image = (complex?.Image ?? 0) - 1
            };
        }
        public static bool operator >(Complex left,Complex right)
        {
            if(left.Real==left.Real)
                return right.Image > left.Image;
            else return left.Real > right.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == left.Real)
                return right.Image < left.Image;
            else return left.Real < right.Real;
        }
        //public static bool operator ==(Complex left, Complex right)
        //{
        //    return (left?.Real??0 == right?.Real??0);
        //}
        public static /*int*/ explicit operator int(Complex complex)
        {
            return complex?.Real??0;
        }
        public static /*int*/ implicit operator string(Complex complex)
        {
            return complex.ToString()??string.Empty;
        }
        //public static bool operator !=(Complex left, Complex right)
        //{
        //    if (left.Real == left.Real)
        //        return right.Image < left.Image;
        //    else return left.Real < right.Real;
        //}
        public override string ToString()
        {
            return $"{Real}+{Image}i";
        }
    }
}
