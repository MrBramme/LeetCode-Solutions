using FluentAssertions;
using LeetCode.Solutions.March2021Dailies;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.March2021Dailies
{
    [TestFixture]
    public class Day03MissingNumberUnitTest
    {
        private Day03MissingNumber _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new Day03MissingNumber();
            _stopwatch = new Stopwatch();
        }

        [TestCase(new[] { 3, 0, 1 }, 2)]
        [TestCase(new[] { 0, 1 }, 2)]
        [TestCase(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        [TestCase(new[] { 0 }, 1)]
        [TestCase(new[] { 1 }, 0)]
        public void MissingNumber_GivenExample_ShouldMatchExpected(int[] nums, int expected)
        {
            // Given When
            _stopwatch.Start();
            var result = _sut.MissingNumber(nums);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}