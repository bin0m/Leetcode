using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class StringToIntegerAtoi
    {
        public static int MyAtoi(string str)
        {
            int len = str.Length;
            int i = 0;
            while (i < len && str[i] == ' ')
            {
                i++;
            }

            if (i == len)
            {
                return 0;
            }

            bool isNegative = false;
            if (str[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (str[i] == '+')
            {
                i++;
            }
            int start = i;

            while (i < len && str[i] >= '0' && str[i] <= '9')
            {
                i++;
            }

            if (start == i)
            {
                return 0;
            }

            int x = 0;

            if (Int32.TryParse(str.Substring(start, i - start), out x))
            {
                return isNegative ? -x : x;
            }
            else
            {
                return isNegative ? Int32.MinValue : Int32.MaxValue;
            }
        }
    }
}
