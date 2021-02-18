using System.Linq;

namespace LeetCode.Solutions.Easy
{
    // https://leetcode.com/problems/merge-sorted-array
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var newArr = nums1.Take(m).Concat(nums2.Take(n)).OrderBy(x => x).ToArray();
            for (var i = 0; i < m + n; i++)
            {
                nums1[i] = newArr[i];
            }
        }
    }
}
