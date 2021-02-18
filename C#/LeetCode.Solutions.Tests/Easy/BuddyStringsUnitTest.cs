using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class BuddyStringsUnitTest
    {
        private BuddyStrings _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new BuddyStrings();
            _stopwatch = new Stopwatch();
        }

        [TestCase("ab", "ba", true)]
        [TestCase("ab", "ab", false)]
        [TestCase("aa", "aa", true)]
        [TestCase("aaaaaaabc", "aaaaaaacb", true)]
        [TestCase("", "aa", false)]
        [TestCase("abcaa", "abcbb", false)]
        [TestCase("abab", "abab", true)]
        [TestCase("acccccb", "bccccca", true)]
        [TestCase("ab", "babbb", false)]
        [TestCase("a", "a", false)]
        public void KidsWithTheGreatestNumberOfCandies_GivenExample_ShouldReturnTarget(string a, string b, bool expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.Run(a, b);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
