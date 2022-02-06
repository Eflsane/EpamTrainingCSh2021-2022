using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1_1
{
    static class NameGenerator
    {
        private static string[] _nameList = new string[] 
        { "Frederik", "Mimodoshichitokufu", "Ilta", "Gal", "Sascha", "Geordi", "Biikti", "Carlos", "Milenko", "Cole",
            "Girma", "Jason", "Frithjof", "Eija", "Kalamar", "Azzu"
        };

        private static readonly int _minRandomNameLength  = 2;
        private static readonly int _maxRandomNameLength = 16;

        private static readonly Random _rand = new Random();

        public static string GenerateName()
        {
            return _nameList[_rand.Next(0, _nameList.Length)];
        }

        public static string GenerateAbsoluteRandomName()
        {
            StringBuilder name = new StringBuilder();
            int nameLength = _rand.Next(_minRandomNameLength, _maxRandomNameLength + 1);

            for(int i = 0; i < nameLength; i++)
            {
                name.Append((char)_rand.Next((int)'a', (int)'z'));
            }

            return name.ToString();
        }
    }
}
