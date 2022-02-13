using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,1,2,2,2,3,3,3,3,4,5,5,7,7,7,7,7,7,3,3,3,3};

            array.DoSomethingWithAll(x => Console.WriteLine(x*x), y => y == 3);
            Console.WriteLine(array.MostOccuringElem());
            Console.ReadKey();
        }
    }
}
