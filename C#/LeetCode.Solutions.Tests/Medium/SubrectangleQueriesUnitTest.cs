using FluentAssertions;
using LeetCode.Solutions.Medium;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests.Medium
{
    public class SubrectangleQueriesUnitTest
    {
        [Test]
        public void Example1()
        {
            // Given
            var initialValue = new[] { new[] { 1, 2, 1 }, new[] { 4, 3, 4 }, new[] { 3, 2, 1 }, new[] { 1, 1, 1 } };

            // When
            var sut = new SubrectangleQueries(initialValue);
            var result1 = sut.GetValue(0, 2);
            sut.UpdateSubrectangle(0, 0, 3, 2, 5);
            var result2 = sut.GetValue(0, 2);
            var result3 = sut.GetValue(3, 1);
            sut.UpdateSubrectangle(3, 0, 3, 2, 10);
            var result4 = sut.GetValue(3, 1);
            var result5 = sut.GetValue(0, 2);

            // Then
            result1.Should().Be(1);
            result2.Should().Be(5);
            result3.Should().Be(5);
            result4.Should().Be(10);
            result5.Should().Be(5);
        }

        [Test]
        public void Example2()
        {
            // Given
            var initialValue = new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } };

            // When
            var sut = new SubrectangleQueries(initialValue);
            var result1 = sut.GetValue(0, 0);
            sut.UpdateSubrectangle(0, 0, 2, 2, 100);
            var result2 = sut.GetValue(0, 0);
            var result3 = sut.GetValue(2, 2);
            sut.UpdateSubrectangle(1, 1, 2, 2, 20);
            var result4 = sut.GetValue(2, 2);

            // Then
            result1.Should().Be(1);
            result2.Should().Be(100);
            result3.Should().Be(100);
            result4.Should().Be(20);
        }
    }
}
