using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line(1,3, 4, 2);
            Console.WriteLine($"Length of line = {l.GetLength()}");

            Point p1 = new Point(0, 0);
            Point p2 = new Point(4, 3);
            Rectangle r = new Rectangle(p1, p2);
            Console.WriteLine($"Area of rectangle = {r.CalculateArea()}");

            Square s = new Square(p1, p2);
            Console.WriteLine($"Area of square = {s.CalculateArea()}");
        }
    }
}