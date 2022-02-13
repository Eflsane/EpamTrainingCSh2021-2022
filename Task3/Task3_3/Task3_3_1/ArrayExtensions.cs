using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_1
{
    public static class ArrayExtensions
    {
        public delegate void DoAthing(int x);
        public static void DoSomethingWithAll(this int[] array, DoAthing doAThing, Func<int, bool> predicate)
        {
            int[] workingArray = array.Where(predicate).ToArray();
            for(int i = 0; i < workingArray.Length; i++)
            {
                doAThing(workingArray[i]);
            }
        }

        public static int IntSum(this int[] array)
        {
            return array.Sum();
        }

        public static double IntAve(this int[] array)
        {
            return array.Average();
        }

        public static int MostOccuringElem(this int[] array)
        {
            Dictionary<int, int> intDict = new Dictionary<int, int>();
            foreach(int item in array)
            {
                if (!intDict.ContainsKey(item))
                {
                    intDict.Add(item, 1);
                    continue;
                }

                intDict[item] += 1;
            }
            return intDict.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }
    }
}
