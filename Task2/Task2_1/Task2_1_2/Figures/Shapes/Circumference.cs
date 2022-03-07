using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Shapes
{
    class Circumference : Shape
    {
        public override string Name => "Circumference";

        Point center;

        public Point Center 
        { 
            get => center;
            private set => center = value; 
        }

        double radius;
        public double Radius 
        { 
            get => radius;
            set
            {
                if (value > 0)
                    radius = value;
                else radius = 1;
            }
        }

        public Circumference(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return $"{Name} is {Size} with center at: {Center} and radius = {Radius}";
        }

        public override int Color { get; set; }

        public override double Size
        {
            get => 2 * Math.PI * Radius;
        }

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            center.Move(moveOn);
        }
    }
}
