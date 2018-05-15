using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class TwoSum1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int size = nums.Length;
            if (size == 2)
            {
                return new int[2] { 0, 1 };
            }
            int[] ans = new int[2];

            //Naive solution: Brute force O(N^2)
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
                }
            }
            return ans;
        }
    }
}
