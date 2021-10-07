using System.Text;

namespace Leetcode.Easy
{
    /*
     * Problem: 125. Valid Palindrome
     * Acceptance Rate: 39.7%
     * URL: https://leetcode.com/problems/valid-palindrome/
     */
    public class ValidPalindrome
    {

        /* Runtime: 80 ms, faster than 77.98% of C# online submissions for Valid Palindrome.
         * Memory Usage: 25.2 MB, less than 50.10% of C# online submissions for Valid Palindrome.
         */
        public bool Check(string s)
        {
            string simplified = ReduceToAlphaNumeric(s);
            int length = simplified.Length;

            for (int i = 0; i < length / 2; ++i)
            {
                if (simplified[i] != simplified[length - 1 - i]) return false;
            }

            return true;
        }

        private string ReduceToAlphaNumeric(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);

            // 0 to 9 = 48-57
            // A to Z = 65-90
            // a to z = 97-122
            for (int i = 0; i < s.Length; ++i)
            {
                char curr = s[i];

                if ((curr < 123 && curr > 96) || (curr < 58 && curr > 47))
                {
                    sb.Append(curr);
                }
                else if (curr < 91 && curr > 64)
                {
                    sb.Append((char)(curr + 32));
                }

            }

            return sb.ToString();
        }

        /* Runtime: 76 ms, faster than 90.15% of C# online submissions for Valid Palindrome.
         * Memory Usage: 24.6 MB, less than 88.42% of C# online submissions for Valid Palindrome.
         */
        public bool CheckInplace(string s)
        {
            for (int pL = 0, pR = s.Length - 1; pL < pR; ++pL, --pR)
            {

                char left = s[pL], right = s[pR];

                if (!char.IsLetterOrDigit(left))
                {
                    ++pR;   // Keep pR in its current position
                    continue;
                }
                else if (!char.IsLetterOrDigit(right))
                {
                    --pL;   // Keep pL in its current position
                    continue;
                }

                //Console.WriteLine($"Comparing: {left} ? {right} ({pL}, {pR})");
                //Console.WriteLine($"\tleft = {(int)left}");

                if (left < 58)
                {
                    if (left != right) return false;
                }
                else if (char.ToLower(left) != char.ToLower(right))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
