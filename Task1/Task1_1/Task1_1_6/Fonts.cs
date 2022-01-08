using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1_6
{
    public static class Fonts
    {
        static public bool IsBold { get; private set; }
        static public bool IsItalic { get; private set; }
        static public bool IsUnderline { get; private set; }
        
        public static void AdjustFont(FontsAdjusts adjusts)
        {
            switch(adjusts)
            {
                case FontsAdjusts.bold:
                    IsBold = !IsBold;
                    break;
                case FontsAdjusts.italic:
                    IsItalic = !IsItalic;
                    break;
                case FontsAdjusts.underline:
                    IsUnderline = !IsUnderline;
                    break;
                default:
                    break;
            }
        }

        public static string ToString()
        {
            string res = "";
            if (IsBold) res += FontsAdjusts.bold.ToString() + " ";
            if (IsItalic) res += FontsAdjusts.italic.ToString() + " ";
            if(IsUnderline) res += FontsAdjusts.underline.ToString();

            return res;
        }

    }

    public enum FontsAdjusts
    {
        bold,
        italic,
        underline
    }
}
