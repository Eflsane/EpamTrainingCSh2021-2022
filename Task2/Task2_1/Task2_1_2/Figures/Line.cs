using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Shapes
{
    class Line : Figure
    {
        Point point1;

        Point point2;

        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override string Name => "Line";

        public Point Point1
        {
            get => point1;
            private set => point1 = value;
        }

        public Point Point2
        {
            get => point2;
            private set => point2 = value;
        }

        public override string ToString()
        {
            return $"{Name} is {Length} from: {Point1} to: {Point2}";
        }

        public override int Color { get; set; }

        public double Length
        {
            get => point1 - point2;
        }

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            Point1.Move(moveOn);
            Point2.Move(moveOn);
        }
    }
}
