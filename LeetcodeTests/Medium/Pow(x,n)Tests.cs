using System;

using Leetcode.Medium;
using static LeetcodeTests.Utility.Assertions;

namespace LeetcodeTests.Medium
{
    public class Pow_x_n_Tests
    {
        private static Pow_x_n pow = new Pow_x_n();

        private Pow_x_n_Tests() {}

        public static void Run()
        {
            Console.WriteLine("\nPow(x,n) Tests");
            Console.WriteLine(" - Pow(2.0, 10) : " + FormatTestResult(x_2_n_10()));
        }

        private static bool x_2_n_10()
        {
            return AssertEquals(1024.0, pow.calculate(2.0, 10));
        }
    }
}
