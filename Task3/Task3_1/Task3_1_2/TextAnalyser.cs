using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_2
{
    static class TextAnalyser
    {
        //private static int _wordsCount = 0;
        private static char[] _separators = new char[] {' ', '.', ',', ':', '"', '\''};
        private static double procConst = 0.9;
        public static string StartAnalyse(string text)
        {
            return Analyse(PrepareText(text));
        }

        private static string[] PrepareText(string text)
        {
            string[] words = text.ToLower().Split();

            for(int i = 0; i < words.Length; i++ )
            {
                words[i] = words[i].Trim(_separators);
            }

            return words;
        }

        private static string Analyse(string[] words)
        {
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            foreach(string w in words)
            {
                if (!wordDict.ContainsKey(w))
                    wordDict.Add(w, 1);
                else
                {
                    wordDict[w] = wordDict[w] + 1;
                }
            }

            string characteristic = "You have good vacabulary in your text. ";
            if (words.Length * procConst > wordDict.Count)
                characteristic = "You have a lot of same words in your text. ";
            characteristic += $"\nThere is {wordDict.Count} unique words of total {words.Length}";

            int topValue = 5;
            Dictionary<string, int> wordDictSorted = wordDict.OrderByDescending(x => x.Value).ToDictionary((x => x.Key), (x => x.Value));
            Dictionary<string, int> topWordsUsing = wordDictSorted.Take(topValue).ToDictionary((x => x.Key), (x => x.Value));

            StringBuilder res = new StringBuilder();
            res.Append(characteristic + "\n" +
                "Your favorite words: \n" +
                "Word Using");

            foreach(KeyValuePair<string, int> word in topWordsUsing)
            {
                res.Append($"\n{word.Key} {word.Value}");
            }

            res.Append("\n\nAll words: \n" +
                "Word Using");

            foreach (KeyValuePair<string, int> word in wordDictSorted)
            {
                res.Append($"\n{word.Key} {word.Value}");
            }

            return res.ToString();
        }
    }
}
