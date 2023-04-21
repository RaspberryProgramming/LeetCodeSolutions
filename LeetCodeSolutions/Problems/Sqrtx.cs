using LeetCodeSolutions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.Problems
{
    /// <summary>
    /// Sqrt(x)
    /// https://leetcode.com/problems/sqrtx/
    /// 
    /// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
    /// You must not use any built-in exponent function or operator.
    /// For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
    /// </summary>
    public class Sqrtx
    {
        /// <summary>
        /// Calculates the SQRT of x variable
        /// </summary>
        /// <param name="x">value to find the sqrt of</param>
        /// <returns>sqrt of x</returns>
        public static int sqrtx(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            return findSqrt(x, 0, x / 2);
        }

        /// <summary>
        /// Recursively Find SQRT of X value using start and end values
        /// </summary>
        /// <param name="x">value to find SQRT of</param>
        /// <param name="start">lower bound</param>
        /// <param name="end">upper bound</param>
        /// <returns>Sqrt of x</returns>
        private static int findSqrt(int x, int start, int end)
        {

            int mid = (start + end) / 2;

            if ((long)mid * mid > x)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
            if (start > end)
            {
                return end;
            }
            else
            {
                return findSqrt(x, start, end);
            }
        }

    }
}
