using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_2
{
    class TriangleHalf
    {
        int n;

        public TriangleHalf(int n)
        {
            if(n < 0) throw new ArgumentException("n must be more 0");
            this.n = n;
        }

        public string GetTriangle()
        {
            string triangle = "";
            for(int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    triangle += "*";

                triangle += "\n";
            }

            return triangle;
        }
    }
}
