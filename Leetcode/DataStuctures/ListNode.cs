using System.Text;

namespace Leetcode.DataStuctures
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(params int[] vals)
        {
            this.val = vals[0];

            ListNode currNode = this;

            for(int i=1; i < vals.Length; ++i)
            {
                currNode.next = new ListNode(vals[i]);
                currNode = currNode.next;
            }
        }

        public override string ToString()
        {
            return val + (next != null ? " -> " : "");
        }

        public string ToStringAllNodes()
        {
            StringBuilder sb = new StringBuilder();

            ListNode currNode = this;

            while (currNode != null)
            {
                sb.Append(currNode.ToString());
                currNode = currNode.next;
            }

            return sb.ToString();
        }

        public string ToStringTillNthNode(int n)
        {
            StringBuilder sb = new StringBuilder(n + " nodes: ");

            ListNode currNode = this;

            for (int i=0; i < n && currNode != null; ++i)
            {
                sb.Append(currNode.ToString());
                currNode = currNode.next;
            }

            return sb.ToString();
        }
    }
}
