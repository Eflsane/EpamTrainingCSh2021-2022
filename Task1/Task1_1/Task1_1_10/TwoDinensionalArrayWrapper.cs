using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_10
{
    class TwoDinensionalArrayWrapper
    {
        public int[,] array;

        public TwoDinensionalArrayWrapper(int size)
        {
            array = new int[size, size];

            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                 
                     array[i, j] = rand.Next(-100, 100);
                }

            }
        }

        public int EvenSum2D()
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(((i + j) % 2) == 0)
                        sum += array[i, j];
                }
            }

            return sum;
        }

        public string ToString()
        {
            if (array == null)
                throw new InvalidOperationException("array must be not null");

            string res = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    res += array[i, j].ToString() + " \n";
                }

            }

            return res;
        }
    }
}
