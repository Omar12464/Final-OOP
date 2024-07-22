using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    internal class Duration : ICloneable
    {
        public Double Hour { get; set; }
        public Double Minute { get; set; }
        public Double Second { get; set; }

        #region Constructor
        public Duration(Double _Seconds)
        {
            Hour = _Seconds / 3600;
            _Seconds = _Seconds % 3600;
            Minute = _Seconds / 60;
            Second = Minute % 60;
            Normalize();
        }
        public Duration(Double _x, Double _y, Double _z)
        {
            Hour = _x;
            Minute = _y;
            Second = _z;
            Normalize();
        }
        public Duration()
        {

        }
        private Double ToTotalSeconds()
        {
            return Hour * 3600 + Minute * 60 + Second;
        }
        private void Normalize()
        {
            if (Second >= 60)
            {
                Minute += Second / 60;
                Second %= 60;
            }
            if (Minute >= 60)
            {
                Hour += Minute / 60;
                Minute %= 60;
            }
        }

        #endregion
        public override string ToString()
        {
            return $"Hour:{Hour:F2}, Minute:{Minute:F2}, Second:{Second:F2}";
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (ReferenceEquals(obj, null) || GetType() != obj.GetType()) return false;

            Duration other = (Duration)obj;
            return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }
        public static bool operator ==(Duration d1, Duration d2)
        {
            if (ReferenceEquals(d1, d2)) return true;
            if (ReferenceEquals(d1, null) || ReferenceEquals(d2, null)) return false;

            return d1.ToTotalSeconds() == d2.ToTotalSeconds();
        }

        // Overload != operator
        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        // Overload > operator
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        // Overload < operator
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        // Overload >= operator
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        // Overload <= operator
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        // Overload + operator (Duration + Duration)
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hour + d2.Hour, d1.Minute + d2.Minute, d1.Second + d2.Second);
        }

        // Overload + operator (Duration + int)
        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.Hour, d1.Minute, d1.Second + seconds);
        }

        // Overload + operator (int + Duration)
        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.Hour, d1.Minute, d1.Second + seconds);
        }

        // Overload - operator (Duration - Duration)
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hour - d2.Hour, d1.Minute - d2.Minute, d1.Second - d2.Second);
        }

        // Overload ++ operator
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hour, d.Minute + 1, d.Second);
        }

        // Overload -- operator
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hour, d.Minute - 1, d.Second);
        }

        // Implement ICloneable interface
        public object Clone()
        {
            return new Duration(Hour, Minute, Second);
        }
    }
}

//// Implement IComparable<Duration> interface

