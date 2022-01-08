using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_7
{
    class ArrayProcessor
    {
        public int[] array;

        public ArrayProcessor(int size)
        {
            array = new int[size];

            Random rand = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }

        public int Max()
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");
            
            int max = int.MinValue;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }

        public int Min()
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");

            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }

            return min;
        }

        public int[] GnomeSort(bool isAscending = true)
        {
            if (array == null || array.Length <= 0)
                throw new InvalidOperationException("array must be not null and it's length > 0");

            int i = 1;
            int pointer = 2;

            if(isAscending)
            {
                while (i < array.Length)
                {
                    if (array[i - 1] < array[i])
                    {
                        i = pointer;
                        pointer += 1;
                    }
                    else
                    {
                        array[i - 1] += array[i];
                        array[i] = array[i - 1] - array[i];
                        array[i - 1] = array[i - 1] - array[i];

                        i = i - 1;
                        if (i == 0)
                        {
                            i = pointer;
                            pointer += 1;
                        }
                    }
                }
            }

            else
            {
                while (i < array.Length - 1)
                {
                    if (array[i - 1] > array[i])
                    {
                        i = pointer;
                        pointer += 1;
                    }
                    else
                    {
                        array[i - 1] += array[i];
                        array[i] = array[i - 1] - array[i];
                        array[i - 1] = array[i - 1] - array[i];

                        i = i - 1;
                        if (i == 0)
                        {
                            i = pointer;
                            pointer += 1;
                        }
                    }
                }
            }
            
            return array;
        }

        public string ToString()
        {
            if (array == null)
                throw new InvalidOperationException("array must be not null");

            string res = "";

            for(int i = 0; i < array.Length; i++)
            {
                res += array[i].ToString() + "\n";
            }

            return res;
        }
    }
}
