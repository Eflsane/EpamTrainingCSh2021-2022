using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter trinagle size");
                    int n = 0;
                    int.TryParse(Console.ReadLine(), out n);
                    TriangleFull triangle = new TriangleFull(n);

                    Console.WriteLine(triangle.GetTriangle());
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
