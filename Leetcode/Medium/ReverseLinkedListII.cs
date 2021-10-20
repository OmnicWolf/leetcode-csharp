using Leetcode.DataStuctures;

namespace Leetcode.Medium
{
    /*
     * Problem: 92. Reverse Linked List II
     * 
     * Difficulty: Medium
     * Acceptance Rate: 42.5%
     * 
     * URL: https://leetcode.com/problems/reverse-linked-list-ii/
     */
    public class ReverseLinkedListII
    {
        /* Runtime: 84 ms, faster than 92.62% of C# online submissions for Reverse Linked List II.
         * Memory Usage: 35.8 MB, less than 13.23% of C# online submissions for Reverse Linked List II.
         */
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right || head == null) return head;

            ListNode anchor = new ListNode(-1, head);

            ListNode leftSegmentTail = anchor;
            
            for (int i=1; i < left; ++i) leftSegmentTail = leftSegmentTail.next;  // Position pointer just before the reversal area

            ListNode reversedSegmentTail = leftSegmentTail.next;
            ListNode shifting = reversedSegmentTail.next;           // Shifting node will be moved to the start of the reversal area

            for(int i=0; i < right-left; ++i)
            {
                reversedSegmentTail.next = shifting.next;
                shifting.next = leftSegmentTail.next;
                leftSegmentTail.next = shifting;                    // Shifting node moved to beginning of reversal area

                shifting = reversedSegmentTail.next;                // Update pointer to next node to shift
            }

            return anchor.next;
        }
    }
}

/* 
 * Why insert an anchor node before head?
 * 
 * It's an elegant solution for the edge case where 'm (left)' is the first node.
 * With an anchor, the list is guaranteed to have a left segment before the reversal area
 * to allow the shifting node to move up front.
 */
