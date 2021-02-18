using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class ShuffleTheArrayUnitTest
    {
        private ShuffleTheArray _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new ShuffleTheArray();
            _stopwatch = new Stopwatch();
        }



        [TestCase(new[] { 2, 5, 1, 3, 4, 7 }, 3, new[] { 2, 3, 5, 4, 1, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [TestCase(new[] { 1, 1, 2, 2 }, 2, new[] { 1, 2, 1, 2 })]
        [TestCase(new[] { 2, 5, 1, 3, 4, 7 }, 3, new[] { 2, 3, 5, 4, 1, 7 })]
        public void ShuffleTheArray_GivenExample_ShouldReturnExpected(int[] input, int n, int[] expected)
        {
            // Given
            // When
            _stopwatch.Start();
            var result = _sut.Shuffle(input, n);
            _stopwatch.Stop();
            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}