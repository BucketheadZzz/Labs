using System;

namespace Labs.Lab3
{
    public class Fraction
    {
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; set; }

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be null");
                }

                denominator = value;
            }
        }

        public double DecimalFractionValue => Numerator / (double)Denominator;

        public static void Add(Fraction fractionA, Fraction fractionB)
        {
            if (fractionA.Denominator != fractionB.Denominator)
            {
                fractionA.Denominator *= fractionB.Denominator;
                fractionA.Numerator = fractionA.Numerator * fractionB.Denominator +
                                      fractionB.Numerator * fractionA.Denominator;
            }
            else
            {
                fractionA.Numerator += fractionB.Numerator;
            }
        }

        public static void Subtraction(Fraction fractionA, Fraction fractionB)
        {
            if (fractionA.Denominator != fractionB.Denominator)
            {
                fractionA.Denominator *= fractionB.Denominator;
                fractionA.Numerator = fractionA.Numerator * fractionB.Denominator -
                                      fractionB.Numerator * fractionA.Denominator;
            }
            else
            {
                fractionA.Numerator -= fractionB.Numerator;
            }
        }

        public static void Multiply(Fraction fractionA, Fraction fractionB)
        {
            fractionA.Numerator *= fractionB.Numerator;
            fractionA.Denominator *= fractionB.Denominator;

            Simplify(fractionA);
        }


        public static void Divide(Fraction fractionA, Fraction fractionB)
        {
            fractionA.Numerator *= fractionB.Denominator;
            fractionA.Denominator *= fractionB.Numerator;

            Simplify(fractionA);
        }

        public static void Simplify(Fraction fraction)
        {
            while (fraction.Denominator > 0 && fraction.Numerator > 0 && fraction.Denominator != 1 && fraction.Numerator != 1)
            {
                if (fraction.Numerator % fraction.Denominator == 0)
                {
                    fraction.Numerator /= fraction.Denominator;
                    fraction.Denominator = 1;
                }
                else if (fraction.Denominator % fraction.Numerator == 0)
                {
                    fraction.Denominator /= fraction.Numerator;
                    fraction.Numerator = 1;
                }
                else if (fraction.Denominator % 2 == 0 && fraction.Numerator % 2 == 0)
                {
                    fraction.Denominator /= 2;
                    fraction.Numerator /= 2;
                }
                else if (fraction.Denominator % 3 == 0 && fraction.Numerator % 3 == 0)
                {
                    fraction.Denominator /= 3;
                    fraction.Numerator /= 3;
                }

                else break;
            }
        }
    }
}
