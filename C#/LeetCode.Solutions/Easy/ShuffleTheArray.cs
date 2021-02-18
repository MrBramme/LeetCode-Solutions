namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/shuffle-the-array/
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length / 2; i++)
            {
                result[i * 2] = nums[i];
                result[(i * 2) + 1] = nums[i + n];
            }

            return result;
        }
    }
}
