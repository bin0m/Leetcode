using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class IntersectionOfTwoArraysII
    {
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
    }
}
