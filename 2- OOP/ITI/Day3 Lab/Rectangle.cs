using System;

namespace Lab
{
    public class Rectangle
    {
        protected Point Point1;
        protected Point Point2;

        public Rectangle(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public int CalculateArea()
        {
            int length = Math.Abs(Point2.GetX() - Point1.GetX());
            int width = Math.Abs(Point2.GetY() - Point1.GetY());

            return length * width;
        }
    }
}