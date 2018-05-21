using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Arrays;
using LeetCode.Strings;
using LeetCode.LinkedLists;

namespace LeetCode
{
    class Program
    {
        static int[] ConvertToArray(string str)
        {
            int[] arr =  str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return arr;
        }

        static ListNode ConvertToListNode(string str)
        {
            ListNode head = new ListNode(0) ;
            ListNode pointer = head;
            foreach (int item in str.Split(',').Select(n => Convert.ToInt32(n)))
            {
                pointer.next = new ListNode(item);
                pointer = pointer.next;
            }
            pointer.next = null;
            return head.next;
        }

        static string ListNodeToString(ListNode ln)
        {
            ListNode pointer = ln;
            StringBuilder sb = new StringBuilder();
            while (pointer != null)
            {
                sb.Append(pointer.val);
                sb.Append(',');
                pointer = pointer.next;
            }

            return sb.ToString(0, sb.Length - 1);
        }

        static void Main(string[] args)
        {
            int result = BestTimetoBuyandSellStockII.MaxProfit(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result},expected=7");

            bool result2 = ContainsDuplicates.ContainsDuplicate(ConvertToArray("7,1,5,3,6,4"));
            Console.WriteLine($"result={result2},expected=False");

            var result3 = ConvertToArray("1,2,3,4,5,6");
            RotateArray.Rotate(result3, 4);
            Console.WriteLine(string.Join(",", result3));

            int result4 = SingleNumber1.SingleNumber(ConvertToArray("4,1,2,1,2"));
            Console.WriteLine($"result={result4},expected=4");


            int[] result5 = IntersectionOfTwoArraysII.Intersect(ConvertToArray("1,2,2,1"), ConvertToArray("2,2"));
            Console.WriteLine($"result=[{String.Join(",",result5)}],expected=[2,2]");

            int[] result6 = PlusOne1.PlusOne(ConvertToArray("2,9"));
            Console.WriteLine($"result=[{String.Join(",", result6)}],expected=[3,0]");

            int[] result7 = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes1.MoveZeroes(result7);
            Console.WriteLine($"result=[{String.Join(",", result7)}],expected=[1,3,12,0,0]");

            string result8 = ReverseString1.ReverseString("hello");
            Console.WriteLine($"result=[{result8}],expected=[olleh]");

            int result9 = ReverseInteger1.Reverse(-123456);
            Console.WriteLine($"result=[{result9}],expected=[-654321]");

            int result10 = FirstUniqueCharacterInAString.FirstUniqChar("abcdabb");
            Console.WriteLine($"result=[{result10}],expected=[2]");

            bool result11 = ValidAnagram.IsAnagram("anagram", "nagaram");
            Console.WriteLine($"result=[{result11}],expected=[True]");

            bool result12 = ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine($"result=[{result12}],expected=[True]");

            int result13 = StringToIntegerAtoi.MyAtoi("  -4193 with words");
            Console.WriteLine($"result=[{result13}],expected=[-4193]");

            int[] result14 = TwoSum1.TwoSum(ConvertToArray("2,11,6,3"),14);
            Console.WriteLine($"result =[{ String.Join(",", result14)}],expected =[1,3]");

            string result15 = LongestCommonPrefix1.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine($"result=[{result15}],expected =[fl]");

            ListNode result16 = RemoveNthFromEndOfList.RemoveNthFromEnd(ConvertToListNode("1,2,3,4,5"), 2);
            Console.WriteLine($"result=[{ListNodeToString(result16)}],expected =[1,2,3,5]");

            ListNode result17 = ReverseLinkedList.ReverseList(ConvertToListNode("1,2,3,4,5"));
            Console.WriteLine($"result=[{ListNodeToString(result17)}],expected =[5,4,3,2,1]");

            Console.ReadLine();
        }
    }
}
