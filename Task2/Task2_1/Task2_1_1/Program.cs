using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString cs = new CustomString(new Char[] {'x', 'y', 'z' });
            CustomString cs2 = new CustomString();
            cs2.ConvertFromCharArray(new char[] { 'z', 'c', 'v' });
            Console.WriteLine(cs);
            Console.WriteLine(cs2);

            CustomString cs3 = cs + cs2;
            Console.WriteLine(cs3);

            Console.WriteLine(cs.FindSymbol('c'));
            Console.WriteLine(cs2.FindSymbol('c'));

            CustomString cs4 = new CustomString(cs.ConvertToCharArray());
            Console.WriteLine(cs4);
            Console.WriteLine(cs4.Equals(cs));
            Console.WriteLine(cs3.Equals(cs));
            Console.WriteLine(cs.Equals(cs));



            CustomString cs5 = cs4 * 3; 
            Console.WriteLine(cs5);

            Console.ReadKey();
        }
    }
}
