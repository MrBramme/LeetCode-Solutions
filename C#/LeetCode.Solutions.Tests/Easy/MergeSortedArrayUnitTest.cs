using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class MergeSortedArrayUnitTest
    {
        private MergeSortedArray _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new MergeSortedArray();
            _stopwatch = new Stopwatch();
        }

        [Test]
        public void Example()
        {
            // Given
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;

            // When
            _sut.Merge(nums1, m, nums2, n);

            // Then
            var expected = new[] { 1, 2, 2, 3, 5, 6 };
            nums1.Should().BeEquivalentTo(expected);
        }
    }
}