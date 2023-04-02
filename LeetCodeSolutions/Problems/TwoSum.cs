using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;

namespace LeetCodeSolutions.Problems
{
    /// <summary>
    /// Two Sum
    /// https://leetcode.com/problems/two-sum/
    /// 
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// 
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// 
    /// You can return the answer in any order.
    /// </summary>
    public class TwoSum
    {

        /// <summary>
        /// Solution Method
        /// </summary>
        /// 
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] twoSum(int[] nums, int target) 
        {

            short leni = (Int16)nums.Count();
            short lenj = (Int16)(leni - 1);

            for (short i = 0; i < leni; i++)
            {
                for (short j = 0; j < lenj; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        int[] arr = { i, j };

                        return arr;
                    }
                }
            }

            return new int[] { };

        }
    }
}