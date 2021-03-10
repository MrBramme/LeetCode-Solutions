using FluentAssertions;
using LeetCode.Solutions.March2021Dailies;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.March2021Dailies
{
    [TestFixture]
    public class Day10IntegerToRomanUnitTest
    {
        private Day10IntegerToRoman _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new Day10IntegerToRoman();
            _stopwatch = new Stopwatch();
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(58, "LVIII")]
        [TestCase(99, "XCIX")]
        [TestCase(100, "C")]
        [TestCase(101, "CI")]
        [TestCase(499, "CDXCIX")]
        [TestCase(500, "D")]
        [TestCase(501, "DI")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1000, "M")]
        [TestCase(1001, "MI")]
        [TestCase(1994, "MCMXCIV")]
        public void IntToRoman_GivenInput_ReturnsExpectedRoman(int num, string expected)
        {
            // Given When
            var roman = _sut.IntToRoman(num);

            // Then
            roman.Should().Be(expected);
        }
    }
}