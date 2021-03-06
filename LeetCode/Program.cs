﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static int[] ConvertToArray(string str)
        {
            int[] arr =  str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return arr;
        }

        static String ListOfListsToString(IList<IList<int>> lists)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            foreach (var list in lists)
            {
                sb.Append('[').Append(String.Join(",", list)).Append("],");
            }
            sb.Append(']');
            return sb.ToString();
        }


        static void Main(string[] args)
        {
            int result = Arrays.MaxProfit(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result},expected=7");

            bool result2 = Arrays.ContainsDuplicate(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result2},expected=False");

            var result3 = ConvertToArray("1,2,3,4,5,6");
            Arrays.Rotate(result3, 4);
            Console.WriteLine($"result=[{string.Join(",", result3)}],expected=[3,4,5,6,1,2]");

            int result4 = Arrays.SingleNumber(ConvertToArray("4,1,2,1,2"));
            Console.WriteLine($"result={result4},expected=4");

            int[] result5 = Arrays.Intersect(ConvertToArray("1,2,2,1"), ConvertToArray("2,2"));
            Console.WriteLine($"result=[{String.Join(",",result5)}],expected=[2,2]");

            int[] result6 = Arrays.PlusOne(ConvertToArray("2,9"));
            Console.WriteLine($"result=[{String.Join(",", result6)}],expected=[3,0]");

            int[] result7 = new int[] { 0, 1, 0, 3, 12 };
            Arrays.MoveZeroes(result7);
            Console.WriteLine($"result=[{String.Join(",", result7)}],expected=[1,3,12,0,0]");

            string result8 = Strings.ReverseString("hello");
            Console.WriteLine($"result=[{result8}],expected=[olleh]");

            int result9 = Strings.Reverse(-123456);
            Console.WriteLine($"result=[{result9}],expected=[-654321]");

            int result10 = Strings.FirstUniqChar("abcdabb");
            Console.WriteLine($"result={result10},expected=2");

            bool result11 = Strings.IsAnagram("anagram", "nagaram");
            Console.WriteLine($"result={result11},expected=True");

            bool result12 = Strings.IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine($"result={result12},expected=True");

            int result13 = Strings.MyAtoi("  -4193 with words");
            Console.WriteLine($"result=[{result13}],expected=[-4193]");

            int[] result14 = Arrays.TwoSum(ConvertToArray("2,11,6,3"),14);
            Console.WriteLine($"result=[{ String.Join(",", result14)}],expected =[1,3]");

            string result15 = Strings.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine($"result=[{result15}],expected =[fl]");

            LinkedLists.ListNode result16 = LinkedLists.RemoveNthFromEnd(LinkedLists.ConvertToListNode("1,2,3,4,5"), 2);
            Console.WriteLine($"result=[{LinkedLists.ListNodeToString(result16)}],expected =[1,2,3,5]");

            LinkedLists.ListNode result17 = LinkedLists.ReverseList(LinkedLists.ConvertToListNode("1,2,3,4,5"));
            Console.WriteLine($"result=[{LinkedLists.ListNodeToString(result17)}],expected =[5,4,3,2,1]");

            bool result18 = Strings.IsPalindrome(121);
            Console.WriteLine($"result={result18},expected=True");

            LinkedLists.ListNode result19 = LinkedLists.MergeTwoLists(
                LinkedLists.ConvertToListNode("1,2,4"), 
                LinkedLists.ConvertToListNode("1,3,4"));
            Console.WriteLine($"result=[{LinkedLists.ListNodeToString(result19)}],expected =[1,1,2,3,4,4]");

            String result20 = Strings.CountAndSay(6);
            Console.WriteLine($"result={result20},expected=312211");

            bool result21 = LinkedLists.IsPalindrome(LinkedLists.ConvertToListNode("1,2,3,2,1"));
            Console.WriteLine($"result=[{result21}],expected =[True]");

            bool result22 = LinkedLists.IsPalindrome2(LinkedLists.ConvertToListNode("1,2,3, 2,1"));
            Console.WriteLine($"result=[{result22}],expected =[True]");

            int result23 = Trees.MaxDepth(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Console.WriteLine($"result=[{result23}],expected =[3]");

            bool result24 = Trees.IsValidBST(Trees.CreateBinaryTree(new int?[] { 5, 1, 4, null, null, 3, 6 }));
            Console.WriteLine($"result=[{result24}],expected =[False]");

            bool result25 = Trees.IsSymmetric(Trees.CreateBinaryTree(new int?[] {1, 2, 2, 3, 4, 4, 3}));
            Console.WriteLine($"result=[{result25}],expected =[True]");

            var result26 = Trees.LevelOrder(Trees.CreateBinaryTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Console.WriteLine($"result={ListOfListsToString(result26)},expected = [[3],[9,20],[15,7]]");

            var result27 = Trees.TreeNodeToString(Trees.CreateBinaryTree(new int?[] {3, 9, 20, null, null, 15, 7}));
            Console.WriteLine($"result={result27},expected = [3,9,20,null,null,15,7,null,null,null,null,]");

            Trees.TreeNode result28 = Trees.SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });
            Console.WriteLine($"result={Trees.TreeNodeToString(result28)},expected = [0,-10,5,null,-3,null,9,null,null,null,null,]");

            var result29 = new[] {1, 2, 3, 0, 0, 0};
            Arrays.MergeSorted(result29, 3, new[] { 2, 5, 6 }, 3);
            Console.WriteLine($"result=[{string.Join(",", result29)}],expected=[1,2,2,3,5,6]");
          
            LinkedLists.ListNode result30 = LinkedLists.AddTwoNumbers(
                LinkedLists.ConvertToListNode("1,9,9"),
                LinkedLists.ConvertToListNode("9"));
            Console.WriteLine($"result=[{LinkedLists.ListNodeToString(result30)}],expected =[0,0,0,1]");

            int result31 = Strings.LengthOfLongestSubstring("peerpe");
            Console.WriteLine($"result={result31},expected=3");

            Console.WriteLine($"result={Strings.RomanToInt("LVIII")},expected=58");
            Console.WriteLine($"result={Strings.RomanToInt("MCMXCIV")},expected=1994");

            Console.WriteLine($"result=[{ListOfListsToString(Arrays.FourSum(new[] { 1, 0, -1, 0, -2, 2 }, 0))}],expected=[[-1, 0, 0, 1],[-2, -1, 1, 2],[-2, 0, 0, 2]]");

            Console.WriteLine($"result={DynamicProgramming.ClimbStairs(5)},expected=8");

            Console.WriteLine($"result={Strings.LongestPalindrome("cbbd")},expected=cbbd");

            Console.ReadLine();
        }
    }
}
