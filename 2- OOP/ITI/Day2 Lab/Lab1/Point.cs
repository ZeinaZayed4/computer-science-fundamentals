using System;

namespace Lab1
{
    public class Point
    {
        public int X;
        public int Y;
        public int Z;

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(int x, int y): this(x, y, 0)
        {
            
        }

        public Point() : this(0, 0, 0)
        {
            
        }
        
        public int CalculateDistance(Point p1, Point p2)
        {
            double distance = Math.Abs(p1.X - p2.X);
            return (int)Math.Round(distance);
        }

        public void Display()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y}, {Z})");
        }
    }
}