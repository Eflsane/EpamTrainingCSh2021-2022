using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_5
{
    static class SumOfNumbers
    {
        public static int GetSumOfNumbers(int maxNumber)
        {
            if (maxNumber <= 0) throw new ArgumentException("maxNumber must be more 0");

            int sum = 0;

            for(int i = 3; i < maxNumber; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                    sum += i;
            }

            return sum;
        }
    }
}
