using System;
using System.Text.RegularExpressions;

namespace Lab
{
    public class Line
    {
        private Point _point1;
        private Point _point2;

        public Line(int p1X, int p1Y, int p2X, int p2Y)
        {
            _point1 = new Point(p1X, p1Y);
            _point2 = new Point(p2X, p2Y);
        }

        public int GetLength()
        {
            double length = Math.Sqrt(Math.Pow(_point1.GetX() - _point2.GetX(), 2) + Math.Pow(_point1.GetY() - _point2.GetY(), 2));
            return (int)Math.Round(length);
        }
    }
}