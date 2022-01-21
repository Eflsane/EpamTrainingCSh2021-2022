using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures
{
    class Point : Figure
    {
        public override string Name => "Point";

        double x;
        public double X
        {
            get => x;
            private set => x = value;
        }
        double y;

        public double Y
        {
            get => y;
            private set => y = value;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return base.ToString() + $" x = {X}; y = {Y}";
        }

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            X += moveOn.X;
            Y += moveOn.Y;
        }

        public static double operator -(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
        }
    }
}
