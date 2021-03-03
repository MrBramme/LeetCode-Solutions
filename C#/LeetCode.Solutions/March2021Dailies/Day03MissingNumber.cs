using System.Linq;

namespace LeetCode.Solutions.March2021Dailies
{
    // https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3659/
    public class Day03MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            return Enumerable.Range(0, nums.Length + 1).Except(nums).First();
        }
    }
}
