using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class CountAndSay1
    {
        public static string CountAndSay(int n)
        {
            String str = "1";
            for (int i = 1; i < n; i++)
            {
                str = CountAndSay(str);
            }
            return str;
        }

        public static string CountAndSay(String input)
        {
            //edge conditions
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            var sb = new StringBuilder();
            char prevCh = input[0];
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == prevCh)
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(prevCh);
                    prevCh = input[i];
                    count = 1;
                }
            }
            sb.Append(count);
            sb.Append(prevCh);
            return sb.ToString();
        }
    }
}
