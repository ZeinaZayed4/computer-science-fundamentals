using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 4;
            p1.Y = 2;
            p1.Z = 6;
            p1.Display();

            Point p2 = new Point();
            p2.X = 8;
            p2.Y = 6;
            p2.Z = 10;
            p2.Display();

            int distance = p1.CalculateDistance(p1, p2);
            Console.WriteLine($"Distance between p1 and p2 = {distance}");
        }
    }
}