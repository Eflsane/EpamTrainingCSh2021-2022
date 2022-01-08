using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWrapper arrayWrapper = new ArrayWrapper(10);
            Console.WriteLine(arrayWrapper.ToString());

            Console.WriteLine("Non Negative Sum: \n" + arrayWrapper.NonNegativeSum().ToString());

            Console.ReadKey();
        }
    }
}
