using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class ReverseInteger1
    {
        public static int Reverse(int x)
        {
            bool isNegative = false;
            if (x < 0)
            {
                if (x == int.MinValue)
                {
                    return 0;
                }
                x = x * (-1);
                isNegative = true;
            }
            var ch = x.ToString().ToCharArray();
            Array.Reverse(ch);
            try
            {
                var ans = Convert.ToInt32(new String(ch));

                if (isNegative)
                {
                    ans *= (-1);
                }
                return ans;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
