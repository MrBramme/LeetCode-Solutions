using FluentAssertions;
using LeetCode.Solutions.March2021Dailies;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.March2021Dailies
{
    [TestFixture]
    public class Day07DesignHashMapUnitTest
    {
        private MyHashMap _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new MyHashMap();
            _stopwatch = new Stopwatch();
        }

        [Test]
        public void HashMap_GivenValueAdded_ShouldReturnCorrectValue()
        {
            // Given
            _sut.Put(5, 654);

            // When
            var result = _sut.Get(5);

            // Then
            result.Should().Be(654);
        }

        [Test]
        public void HashMap_GivenNoValueAdded_ShouldReturnNeg1()
        {
            // Given When
            var result = _sut.Get(5);

            // Then
            result.Should().Be(-1);
        }

        [Test]
        public void HashMap_GivenValueRemoved_ShouldReturnNeg1()
        {
            // Given
            _sut.Put(3, 6);
            _sut.Remove(3);

            // When
            var result = _sut.Get(3);

            // Then
            result.Should().Be(-1);
        }
    }
}