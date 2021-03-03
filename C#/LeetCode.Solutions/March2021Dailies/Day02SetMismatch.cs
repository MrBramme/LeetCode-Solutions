using System.Linq;

namespace LeetCode.Solutions.March2021Dailies
{
    // https://leetcode.com/explore/challenge/card/march-leetcoding-challenge-2021/588/week-1-march-1st-march-7th/3658/
    public class Day02SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            var missing = Enumerable.Range(1, nums.Length).Except(nums).First();
            var duplicate = nums.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key).First();
            return new[] { duplicate, missing };
        }
    }
}
