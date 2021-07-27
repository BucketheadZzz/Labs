using System;

namespace Labs.Lab6
{
    public static class MathFunctions
    {
        public static double Func1(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public static double Func2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        public static Func<double, double> Func3()
        {
            return x => x * x - 50 * x + 10;
        }

        public static Func<double, double> Func4()
        {
            return x => x + x + 10;
        }

        public static Func<double, double> Func5()
        {
            return x => x * x;
        }
    }
}
