using System;

namespace Lab2
{
    public class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int numerator) : this(numerator, 1)
        {
            
        }

        public Fraction() : this(0, 1)
        {
            
        }

        public Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }

        public void Display()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
    }
}