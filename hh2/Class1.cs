using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hh2
{
    internal class Class1
    {
        public  static double Sqvear(double x, double y, double z)
        {
            double a = Math.Min(x, Math.Min(z, y));
            double c = Math.Max(x, Math.Max(z, y));
            double b = (x + y + z) - c - a;
            double p = (x + y + z) / 2;
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) return (a * b) / 2;
            else return Math.Sqrt(p * (p - z) * (p - x) * (p - y));
        }
        public static double Sqvear(double x)
        {
            return Math.PI * Math.Pow(x, 2);
        }
        public static double Sqvear(double x, double y)
        {
            return x * y;
        }
    }
}
