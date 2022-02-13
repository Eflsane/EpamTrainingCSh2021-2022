using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Polygonals
{
    class Square : Figure
    {
        Point leftTopPoint;

        Point rightBottomPoint;

        public Square(Point startPoint, double width)
        {
            LeftTopPoint = startPoint;
            RightBottomPoint = new Point(LeftTopPoint.X + width, LeftTopPoint.Y + width);
        }

        public override string Name => "Square";

        public Point LeftTopPoint
        {
            get => leftTopPoint;
            protected set => leftTopPoint = value;
        }

        public Point RightBottomPoint
        {
            get => rightBottomPoint;
            protected set => rightBottomPoint = value;
        }

        public double Width
        {
            get => Math.Abs(LeftTopPoint.X - RightBottomPoint.X);
        }

        public override string ToString()
        {
            return $"{Name} is with width = {Width} with start point at: {LeftTopPoint}, square = {GetSquare()}";
        }

        public override int Color
        {
            get;
            set;
        }

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            LeftTopPoint.Move(moveOn);
            RightBottomPoint.Move(moveOn);
        }

        public virtual double GetSquare()
        {
            return Width * Width;
        }

    }
}
