namespace Leetcode.Hard
{
    /*
     * Problem: 42. Trapping Rain Water
     * Acceptance Rate: 53.9%
     * URL: https://leetcode.com/problems/trapping-rain-water/
     */
    public class TrappingRainWater
    {
        /* Runtime: 84 ms, faster than 99.59% of C# online submissions for Trapping Rain Water.
         * Memory Usage: 39.6 MB, less than 5.04% of C# online submissions for Trapping Rain Water... how?
         * Space Complexity - O(1)
         */
        public int area(int[] walls)
        {
            int totalWaterTrapped = 0;

            int pL = 0, pR = walls.Length - 1;

            int highestLeftWallFound = 0, highestRightWallFound = 0;

            while(pL < pR)
            {
                if(walls[pL] <= walls[pR])
                {
                    if(walls[pL] < highestLeftWallFound)
                    {
                        totalWaterTrapped += highestLeftWallFound - walls[pL];
                    }
                    else
                    {
                        highestLeftWallFound = walls[pL];
                    }

                    ++pL;
                }
                else    // walls[pR] > walls[pL]
                {
                    if(walls[pR] < highestRightWallFound)
                    {
                        totalWaterTrapped += highestRightWallFound - walls[pR];
                    }
                    else
                    {
                        highestRightWallFound = walls[pR];
                    }

                    --pR;
                }
            }

            return totalWaterTrapped;
        }
    }
}
