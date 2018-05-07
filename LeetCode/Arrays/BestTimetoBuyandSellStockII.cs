using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class BestTimetoBuyandSellStockII
    {
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
    }
}
