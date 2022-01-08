using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter tree size");
                    int n = 0;
                    int.TryParse(Console.ReadLine(), out n);
                    XmasTree triangle = new XmasTree(n);

                    Console.WriteLine(triangle.GetTree());
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
