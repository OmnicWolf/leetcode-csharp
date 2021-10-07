using System.Collections.Generic;

namespace Leetcode.Easy
{
    /*
     * Problem: 1. Two Sum
     * Acceptance Rate: 47.7%
     * URL: https://leetcode.com/problems/two-sum/
     */
    public class TwoSum
    {
        /* Runtime: 112 ms, faster than 100.00% of C# online submissions for Two Sum.
         * Memory Usage: 32.8 MB, less than 30.58% of C# online submissions for Two Sum.
         */
        public int[] FindIndices(int[] nums, int target)
        {
            Dictionary<int, int> seeking = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (seeking.TryGetValue(nums[i], out int index))
                {
                    return new int[] { index, i };
                }
                else
                {
                    seeking[target - nums[i]] = i;
                }
            }

            return null;
        }

        /* Runtime: 252 ms, faster than 71.44% of C# online submissions for Two Sum.
         * Memory Usage: 32.8 MB, less than 30.58% of C# online submissions for Two Sum.
         */
        public int[] FindIndicesDictionary(int[] nums, int target)
        {
            Dictionary<int, int> seeking = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (seeking.ContainsKey(nums[i]))
                {
                    return new int[] { seeking[nums[i]], i };
                }
                else
                {
                    seeking[target - nums[i]] = i;
                }
            }
            return null;
        }

        /* Runtime: 324 ms, faster than 53.65% of C# online submissions for Two Sum.
         * Memory Usage: 32.3 MB, less than 79.09% of C# online submissions for Two Sum.
         */
        public int[] FindIndicesBF(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }

            return null;
        }
    }
}
