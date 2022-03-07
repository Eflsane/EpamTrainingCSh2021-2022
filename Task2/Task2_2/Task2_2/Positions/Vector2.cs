using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2.Positions
{
    struct Vector2
    {
        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }

        public static int operator -(Vector2 vector1, Vector2 vector2)
        {
            return (int)Math.Sqrt(Math.Pow(vector1.X - vector2.X, 2) + Math.Pow(vector1.Y - vector2.Y, 2));
        }
    }
}
