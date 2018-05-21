using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedLists
{
    public class RemoveNthFromEndOfList
    {

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

    }
}
