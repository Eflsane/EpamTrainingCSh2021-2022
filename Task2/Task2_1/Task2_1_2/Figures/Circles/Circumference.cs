using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Circles
{
    class Circumference : Figure
    {
        Point center;

        double radius;

        public Circumference(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string Name => "Circumference";

        public Point Center
        {
            get => center;
            private set => center = value;
        }

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

        public override string ToString()
        {
            return $"{Name} is {CircleLength} with center at: {Center} and radius = {Radius}";
        }

        public override int Color { get; set; }

        public virtual double CircleLength
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
