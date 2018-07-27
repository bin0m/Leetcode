using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DynamicProgramming
    {
        public static int ClimbStairs(int n)
        {
            //Input: 4
            // 1 + 1 + 1 + 1
            // 1 + 2 + 1
            // 1 + 1 + 2
            // 2 + 1 + 1
            // 2 + 2 
            //Output: 5
            int[] arr = new int[n + 1];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }
    }
}
