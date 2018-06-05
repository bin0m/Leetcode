﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Arrays
    {
        // Best Time to Buy and Sell Stock II
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int delta = prices[i + 1] - prices[i];
                if (delta > 0)
                {
                    profit += delta;
                }
            }
            return profit;

        }

        // ContainsDuplicate
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

        //In place (without using additional array)
        public static void Rotate(int[] nums, int k)
        {
            int size = nums.Length;
            if (size <= 1 || k <= 0)
            {
                return;
            }

            int shift = k % size;

            Dictionary<int, int> dict = new Dictionary<int, int>();

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

        // Intersection Of Two Arrays II
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var ans = new List<int>();
            System.Array.Sort(nums1);
            System.Array.Sort(nums2);
            int size1 = nums1.Length;
            int size2 = nums2.Length;
            int minSize = Math.Min(size1, size2);
            int i = 0;
            int j = 0;
            int x = 0;
            while (i < size1 && j < size2)
            {
                if (nums1[i] == nums2[j])
                {
                    ans.Add(nums1[i]);
                    i++;
                    j++;
                    x++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return ans.ToArray<int>();
        }

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

        public static int[] TwoSum(int[] nums, int target)
        {
            int size = nums.Length;
            if (size == 2)
            {
                return new int[2] { 0, 1 };
            }
            int[] ans = new int[2];

            //Naive solution: Brute force O(N^2)
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            ans[0] = i;
            //            ans[1] = j;
            //            return ans;
            //        }
            //    }
            //}
            //return ans;


            // Time efficient solution (using hash)
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < size; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    ans[0] = dict[target - nums[i]];
                    ans[1] = i;
                    return ans;
                }
                dict[nums[i]] = i;
            }
            return ans;
        }
    }
}