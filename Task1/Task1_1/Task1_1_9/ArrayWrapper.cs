using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_9
{
    class ArrayWrapper
    {
        int[] array;

        public ArrayWrapper(int size)
        {
            array = new int[size];

            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {              
                 array[i] = rand.Next(-100, 100);
            }
        }

        public int NonNegativeSum()
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > 0)
                    sum += array[i];
            }

            return sum;
        }

        public string ToString()
        {
            if (array == null)
                throw new InvalidOperationException("array must be not null");

            string res = "";

            for (int i = 0; i < array.Length; i++)
            {
                res += array[i].ToString() + "\n";
            }

            return res;
        }
    }
}
