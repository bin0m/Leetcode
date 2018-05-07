using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class ReverseString1
    {
        public static string ReverseString(string s)
        {
            //var res = new char[s.Length];
            //for (var i = 0; i < s.Length; i++)
            //    res[i] = s[s.Length - 1 - i];
            //return new string(res);

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}
