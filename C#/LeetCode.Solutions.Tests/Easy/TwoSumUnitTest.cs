using System;
using System.Diagnostics;
using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests.Easy
{
    public class TwoSumUnitTest
    {
        private TwoSum _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new TwoSum();
            _stopwatch = new Stopwatch();
        }



        [Test]

        public void TwoSum_GivenExample_ShouldReturnTarget()
        {
            // Given
            var nums = new[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new[] { 0, 1 };
            // When
            _stopwatch.Start();
            var result = _sut.Run(nums, target);
            _stopwatch.Stop();
            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }

        [Test]

        public void TwoSumFaster_GivenExample_ShouldReturnTarget()
        {
            // Given
            var nums = new[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new[] { 0, 1 };
            // When
            _stopwatch.Start();
            var result = _sut.RunFaster(nums, target);
            _stopwatch.Stop();
            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}