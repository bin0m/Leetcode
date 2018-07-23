using System;
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

        //Merge Sorted Array
        public static void MergeSorted(int[] nums1, int m, int[] nums2, int n)
        {
            int i = nums1.Length - 1;
            m--;
            n--;
            while (m >= 0 && n >= 0)
            {
                if (nums1[m] > nums2[n])
                {
                    nums1[i--] = nums1[m--];
                }
                else
                {
                    nums1[i--] = nums2[n--];
                }
            }
            while (n >= 0)
            {
                nums1[i--] = nums2[n--];
            }
        }

        //First Bad Version
        public static int FirstBadVersion(int n, bool[] arr)
        {
            bool found = new bool();
            int from = 0;
            int mid = 0;
            while (from < n)
            {
                if (found)
                {
                    n = mid;
                    mid = (from + n) / 2;
                }
                else
                {
                    from = mid + 1;
                    mid = (from + n) / 2;
                }
                found = arr[mid];
            }
            return mid;
        }

        //4Sum
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            HashSet<IList<int>> ans = new HashSet<IList<int>>();
            var sumOfPairs = new Dictionary<int, HashSet<Tuple<int, int>>>();
            var frequencies = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequencies.ContainsKey(num))
                {
                    frequencies[num]++;
                }
                else
                {
                    frequencies[num] = 1;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    var pair = new Tuple<int, int>(nums[i], nums[j]);
                    if (sumOfPairs.ContainsKey(sum))
                    {
                        if (!sumOfPairs[sum].Contains(new Tuple<int, int>(nums[j], nums[i])))
                        {
                            sumOfPairs[sum].Add(pair);
                        }
                    }
                    else
                    {
                        sumOfPairs.Add(sum, new HashSet<Tuple<int, int>> { pair });
                    }
                }
            }

            foreach (var pairSum in sumOfPairs)
            {
                int complement = target - pairSum.Key;
                if (sumOfPairs.ContainsKey(complement))
                {
                    foreach (Tuple<int, int> pair1 in sumOfPairs[complement])
                    {
                        foreach (Tuple<int, int> pair2 in pairSum.Value)
                        {
                            if (pair1.Item1 == pair2.Item1 || pair1.Item1 == pair2.Item2)
                            {
                                if (frequencies[pair1.Item1] < 2)
                                {
                                    continue;
                                }
                            }
                            if (pair1.Item2 == pair2.Item1 || pair1.Item2 == pair2.Item2)
                            {
                                if (frequencies[pair1.Item2] < 2)
                                {
                                    continue;
                                }
                            }
                            var sumOfFour = new List<int>() { pair1.Item1, pair1.Item2, pair2.Item1, pair2.Item2 };
                            sumOfFour.Sort();
                            ans.Add(sumOfFour);
                        }
                    }
                    sumOfPairs[complement].Clear();
                    pairSum.Value.Clear();
                }
            }

            return ans.ToList();

        }
    }
}
