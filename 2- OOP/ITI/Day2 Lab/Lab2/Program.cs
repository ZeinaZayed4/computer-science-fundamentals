using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Display();
            
            Fraction f2 = new Fraction(4);
            f2.Display();
            
            Fraction f3 = new Fraction(4, 8);
            f3.Display();

            Fraction result = f2.Add(f2, f3);
            Console.Write("f2 + f3 = ");
            result.Display();
        }
    }
}