using FluentAssertions;
using LeetCode.Solutions.Easy;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Easy
{
    public class NumberOfValidWordsInSentenceUnitTest
    {
        private NumberOfValidWordsInSentence _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new NumberOfValidWordsInSentence();
            _stopwatch = new Stopwatch();
        }

        [TestCase("cat and  dog", 3)]
        [TestCase("!this  1-s b8d!", 0)]
        [TestCase("alice and  bob are playing stone-game10", 5)]
        public void CountValidWords_GivenExample_ShouldReturnExpected(string input, int expected)
        {
            // Given

            // When
            _stopwatch.Start();
            var result = _sut.CountValidWords(input);
            _stopwatch.Stop();

            // Then
            result.Should().Be(expected);
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }
    }
}
