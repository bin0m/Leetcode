using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedLists
{
    public class RemoveNthFromEndOfList
    {

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;
            var pointer = head;
            while (pointer != null)
            {
                pointer = pointer.next;
                count++;
            }
            pointer = head;
            int i = 0;
            while (i < count - n)
            {
                pointer = pointer.next;
                count++;
            }
            pointer.next = pointer.next.next;
            return head;

        }
        
    }
}
