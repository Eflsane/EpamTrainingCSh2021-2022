using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_8
{
    class ThreeDimensionArrayWrapper
    {
        public int[,,] array;

        public ThreeDimensionArrayWrapper(int size)
        {
            array = new int[size, size, size];

            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = rand.Next(-100, 100);
                    }
                }
                
            }
        }

        public void NoPositive()
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                            array[i, j, k] = 0;
                    }
                }

            }
        }

        public string ToString()
        {
            if (array == null)
                throw new InvalidOperationException("array must be not null");

            string res = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        res += array[i, j, k].ToString() + " ";
                    }
                    res += "\n";
                }
                
            }

            return res;
        }
    }
}
