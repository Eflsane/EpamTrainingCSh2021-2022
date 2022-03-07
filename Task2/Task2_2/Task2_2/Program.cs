using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < Console.WindowHeight * Console.WindowWidth; i++)
            {
                
                //Console.SetCursorPosition(j, i);
                Console.Write(".");
                
            }

            for(int i = Console.WindowHeight - 4; i < Console.WindowHeight; i++)
            {
                for(int j = Console.WindowWidth - 4; j < Console.WindowWidth; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("T");
                    
                }
            }

            Console.ResetColor();
        }
    }
}
