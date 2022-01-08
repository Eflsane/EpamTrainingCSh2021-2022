using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensionArrayWrapper arrayWrapper = new ThreeDimensionArrayWrapper(4);
            Console.WriteLine(arrayWrapper.ToString());

            arrayWrapper.NoPositive();
            Console.WriteLine("No Positive: \n" + arrayWrapper.ToString());

            Console.ReadKey();
        }
    }
}
