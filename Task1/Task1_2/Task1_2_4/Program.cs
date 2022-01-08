using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOrigin = "я плохо учил русский язык. забываю начинать предложения с заглавной." +
                " хорошо, что можно написать программу! но уже слишком поздно. они стуча" +
                "тся в дверь. " +
                "может это инопланетяне пытаются выбить дверь? эх, жаль что я раньше не начал изучать программирование.";

            string[] words = sOrigin.Split();
            string[] sentSeparators = new string[] {".",  "!", "?"};

            int firstWord = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (firstWord == -1)
                    firstWord = i;
                foreach(string separ in sentSeparators)
                {
                    if (words[i].Contains(separ))
                    {

                        words[firstWord] = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[firstWord]);
                        Console.WriteLine(words[firstWord]);
                        firstWord = -1;
                    }
                }
                
            }

            Console.WriteLine();
            foreach(string w in words)
            {
                Console.Write(w + " ");
            }
            
            Console.ReadKey();
        }
    }
}
