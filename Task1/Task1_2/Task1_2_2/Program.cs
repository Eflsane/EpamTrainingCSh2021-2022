using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string originString = Console.ReadLine(); //написать программу, которая

            Console.WriteLine("Enter second string:");
            string modifierString = Console.ReadLine(); //описание
            List<char> modifiedChars = new List<char>();

            foreach(char ch in modifierString)
            {
                if (!modifiedChars.Contains(ch))
                    modifiedChars.Add(ch);
            }

            StringBuilder doubledStringBuilder = new StringBuilder(originString);
            foreach (Char ch in modifiedChars)
            {
                
                doubledStringBuilder = (doubledStringBuilder.Replace(ch.ToString(), ch.ToString() + ch.ToString()));
            }

            Console.WriteLine(doubledStringBuilder);
            Console.ReadKey();
        }
    }
}
