using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_1ClassLib
{
    public class CustomString
    {
        private char[] _charString;

        public int Length { get => _charString.Length; }

        public char this[int index]
        {
            get => _charString[index];
            set => _charString[index] = value;
        }

        public CustomString()
        {
            _charString = new char[0];
        }


        public CustomString(params char[] symbols)
        {
            _charString = new char[symbols.Length];

            for (int i = 0; i < _charString.Length; i++)
            {
                _charString[i] = symbols[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj)) return true;
            if (!(obj is CustomString) || obj == null) return false;
            if (this.Length != ((CustomString)obj).Length) return false;

            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != ((CustomString)obj)[i]) return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = -124817528;
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(_charString);
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < Length; i++)
                str.Append(_charString[i]);

            return str.ToString();
        }

        public void Add(char symbol)
        {
            char[] newCharString = new char[_charString.Length + 1];
            for (int i = 0; i < _charString.Length; i++)
            {
                newCharString[i] = _charString[i];
            }
            newCharString[newCharString.Length - 1] = symbol;

            _charString = newCharString;
        }

        public static CustomString Concat(CustomString cs1, CustomString cs2)
        {
            if (cs1 == null || cs2 == null) throw new ArgumentException("cs1 and cs2 must be not null");

            char[] concatedCharArr = new char[cs1.Length + cs2.Length];

            int counter = 0;
            while (counter < cs1.Length)
            {
                concatedCharArr[counter] = cs1[counter];
                counter++;
            }

            while (counter < cs1.Length + cs2.Length)
            {
                concatedCharArr[counter] = cs2[counter - cs2.Length];
                counter++;
            }

            return new CustomString(concatedCharArr);
        }

        public int FindSymbol(char symbol)
        {
            for(int i = 0; i < Length; i++)
            {
                if (this[i] == symbol) return i;
            }

            return -1;
        }

        public char[] ConvertToCharArray()
        {
            if (_charString == null) return null;

            char[] returnableArray = new char[Length];
            for (int i = 0; i < Length; i++)
                returnableArray[i] = this[i];

            return returnableArray;
        }

        public void ConvertFromCharArray(char[] charArray)
        {
            if (charArray == null) throw new ArgumentException("charArray must be not null");

            _charString = new char[charArray.Length];

            for (int i = 0; i < _charString.Length; i++)
            {
                _charString[i] = charArray[i];
            }
        }

        public void ConvertFromString(string s)
        {
            _charString = s.ToCharArray();
        }

        public static CustomString operator +(CustomString cs1, CustomString cs2)
        {
            return Concat(cs1, cs2);
        }

        public static CustomString operator *(CustomString customStringToMultiply, int times)
        {
            char[] multipliedCharArr = new char[customStringToMultiply.Length * times];

            int counter = 0;
            for(int i = 0; i < times; i ++)
            {
                for (int j = 0; j < customStringToMultiply.Length; j++)
                {
                    multipliedCharArr[counter] = customStringToMultiply[j];

                    counter++;
                }
            }
            
            
            return new CustomString(multipliedCharArr);
        }
    }
}
