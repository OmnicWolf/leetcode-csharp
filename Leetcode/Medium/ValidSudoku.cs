using System.Collections.Generic;

namespace Leetcode.Medium
{
    /*
     * Problem: 36. Valid Sudoku
     * Acceptance Rate: 53.1%
     * URL: https://leetcode.com/problems/valid-sudoku/
     */
    public class ValidSudoku
    {

        /* Time Complexity: O(n)
         * Space Complexity: O(3n) -> O(n)
         * 
         * Runtime: 108 ms, faster than 74.10% of C# online submissions for Valid Sudoku.
         * Memory Usage: 43 MB, less than 9.24% of C# online submissions for Valid Sudoku.
         */
        public static bool isValid(char[][] board)
        {
            ISet<char>[] rows = new HashSet<char>[9];
            ISet<char>[] columns = new HashSet<char>[9];
            ISet<char>[] boxes = new HashSet<char>[9];

            initSets<char>(rows);
            initSets<char>(columns);
            initSets<char>(boxes);

            char curr;

            for (int r = 0; r < 9; ++r)
            {
                for (int c = 0; c < 9; ++c)
                {
                    curr = board[r][c];

                    if (curr == '.') continue;

                    //Console.WriteLine("Coordinate: ({0}, {1}), value={2}", i, j, curr);

                    if (!rows[r].Add(curr))
                        return false;

                    if (!columns[c].Add(curr))
                        return false;

                    int box = ((r / 3) * 3) + (c / 3);

                    if (!boxes[box].Add(curr))
                        return false;
                }
            }

            return true;
        }

        public static bool isValid(int[][] board)
        {
            ISet<int>[] rows = new HashSet<int>[9];
            ISet<int>[] columns = new HashSet<int>[9];
            ISet<int>[] boxes = new HashSet<int>[9];

            initSets<int>(rows);
            initSets<int>(columns);
            initSets<int>(boxes);

            int curr;

            for (int r = 0; r < 9; ++r)
            {
                for (int c = 0; c < 9; ++c)
                {
                    curr = board[r][c];

                    if (curr == 0) continue;

                    if (!rows[r].Add(curr))
                        return false;

                    if (!columns[c].Add(curr))
                        return false;

                    int box = ((r / 3) * 3) + (c / 3);

                    if (!boxes[box].Add(curr))
                        return false;
                }
            }

            return true;
        }

        private static void initSets<T>(ISet<T>[] arr)
        {
            for(int i=0; i < arr.Length; ++i)
            {
                arr[i] = new HashSet<T>();
            }
        }
    }
}
