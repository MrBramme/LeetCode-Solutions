using System.IO;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/two-sum
    public class TwoSum
    {
        public int[] Run(int[] nums, int target)
        {
            var inputSize = nums.Length;
            for (var i = 0; i < inputSize; i++)
            {
                for (var j = 0; j < inputSize; j++)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }
            throw new InvalidDataException("Unable to get correct target from input args");
            
        }

        public int[] RunFaster(int[] nums, int target)
        {
            var inputSize = nums.Length;
            for (var i = 0; i < inputSize; i++)
            {
                for (var j = inputSize - 1; j >= 0; j--)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            throw new InvalidDataException("Unable to get correct target from input args");

        }
    }
}
