using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class RotateArray
    {
        //In place (without using additional array)
        public static void Rotate(int[] nums, int k)
        {
            int size = nums.Length;
            if (size <= 1 || k <= 0)
            {
                return;
            }

            int shift = k % size;

            Dictionary<int,int> dict = new Dictionary<int, int>();

            for (int i = 0; i < size; i++)
            {
                int to = (i + shift) % size;
                if (i < to)
                {
                    dict.Add(i, nums[i]);
                }
                int from = (i - shift + size) % size;
                if (!dict.TryGetValue(from, out var fromVal))
                {
                    fromVal = nums[from];
                }

                nums[i] = fromVal;
            }

        }
    }
}
