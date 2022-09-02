using System;

using Leetcode.DataStuctures;

namespace Leetcode.Medium
{
    public class FlattenMultilevelDoublyLinkedList
    {
        public static DoublyMultilevelNode Flatten(DoublyMultilevelNode head)
        {
            DoublyMultilevelNode currNode = head, resumeAt, tailOfFlattened;

            while(currNode != null)
            {
                if(currNode.child != null)
                {
                    resumeAt = currNode.next;
                    currNode.child.prev = currNode;
                    currNode.next = currNode.child;
                    currNode.child = null;

                    tailOfFlattened = FlattenChild(currNode.next);
                    tailOfFlattened.next = resumeAt;

                    if (resumeAt != null)
                    {
                        resumeAt.prev = tailOfFlattened;
                        currNode = resumeAt;
                    }
                    else
                    {
                        currNode = tailOfFlattened;
                    }
                }
                else
                {
                    currNode = currNode.next;
                }
            }

            return head;
        }

        private static DoublyMultilevelNode FlattenChild(DoublyMultilevelNode head)
        {
            DoublyMultilevelNode currNode = head, resumeAt, tailOfFlattened;

            do
            {
                if (currNode.child != null)
                {
                    resumeAt = currNode.next;
                    currNode.child.prev = currNode;
                    currNode.next = currNode.child;
                    currNode.child = null;

                    tailOfFlattened = FlattenChild(currNode.next);
                    tailOfFlattened.next = resumeAt;

                    if (resumeAt != null)
                    {
                        resumeAt.prev = tailOfFlattened;
                        currNode = resumeAt;
                    }
                    else
                    {
                        currNode = tailOfFlattened;
                    }
                }
                else if (currNode.next == null)
                {
                    break;
                }
                else
                {
                    currNode = currNode.next;
                }

            } while (currNode.next != null);

            return currNode;    // tail of child list
        }
    }
}

// Test Case 1 - [1,2,3,4,5,6,null,null,null,7,8,9,10,null,null,11,12]
// test Case 2 - [1,2,null,3]
// Test Case 3 - [1,null,2,null,3,null]
// Test Case 4 - [1,2,3,4,5,6,null,null,null,7,8,null,null,11,12]