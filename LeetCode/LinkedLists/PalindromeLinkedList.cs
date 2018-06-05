using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedLists
{
    public class PalindromeLinkedList
    {
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
            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2. Revert the second half of the list
            ListNode revertedHalf = null;
            ListNode newHead = slow.next;
            ListNode temp = newHead;
            while(newHead != null)
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
