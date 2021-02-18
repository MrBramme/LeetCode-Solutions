using System;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/running-sum-of-1d-array/
    public class RunningSumOf1dArray
    {
        public int[] Run(int[] nums)
        {
            VerifyInput(nums);
            var result = new int[nums.Length];
            var currentResult = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                currentResult += nums[i];
                result[i] = currentResult;
            }
            return result;
        }

        private void VerifyInput(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException();
            }

            var count = nums.Length;
            if (count < 1 || count > 1000)
            {
                throw new ArgumentException();
            }
        }
    }
}
