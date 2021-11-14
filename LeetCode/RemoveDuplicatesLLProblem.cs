using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveDuplicatesLLProblem
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode prev = head;
            ListNode current = prev == null ? null : prev.next;

            while(current != null)
            {
                if (current.val == prev.val)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = current;
                }

                current = current.next;
            }

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
