using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            //edge conditions
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }

            int len = s.Length;
            int head = 0;
            int tail = len - 1;
            while (head < tail)
            {
                if (!char.IsLetterOrDigit(s[head]))
                {
                    head++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[tail]))
                {
                    tail--;
                    continue;
                }
                if (char.ToLower(s[head]) != char.ToLower(s[tail]))
                {
                    return false;
                }
                head++;
                tail--;
            }
            return true;
        }
    }
}
