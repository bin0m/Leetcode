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
            // edge cases, x is not palindrome when:
            // - negative number
            // - or last digit is 0 (but not when x==0 )
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            //Solution A: using string
            //string str = x.ToString();
            //int head = 0;
            //int tail = str.Length - 1;
            //while (head < tail)
            //{
            //    if (str[head] != str[tail])
            //    {
            //        return false;
            //    }
            //    head++;
            //    tail--;
            //}
            //return true;

            //Solution B: using Math
            if (x < 0)
            {
                return false;
            }
            int reverseNum = 0;
            int n = x;
            while (n > reverseNum)
            {
                int lastDigit = n % 10;
                reverseNum = reverseNum * 10 + lastDigit;
                n = (int)(n / 10);
            }
            return n == reverseNum || n == reverseNum /10;            
        }
    }
}
