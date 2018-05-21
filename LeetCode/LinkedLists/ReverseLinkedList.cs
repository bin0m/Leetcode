using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedLists
{
    public class ReverseLinkedList
    {
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
    }
}
