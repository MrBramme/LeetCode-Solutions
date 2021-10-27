using FluentAssertions;
using LeetCode.Solutions.March2021Dailies;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.March2021Dailies
{
    [TestFixture]
    public class Day12BinaryCodesUnitTest
    {
        private Day12BinaryCodes _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new Day12BinaryCodes();
            _stopwatch = new Stopwatch();
        }

        [TestCase("00110110", 2, true)]
        [TestCase("00110", 2, true)]
        [TestCase("0110", 1, true)]
        [TestCase("0110", 2, false)]
        [TestCase("0000000001011100", 4, false)]
        public void IntToRoman_GivenInput_ReturnsExpectedRoman(string s, int k, bool expected)
        {
            // Given When
            var roman = _sut.HasAllCodes(s, k);

            // Then
            roman.Should().Be(expected);
        }
    }
}