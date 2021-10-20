using Leetcode.DataStuctures;

namespace Leetcode.Easy
{
    /*
     * Problem: 206. Reverse Linked List
     * 
     * Difficulty: Easy
     * Acceptance Rate: 68.1%
     * 
     * URL: https://leetcode.com/problems/reverse-linked-list/
     */
    public class ReverseLinkedList
    {
        /* Runtime: 76 ms, faster than 99.61% of C# online submissions for Reverse Linked List.
         * Memory Usage: 36.5 MB, less than 15.53% of C# online submissions for Reverse Linked List.
         */
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;


            ListNode headReverse = null;

            ListNode next;
            ListNode currNode = head;

            while (currNode != null)
            {
                next = currNode.next;
                currNode.next = headReverse;
                headReverse = currNode;
                currNode = next;
            }

            return headReverse;
        }
    }
}
