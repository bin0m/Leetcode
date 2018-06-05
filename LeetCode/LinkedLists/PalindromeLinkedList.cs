using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedLists
{
    public class PalindromeLinkedList
    {
       
        public static bool IsPalindrome(ListNode head)
        {
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
            while (p1 != null || p2 != null)
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
