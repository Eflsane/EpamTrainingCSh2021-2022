using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor(10);
            Console.WriteLine(arrayProcessor.ToString());

            Console.WriteLine("Max = " + arrayProcessor.Max().ToString());
            Console.WriteLine("Min = " + arrayProcessor.Min().ToString());

            arrayProcessor.GnomeSort();
            Console.WriteLine("Sorted: \n" + arrayProcessor.ToString());

            Console.ReadKey();
        }
    }
}
