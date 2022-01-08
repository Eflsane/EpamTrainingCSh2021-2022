using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDinensionalArrayWrapper arrayWrapper = new TwoDinensionalArrayWrapper(2);
            Console.WriteLine(arrayWrapper.ToString());

            Console.WriteLine("Even Sum 2D: \n" + arrayWrapper.EvenSum2D().ToString());

            Console.ReadKey();
        }
    }
}
