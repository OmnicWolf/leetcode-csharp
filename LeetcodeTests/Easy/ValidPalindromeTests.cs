using System;

using Leetcode.Easy;
using static LeetcodeTests.Utility.Assertions;

namespace LeetcodeTests.Easy
{
    public class ValidPalindromeTests
    {
        private static ValidPalindrome palindromeChecker = new ValidPalindrome();

        private ValidPalindromeTests() {}

        public static void Run()
        {
            Console.WriteLine("\nValid Palindrome Tests");
            Console.WriteLine(" - Panama : " + FormatTestResult(Panama()));
            Console.WriteLine(" - RaceACar : " + FormatTestResult(RaceACar()));
            Console.WriteLine(" - Panama (Inplace) : " + FormatTestResult(PanamaInplace()));
            Console.WriteLine(" - RaceACar (Inplace) : " + FormatTestResult(RaceACarInplace()));
        }

        // #region ValidPalindrome

        public static bool RaceACar()
        {
            return AssertFalse(palindromeChecker.Check("race a car"));
        }

        public static bool Panama()
        {
            return AssertTrue(palindromeChecker.Check("A man, a plan, a canal: Panama"));
        }

        public static bool RaceACarInplace()
        {
            return AssertFalse(palindromeChecker.CheckInplace("race a car"));
        }

        public static bool PanamaInplace()
        {
            return AssertTrue(palindromeChecker.CheckInplace("A man, a plan, a canal: Panama"));
        }

        //#endRegion
    }
}
