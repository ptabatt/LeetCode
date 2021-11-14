using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeTwoSortedListsProblem
    {
        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode lMerged = null;

            while(l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        lMerged = SetMergedListNode(lMerged, l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        lMerged = SetMergedListNode(lMerged, l2.val);
                        l2 = l2.next;
                    }
                }

                if (l1 == null)
                {
                    while (l2 != null)
                    {
                        lMerged = SetMergedListNode(lMerged, l2.val);
                        l2 = l2.next;
                    }
                }

                if (l2 == null)
                {
                    while (l1 != null)
                    {
                        lMerged = SetMergedListNode(lMerged, l1.val);
                        l1 = l1.next;
                    }
                }
            }

            return lMerged;
        }

        private ListNode SetMergedListNode(ListNode lMerged, int val)
        {
            ListNode temp = null;

            if (lMerged == null)
            {
                lMerged = new ListNode(val);
            }
            else if (lMerged.next == null)
            {
                lMerged.next = new ListNode(val);
            }
            else
            {
                temp = lMerged.next;

                while (temp != null)
                {
                    if (temp.next == null)
                    {
                        temp.next = new ListNode(val);
                        break;
                    }

                    temp = temp.next;
                }
            }

            return lMerged;
        }
    }
}
