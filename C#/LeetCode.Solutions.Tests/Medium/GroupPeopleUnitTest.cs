using FluentAssertions;
using LeetCode.Solutions.Medium;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace LeetCode.Solutions.Tests.Medium
{
    public class GroupPeopleUnitTest
    {
        private GroupPeople _sut;
        private Stopwatch _stopwatch;

        [SetUp]
        public void Setup()
        {
            _sut = new GroupPeople();
            _stopwatch = new Stopwatch();
        }

        [Test]

        public void Example1()
        {
            // Given
            var groupSizes = new[] { 3, 3, 3, 3, 3, 1, 3 };

            // When
            _stopwatch.Start();
            var result = _sut.GroupThePeople(groupSizes);
            _stopwatch.Stop();

            // Then
            var expected = new[] { new[] { 5 }, new[] { 0, 1, 2 }, new[] { 3, 4, 6 } };
            // [[2,1,6],[5],[0,4,3]] and [[5],[0,6,2],[4,3,1]]
            result.Should().BeEquivalentTo(expected);

            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }

        [Test]

        public void Example2()
        {
            // Given
            var groupSizes = new[] { 2, 1, 3, 3, 3, 2 };

            // When
            _stopwatch.Start();
            var result = _sut.GroupThePeople(groupSizes);
            _stopwatch.Stop();

            // Then
            var expected = new[] { new[] { 1 }, new[] { 0, 5 }, new[] { 2, 3, 4 } };
            result.Should().BeEquivalentTo(expected);

            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Milliseconds} ms");
            Console.WriteLine($"Ran for: {_stopwatch.Elapsed.Ticks} ticks");
        }

    }
}
