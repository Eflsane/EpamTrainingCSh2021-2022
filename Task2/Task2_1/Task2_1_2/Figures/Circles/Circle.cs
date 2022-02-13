using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Interfaces;

namespace Task2_1_2.Figures.Circles
{
    class Circle : Circumference, ISquareable
    {
        public Circle(Point center, double radius) : base(center, radius)
        {         
        }

        public override string Name => "Circle";

        public override string ToString()
        {
            return base.ToString() + $" with sqare = {GetSquare()}";
        }

        public virtual double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
