using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Display();

            Point p2d = new Point(2, 4);
            p2d.Display();
            
            Point p3d = new Point(2, 4, 8);
            p3d.Display();
        }
    }
}