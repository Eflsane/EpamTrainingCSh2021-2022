using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_1
{
    class Rect
    {
        public int a;
        public int b;

        public Rect(int a, int b)
        {
            if (a <= 0 || b <= 0) throw new ArgumentException("Rect sides a and b must be more 0");
            this.a = a;
            this.b = b;
        }

        public int GetSquare()
        {
            return a * b;
        }
    }
}
