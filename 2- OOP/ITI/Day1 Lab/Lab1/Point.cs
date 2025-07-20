using System;

namespace Lab1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public void Display()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y}, {Z})");
        }
        
        public int CalculateDistance(Point p1, Point p2)
        {
            double distance = Math.Abs(p1.X - p2.X);
            return (int)Math.Round(distance);
        }
    }
}