using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Interfaces;

namespace Task2_1_2.Figures.Polygonals
{
    class Rectangle : Square, ISquareable
    {

        public Rectangle(Point startPoint, double width, double height) : base(startPoint, width)
        {
            LeftTopPoint = startPoint;
            RightBottomPoint = new Point(LeftTopPoint.X + width, LeftTopPoint.Y + height);
        }

        public override string Name => "Rectangle";

        public double Height
        {
            get => Math.Abs(LeftTopPoint.Y - RightBottomPoint.Y);
        }

        public override string ToString()
        {
            return base.ToString() + $" with height = {Height}";
        }

        public override double GetSquare()
        {
            return base.GetSquare() / Width * Height;
        }
    }
}
