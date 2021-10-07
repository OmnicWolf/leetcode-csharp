using System;

using Leetcode.Hard;
using static LeetcodeTests.Utility.Assertions;

namespace LeetcodeTests.Hard
{
    public class TrappingRainWaterTests
    {
        private static TrappingRainWater trap = new TrappingRainWater();

        private TrappingRainWaterTests() {}

        public static void Run()
        {
            Console.WriteLine("\nTrapping Rain Water Tests");
            Console.WriteLine(" - Skiing : " + FormatTestResult(HappyPath_Skiing()));
            Console.WriteLine(" - Rock Climbing : " + FormatTestResult(HappyPath_RockClimbing()));
            Console.WriteLine(" - Mountain : " + FormatTestResult(HappyPath_Mountain()));
        }

        private static bool HappyPath_Skiing()
        {
            return AssertEquals(4, trap.area(new int[] { 3, 0, 1, 2, 0, 1, 0, }));
        }

        private static bool HappyPath_RockClimbing()
        {
            return AssertEquals(4, trap.area(new int[] { 0, 1, 0, 2, 1, 0, 3, }));
        }

        private static bool HappyPath_Mountain()
        {
            return AssertEquals(8, trap.area(new int[] { 0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2 }));
        }
    }
}
