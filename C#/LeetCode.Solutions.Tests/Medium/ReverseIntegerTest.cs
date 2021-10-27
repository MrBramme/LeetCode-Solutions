using FluentAssertions;
using LeetCode.Solutions.Medium;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Medium
{
    public class ReverseIntegerTest
    {
        private ReverseInteger _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new ReverseInteger();
            _stopwatch = new Stopwatch();
        }

        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(0, 0)]
        public void Examples(int input, int expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.Reverse(input);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);

            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
