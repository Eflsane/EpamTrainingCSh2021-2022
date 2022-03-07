using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Interfaces;

namespace Task2_1_2.Figures.Shapes
{
    class Rectangle : Shape, ISquareable
    {
        public override string Name => "Rectangle";

        Point leftTopPoint;
        public Point LeftTopPoint 
        { 
            get => leftTopPoint;
            private set => leftTopPoint = value;
        }

        Point rightBottomPoint;
        public Point RightBottomPoint 
        { 
            get => rightBottomPoint;
            private set => rightBottomPoint = value;
        }

        public double Width 
        { 
            get => Math.Abs(LeftTopPoint.X - RightBottomPoint.X);
        }

        public double Height
        {
            get => Math.Abs(LeftTopPoint.Y - RightBottomPoint.Y);
        }

        public Rectangle(Point startPoint, double width, double height)
        {
            LeftTopPoint = startPoint;
            RightBottomPoint = new Point(LeftTopPoint.X + width, LeftTopPoint.Y + height);
        }

        public Rectangle(Point startPoint, Point endPoint)
        {
            LeftTopPoint = startPoint;
            RightBottomPoint = endPoint;
        }

        public override string ToString()
        {
            return $"{Name} is {Width}x{Height}, {Size} with start point at: {LeftTopPoint}, and square = {GetSquare()}";
        }

        public override int Color 
        { 
            get;
            set; 
        }

        public override double Size => Width * 2 + Height * 2;

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            LeftTopPoint.Move(moveOn);
            RightBottomPoint.Move(moveOn);
        }

        public double GetSquare()
        {
            return Width * Height;
        }
    }
}
