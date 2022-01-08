using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int maxNumber = 1000;

                    Console.WriteLine(SumOfNumbers.GetSumOfNumbers(maxNumber));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
