using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Array;

namespace LeetCode
{
    class Program
    {
        static int[] ConvertToArray(string str)
        {
            int[] arr =  str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return arr;
        }

        static void Main(string[] args)
        {
            int result = BestTimetoBuyandSellStockII.MaxProfit(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result},expected=7");

            bool result2 = ContainsDuplicates.ContainsDuplicate(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result2},expected=False");

            int result4 = SingleNumber1.SingleNumber(ConvertToArray("4,1,2,1,2"));
            Console.WriteLine($"result={result4},expected=4");


            int[] result5 = IntersectionOfTwoArraysII.Intersect(ConvertToArray("1,2,2,1"), ConvertToArray("2,2"));
            Console.WriteLine($"result=[{String.Join(",",result5)}],expected=[2,2]");

            Console.ReadLine();
        }
    }
}
