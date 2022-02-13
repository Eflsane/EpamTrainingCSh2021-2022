using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_2
{
    public static class StringExtensions
    {
        public static LanguageType WhatLanguageItIs(this string s)
        {
            bool isEnglish = false;
            bool isRussian = false;
            bool isNubers = false;

            IEnumerable<char> eng = s.Where(ch => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
            isEnglish = eng.Count() > 0;

            IEnumerable<char> rus = s.Where(ch => (ch >= 'а' && ch <= 'я')
                    || (ch >= 'А' && ch <= 'Я')
                    || (ch == 'ё' || ch == 'Ё'));
            isRussian = rus.Count() > 0;

            IEnumerable<char> nums = s.Where(ch => (ch >= '0' && ch <= '9'));
            isNubers = nums.Count() > 0;

            if((isEnglish & isRussian & isNubers)
                ||(isEnglish & isRussian & !isNubers)
                ||(isEnglish & !isRussian & isNubers)
                || (!isEnglish & isRussian & isNubers))
                    return LanguageType.Mixed;

            if (isEnglish)
                return LanguageType.English;

            if (isRussian)
                return LanguageType.Russian;

            if (isNubers)
                return LanguageType.Numbers;

            return LanguageType.Mixed;
        }
    }

    public enum LanguageType
    {
        Null = 0,
        English = 1,
        Russian = 2,
        Numbers = 4,
        Mixed = 8,
    }
}
