using System;

using Leetcode.DataStuctures;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListNode ls1 = new ListNode(2);
            ls1.next = new ListNode(5);
            ls1.next.next = new ListNode(8);

            Console.WriteLine(ls1.ToStringAllNodes());

            ListNode ls2 = new ListNode(2,4,6,8,10);

            Console.WriteLine(ls2.ToStringAllNodes());
            Console.WriteLine(ls2.ToStringTillNthNode(3));
        }
    }
}
