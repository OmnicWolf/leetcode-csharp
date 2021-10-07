using System;

namespace LeetcodeTests.Utility
{
    public class Assertions
    {
        private Assertions() {}

        public static string FormatTestResult(bool result)
        {
            return result ? "P" : "Fail";
        }

        public static bool AssertTrue(bool actual)
        {
            return actual;
        }

        public static bool AssertFalse(bool actual)
        {
            return !actual;
        }

        public static bool AssertNull(string str)
        {
            return str == null;
        }

        public static bool AssertNull(int[] arr)
        {
            return arr == null;
        }

        public static bool AssertNull(string[] arr)
        {
            return arr == null;
        }

        public static bool AssertEquals(string expected, string actual)
        {
            bool result = actual.Equals(expected);
            return result;
        }

        public static bool AssertEquals(int expected, int actual)
        {
            bool result = actual == expected;
            return result;
        }

        public static bool AssertEquals(double expected, double actual)
        {
            bool result = actual == expected;
            return result;
        }

        public static bool AssertEquals(int[] expected, int[] actual)
        {
            if(actual == null)
            {
                Console.WriteLine("\n\tActual provided is null");
                return false;
            }

            if (actual.Length != expected.Length)
            {
                Console.WriteLine($"\n\tArray length mismatch: actual={actual}, expected={expected}");
                return false;
            }

            bool result = true;

            for(int i=0; i < expected.Length; ++i)
            {
                if (actual[i] != expected[i])
                {
                    Console.WriteLine("\n\tActual: {0}\n\tExpected: {1}", Helpers.ToString(actual), Helpers.ToString(expected));
                    result = false;
                }
            }

            return result;
        }

        public static bool AssertEquals(string[] expected, string[] actual)
        {
            if (actual == null)
            {
                Console.WriteLine("\n\tActual provided is null");
                return false;
            }

            if (actual.Length != expected.Length)
            {
                Console.WriteLine($"\n\tArray length mismatch: actual={actual}, expected={expected}");
                return false;
            }

            bool result = true;

            for (int i = 0; i < expected.Length; ++i)
            {
                if (actual[i] != expected[i])
                {
                    Console.WriteLine("\n\tActual: {0}\n\tExpected: {1}", Helpers.ToString(actual), Helpers.ToString(expected));
                    result = false;
                }
            }

            return result;
        }
    }
}
