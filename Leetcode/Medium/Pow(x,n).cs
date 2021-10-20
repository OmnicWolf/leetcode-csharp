using System;

namespace Leetcode.Medium
{
    /*
     * Problem: 50. Pow(x, n)
     * 
     * Difficulty: Medium
     * Acceptance Rate: 31.5%
     * 
     * URL: https://leetcode.com/problems/powx-n/
     */
    public class Pow_x_n
    {

        /* Runtime: 20 ms, faster than 100.00% of C# online submissions for Pow(x, n).
         * Memory Usage: 15.5 MB, less than 90.43% of C# online submissions for Pow(x, n).
         */
        public double calculate(double x, int n)
        {
            double result = 1;

            bool isExponentPositive = n > 0;

            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    result *= x;
                }

                x *= x;
                n /= 2;
            }

            return isExponentPositive ? result : 1 / result;
        }

        public double calculateVerbose(double x, int n)
        {
            double result = 1;

            bool isExponentPositive = n > 0;

            Console.WriteLine("Starting: x=" + x + ", n=" + n + ", result=" + result);

            while (n != 0)
            {
                if (n % 2 != 0)
                {  // n%2 can be equal to 0, 1(in case of n>0) or -1(in case of n<0)
                    result *= x;
                }
                Console.WriteLine("\nn%2=" + (n % 2) + ", result=" + result);
                x *= x;
                n /= 2;
                Console.WriteLine("\t After: x=" + x + ", n=" + n);
            }

            return isExponentPositive ? result : 1 / result;
        }
    }
}


// class Solution {
// public:
//     double myPow(double x, int n) {
//         double cur = x, res = 1;
//         unsigned int pow;
//         if(x == 0) return 0;
//
//         if(n < 0){
//             cur = 1 / x;
//             pow = (unsigned int)(-(n + 1)) + 1;
//         }else if(n == 0){
//             return 1;
//         }else{
//             pow = n;
//         }
//
//         while(pow != 0){
//             if(1&pow) res *= cur;
//             pow = pow >> 1;
//             cur = cur * cur;
//         }
//         return res;
//     }
// };