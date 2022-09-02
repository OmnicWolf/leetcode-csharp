using System;
namespace Leetcode.DataStuctures
{
    public class DoublyMultilevelNode
    {
        public int val;
        public DoublyMultilevelNode next;
        public DoublyMultilevelNode prev;
        public DoublyMultilevelNode child;

        // #region Constructors

        public DoublyMultilevelNode()
            : this(-1)
        { }

        public DoublyMultilevelNode(int val)
            : this(val, null, null, null)
        { }

        public DoublyMultilevelNode(int val, DoublyMultilevelNode next)
            : this(val, next, null, null)
        { }

        public DoublyMultilevelNode(int val, DoublyMultilevelNode next, DoublyMultilevelNode prev)
            : this(val, next, prev, null)
        { }

        public DoublyMultilevelNode(int val, DoublyMultilevelNode next, DoublyMultilevelNode prev, DoublyMultilevelNode child)
        {
            this.val = val;
            this.next = next;
            this.prev = prev;
            this.child = child;
        }

        // #endRegion
    }
}
