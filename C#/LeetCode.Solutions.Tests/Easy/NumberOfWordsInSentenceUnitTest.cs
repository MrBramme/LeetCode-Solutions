using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class NumberOfWordsInSentenceUnitTest
    {
        private NumberOfWordsInSentence _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new NumberOfWordsInSentence();
            _stopwatch = new Stopwatch();
        }

        [TestCase(new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much"}, 6)]
        [TestCase(new[] { "please wait", "continue to fight", "continue to win" }, 3)]
        public void KidsWithTheGreatestNumberOfCandies_GivenExample_ShouldReturnTarget(string[] input, int expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.MostWordsFound(input);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
