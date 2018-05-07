using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class PlusOne1
    {
        public static int[] PlusOne(int[] digits)
        {
            int size = digits.Length;
            if (size == 0)
            {
                return digits;
            }

            int[] bigger = new int[size + 1];

            for (int i = size - 1; i >= 0; i--)
            {
                if (i == 0 && digits[0] == 9)
                {
                    bigger[1] = 0;
                    bigger[0] = 1;
                    return bigger;

                }
                else if (digits[i] == 9)
                {
                    digits[i] = 0;
                    bigger[i + 1] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }


            }
            return digits;

        }
    }
}
