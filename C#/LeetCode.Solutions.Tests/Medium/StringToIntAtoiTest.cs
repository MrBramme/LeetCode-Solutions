using FluentAssertions;
using LeetCode.Solutions.Medium;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Medium
{
    public class StringToIntAtoiTest
    {
        private StringToIntAtoi _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new StringToIntAtoi();
            _stopwatch = new Stopwatch();
        }

        [TestCase("42", 42)]
        [TestCase("   -42", -42)]
        [TestCase("4193 with words", 4193)]
        [TestCase("words and 987", 0)]
        [TestCase("-91283472332", -2147483648)]
        [TestCase("", 0)]
        [TestCase("   +42", 42)]
        public void Examples(string input, int expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.MyAtoi(input);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);

            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
