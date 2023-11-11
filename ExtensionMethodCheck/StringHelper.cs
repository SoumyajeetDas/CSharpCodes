using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodCheck
{
    public static class StringHelper
    {
        public static string FirstLetterString(this string s)
        {
            string k;
            if(Char.IsLower(s[0]))
            {
                k = Char.ToUpper(s[0]) + s.Substring(1);
                return k;
            }

            else
            {
                return s;
            }
        }

        public static string CheckLength(this string s,int len)
        {
            if(s.Length==len)
            {
                return "Same";
            }
            else if(s.Length>len)
            {
                return "Length smaller than string length";
            }
            else
            {
                return "Length greater than string length";
            }
        }
    }
}
