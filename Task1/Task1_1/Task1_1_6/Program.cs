using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Bold \n" +
                    "2. Italic \n" +
                    "3. Underline \n" +
                    "Now: " + Fonts.ToString());

                int choice = -1;
                int.TryParse(Console.ReadLine(), out choice);

                Fonts.AdjustFont((FontsAdjusts)(choice - 1));
            }
        }
    }
}
