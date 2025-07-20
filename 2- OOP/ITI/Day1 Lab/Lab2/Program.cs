using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Numerator = 1;
            f1.Denominator = 3;
            f1.Display();
            
            Fraction f2 = new Fraction();
            f2.Numerator = 2;
            f2.Denominator = 3;
            f2.Display();

            Fraction result = f1.Add(f1, f2);
            Console.Write("f1 + f2 = ");
            result.Display();
        }
    }
}
