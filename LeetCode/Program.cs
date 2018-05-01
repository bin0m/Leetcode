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
        }
    }
}
