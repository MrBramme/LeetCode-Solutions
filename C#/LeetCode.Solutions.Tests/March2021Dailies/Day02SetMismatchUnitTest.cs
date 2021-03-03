using FluentAssertions;
using LeetCode.Solutions.March2021Dailies;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.March2021Dailies
{
    [TestFixture]
    public class Day02SetMismatchUnitTest
    {
        private Day02SetMismatch _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new Day02SetMismatch();
            _stopwatch = new Stopwatch();
        }

        [TestCase(new[] { 1, 2, 2, 4 }, new[] { 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 2 }, new[] { 2, 4 })]
        [TestCase(new[] { 1, 1 }, new[] { 1, 2 })]
        public void FindErrorNums_GivenExample_ShouldMatchExpected(int[] nums, int[] expected)
        {
            // Given When
            _stopwatch.Start();
            var result = _sut.FindErrorNums(nums);
            _stopwatch.Stop();

            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}