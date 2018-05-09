using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            //edge conditions
            if ((s == null && t == null) || (s.Length == 0 && t.Length == 0))
            {
                return true;
            }
            if (s.Length != t.Length)
            {
                return false;
            }

            var charCount = new int[128];
            foreach (char c in s)
            {
                charCount[(int)c]++;
            }
            foreach (char c in t)
            {
                charCount[(int)c]--;
            }
            foreach (int n in charCount)
            {
                if (n != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
