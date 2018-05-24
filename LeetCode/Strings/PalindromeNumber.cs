using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string str = x.ToString();
            int head = 0;
            int tail = str.Length - 1;
            while (head < tail)
            {
                if (str[head] != str[tail])
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
