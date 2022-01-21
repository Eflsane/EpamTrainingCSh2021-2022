using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Interfaces;

namespace Task2_1_2.Figures
{
    abstract class Figure : IDisplayable, IMoveable
    {
        public abstract string Name
        {
            get;
        }

        public override string ToString()
        {
            return Name;
        }

        public abstract void Display();

        public abstract void Move(Point moveOn);
    }

    public enum FigureType
    {
        Null = 0,
        Point = 1,
        Line = 2,
        Circumference = 3,
        Circle = 4,
        Ring = 5,
        Triangle = 6,
        Rectangle = 7,
        Square = 8
    }
}
