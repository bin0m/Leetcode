using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedLists
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    
        // Help function for testing
        internal static ListNode ConvertToListNode(string str)
        {
            ListNode head = new ListNode(0);
            ListNode pointer = head;
            foreach (int item in str.Split(',').Select(n => Convert.ToInt32(n)))
            {
                pointer.next = new ListNode(item);
                pointer = pointer.next;
            }
            pointer.next = null;
            return head.next;
        }

        // Help function for testing
        internal static string ListNodeToString(ListNode ln)
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


        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;
            var pointer = head;
            while (pointer != null)
            {
                pointer = pointer.next;
                count++;
            }

            if (count == n)
            {
                return head.next;
            }

            pointer = head;
            int i = 0;
            while (i < count - n - 1)
            {
                pointer = pointer.next;
                i++;
            }
            pointer.next = pointer.next.next;
            return head;
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode newHead = null;
            while (head != null)
            {
                ListNode save = head.next;
                head.next = newHead;
                newHead = head;
                head = save;
            }
            return newHead;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            ListNode MergeHead = new ListNode(-1);
            ListNode p = MergeHead;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    p.next = l2;
                    l2 = l2.next;
                }
                p = p.next;
            }

            if (l1 != null)
            {
                p.next = l1;
            }
            if (l2 != null)
            {
                p.next = l2;
            }

            return MergeHead.next;
        }

        // by using additonal space to create reverse List
        public static bool IsPalindrome(ListNode head)
        {
            // edge conditions
            if (head == null)
            {
                return true;
            }

            // 1.create reverse list by iterating through this list and create nodes from the tail
            ListNode reverseList = new ListNode(head.val);
            ListNode p1 = head.next;

            while (p1 != null)
            {
                ListNode newNode = new ListNode(p1.val);
                newNode.next = reverseList;
                reverseList = newNode;
                p1 = p1.next;
            }

            // 2. iterate through 2 lists and compare each node
            p1 = head;
            ListNode p2 = reverseList;
            while (p1 != null && p2 != null)
            {
                if (p1.val != p2.val)
                {
                    return false;
                }
                p2 = p2.next;
                p1 = p1.next;
            }
            return true;

        }

        // O(n) and without using additonal space 
        // revert the 2nd half of the list
        public static bool IsPalindrome2(ListNode head)
        {
            // edge conditions
            if (head == null)
            {
                return true;
            }

            // 1. locate the  middle Node
            ListNode fast = head;
            ListNode slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2. Revert the second half of the list
            ListNode revertedHalf = null;
            ListNode newHead = slow.next;
            ListNode temp = newHead;
            while (newHead != null)
            {
                newHead = newHead.next;
                temp.next = revertedHalf;
                revertedHalf = temp;
                temp = newHead;
            }

            // 3. iterate through 2 halves and compare each node
            ListNode p1 = head;
            ListNode p2 = revertedHalf;
            while (p1 != null && p2 != null)
            {
                if (p1.val != p2.val)
                {
                    return false;
                }
                p2 = p2.next;
                p1 = p1.next;
            }
            return true;
        }
        
    }
}
