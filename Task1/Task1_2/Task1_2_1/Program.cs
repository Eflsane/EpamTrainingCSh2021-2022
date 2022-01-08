using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOrigin = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

            string[] words = sOrigin.Split();

            int sum = 0;

            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(',', '.', '-', ':', '!', '?', '/');
                Console.WriteLine(words[i]);
                sum += words[i].Length;
            }

            //
            int mid = sum / words.Length;

            Console.WriteLine(mid);
            Console.ReadKey();
        }
    }
}
