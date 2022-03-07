using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Shapes
{
    class Square : Rectangle
    {
        public override string Name => "Square";

        public Square(Point startPoint, double side) : base(startPoint, side, side)
        {
        }

    }
}
