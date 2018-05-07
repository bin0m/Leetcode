using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    class ContainsDuplicates
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            int size = nums.Length;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < size; i++)
            {
                if (hs.Contains(nums[i]))
                {
                    return true;
                }
                hs.Add(nums[i]);
            }
            return false;
        }
    }
}
