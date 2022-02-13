using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_2
{
    class WordDictWrapper
    {
        private Dictionary<string, int> _uniqueWords;
        public int Count { get => _uniqueWords.Count; }

        public WordDictWrapper()
        {
            _uniqueWords = new Dictionary<string, int>();
        }

        public bool ContainsKey(string key)
        {
            return _uniqueWords.ContainsKey(key);
        }

        public void AddKey(string key, int value)
        {
            _uniqueWords.Add(key, value);
        }

        public bool TryGetValue(string key, out int value)
        {
            return _uniqueWords.TryGetValue(key, out value); 
        }

        public void SetValue(string key, int value)
        {
            _uniqueWords["key"] = value;
        }

        public int GetValue(string key)
        {
            return _uniqueWords["key"];
        }

        public string ShowAsString()
        {
            StringBuilder res = new StringBuilder();
            foreach(KeyValuePair<string, int> s in _uniqueWords)
            {
                res.Append($"{s.Key} is used: {s.Value}");
            }

            return res.ToString();
        }
    }
}
