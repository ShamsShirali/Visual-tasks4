using System;
using System.Collections.Generic;
using System.Text;

namespace _14._02._23
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int objct)
        {
            if (objct % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int objctt)
        {
            if (objctt % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string str)
        {
            if (str == null)
            {
                return false;
            }

            for(int i=0;i<str.Length;i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if (str == null)
            {
                return "";
            }

            string capistr = char.ToUpper(str[0]) + str.Substring(1).ToLower();

            return capistr;
        }

        public static int[] GetValueIndexes(this string str,char cr)
        {
            int[] index = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==cr)
                {
                    Array.Resize(ref index, index.Length + 1);
                    index[index.Length - 1] =i;
                }
                
            }

            return index;
        }
    }
}
