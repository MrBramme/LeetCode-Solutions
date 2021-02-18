using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    public class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies.Max();
            return candies.Select((candy, index) => candy + extraCandies >= max).ToList();
        }
    }
}
