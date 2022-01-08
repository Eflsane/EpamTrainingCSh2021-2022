using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOrigin = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звездные Войны";

            string[] words = sOrigin.Split();

            int lowerCaseWorldsCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(',', '.', '-', ':', '!', '?', '/', ';');
                
                if(!words[i].StartsWith(
                    System.Globalization.CultureInfo.CurrentCulture.TextInfo.
                    ToUpper(words[i][0]).ToString()
                    ))
                {
                    Console.WriteLine(words[i]);
                    lowerCaseWorldsCount++;
                }
            }
                       

            Console.WriteLine(lowerCaseWorldsCount);
            Console.ReadKey();
        }
    }
}
