using LeetCode.Solutions.Easy;
using System.Diagnostics;
using NUnit.Framework;
using System;
using FluentAssertions;

namespace LeetCode.Solutions.Tests.Easy
{
    public class RunningSumOf1dArrayUnitTest
    {
        private RunningSumOf1dArray _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new RunningSumOf1dArray();
            _stopwatch = new Stopwatch();
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
        public void RunningSumOf1dArray_GivenExample_ShouldReturnTarget(int[] input, int[] expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.Run(input);
            _stopwatch.Stop();

            // Then
            result.Should().BeEquivalentTo(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }

        [Test]
        public void RunningSumOf1dArray_GivenNoInput_ShouldThrow()
        {
            Action act = () => _sut.Run(null);
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void RunningSumOf1dArray_GivenEmptyInput_ShouldThrow()
        {
            Action act = () => _sut.Run(new int[0]);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void RunningSumOf1dArray_Given1001Input_ShouldThrow()
        {
            Action act = () => _sut.Run(new int[1001]);
            act.Should().Throw<ArgumentException>();
        }
    }
}
