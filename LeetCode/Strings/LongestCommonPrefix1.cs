using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class LongestCommonPrefix1
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string lcp = "";
            if (strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                char ch = strs[0][i];
                foreach (string str in strs)
                {
                    if (str.Length <= i || str[i] != ch)
                    {
                        return lcp;
                    }
                }
                lcp = strs[0].Substring(0, i + 1);
            }
            return lcp;
        }
    }
}
