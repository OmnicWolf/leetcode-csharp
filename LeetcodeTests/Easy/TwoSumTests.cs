using System;

using Leetcode.Easy;
using static LeetcodeTests.Utility.Assertions;

namespace LeetcodeTests.Easy
{
    public class TwoSumTests
    {
        private static TwoSum twoSum = new TwoSum();

        private TwoSumTests() {}

        public static void Run()
        {
            Console.WriteLine("\nTwo Sum Tests");
            Console.WriteLine(" - Happy Path : " + FormatTestResult(HappyPath()));
            Console.WriteLine(" - No Solution : " + FormatTestResult(NoSolution()));
            Console.WriteLine(" - Empty Input : " + FormatTestResult(EmptyInput()));
        }

        private static bool HappyPath() {
            return AssertEquals(new int[] { 1, 3 },
                twoSum.FindIndices(new int[] {11, 2, 15, 7}, 9));
        }

        private static bool NoSolution()
        {
            return AssertNull(twoSum.FindIndices(new int[] { 5 }, 8));
        }

        private static bool EmptyInput()
        {
            return AssertNull(twoSum.FindIndices(new int[] { }, 8));
        }
    }
}
