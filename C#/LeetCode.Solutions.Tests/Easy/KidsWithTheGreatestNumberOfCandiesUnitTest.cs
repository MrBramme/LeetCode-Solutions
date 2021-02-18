using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class KidsWithTheGreatestNumberOfCandiesUnitTest
    {
        private KidsWithTheGreatestNumberOfCandies _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new KidsWithTheGreatestNumberOfCandies();
            _stopwatch = new Stopwatch();
        }

        [TestCase(new[] { 2, 3, 5, 1, 3 }, 3, new[] { true, true, true, false, true })]
        [TestCase(new[] { 4, 2, 1, 1, 2 }, 1, new[] { true, false, false, false, false })]
        [TestCase(new[] { 12, 1, 12 }, 10, new[] { true, false, true })]
        public void KidsWithTheGreatestNumberOfCandies_GivenExample_ShouldReturnTarget(int[] candies, int extraCandies, bool[] expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.KidsWithCandies(candies, extraCandies);
            _stopwatch.Stop();

            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
