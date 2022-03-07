using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Shapes
{
    class Ring : Circle
    {
        public override string Name => "Ring";

        double radiusInside;
        public double RadiusInside 
        { 
            get => radiusInside;
            set
            {
                if (value > 0)
                    radiusInside = value;
                else radiusInside = 1;
            }
        }

        public Ring(Point center, double radius, double radiusInside) : base(center, radius)
        {
            RadiusInside = radiusInside;
        }

        public override string ToString()
        {
            return base.ToString() + $" with inner radius = {RadiusInside}";
        }

        public override double Size => base.Size + 2 * Math.PI * RadiusInside;

        public override double GetSquare()
        {
            return base.GetSquare() - Math.PI * RadiusInside * RadiusInside;
        }
    }
}
