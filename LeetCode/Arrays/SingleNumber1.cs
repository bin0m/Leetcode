using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class SingleNumber1
    {
        public static int SingleNumber(int[] nums)
        {
            int size = nums.Length;
            if (size == 1)
            {
                return nums[0];
            }
            int xorSum = nums[0];
            for (int i = 1; i < size; i++)
            {
                xorSum = xorSum ^ nums[i];
            }
            return xorSum;
        }
    }
}
