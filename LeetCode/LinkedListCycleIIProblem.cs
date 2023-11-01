using System.Collections.Generic;

namespace LeetCode
{
    // https://leetcode.com/problems/linked-list-cycle-ii/description/
    public class LinkedListCycleIIProblem
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var dct = new Dictionary<ListNode, int>();

            while (head.next != null)
            {
                dct[head] = 1;

                if (dct.ContainsKey(head.next))
                {
                    return head.next;
                }

                head = head.next;
            }

            return null;
        }
    }
}
