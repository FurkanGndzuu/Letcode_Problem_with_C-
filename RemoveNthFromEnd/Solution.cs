using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthFromEnd
{
    public static class Solution
    {
        public static ListNode result(ListNode head , int n)
        {
            ListNode current = head;

            if(n == 1 && current.next != null)
            {
                head = current.next;
                current = null;
            }
            else
            {
                int i = 1;
                ListNode prev = null;
                while (i <= n && current != null)
                {
                     prev = current;
                    current = current.next;
                    i++;
                }
                prev.next = current.next;
            }

            return head;
        }
    }
}
