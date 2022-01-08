using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a side of rect");
                    int a = 0;
                    int.TryParse(Console.ReadLine(), out a);

                    Console.WriteLine("Enter b side of rect");
                    int b = 0;
                    int.TryParse(Console.ReadLine(), out b);

                    Rect rect = new Rect(a, b);

                    Console.WriteLine("Square of rect is " + rect.GetSquare());
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
