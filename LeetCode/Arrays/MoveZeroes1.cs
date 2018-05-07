using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class MoveZeroes1
    {
        public static void MoveZeroes(int[] nums)
        {
            int size = nums.Length;
            if (size > 1)
            {
                int zeroCount = 0;
                for (int i = 0; i < size; i++)
                {
                    if (nums[i] == 0)
                    {
                        zeroCount++;
                    }
                    else if (zeroCount > 0)
                    {
                        nums[i - zeroCount] = nums[i];
                        nums[i] = 0;
                    }
                }

            }
        }
    }
}
