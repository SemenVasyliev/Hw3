using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise1;
using Xunit;
#pragma warning disable CS8625

namespace Hw3.Tests.Exercise1
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class ArithmeticProcessorTests
    {
        public static IEnumerable<object[]> ValidData =>
            new List<object[]>
            {
                new object[] { new List<int>{ 1, 2 }, new List<int>{ -8, 2 } },
                new object[] { new List<int>{ 5, 10, 15, 20, 25 }, new List<int>{ 0, 10, 30, 50 } },
                new object[] { new List<int>{ 5, 5, 5, 5 }, new List<int>{ -5, 10 } },
                new object[] { new List<int>{ -100, -500, 0, 1000, 5000, }, new List<int>{ -510, -200, 0, 990, 10000 } },
                new object[] { new List<int>{ 0, 0, 0, 0, -0 }, new List<int>{ -10, 0 } }
            };

        [Theory]
        [MemberData(nameof(ValidData))]
        public void Calculate_WithValidData_ReturnsValid(List<int> numbers, IEnumerable<int> expectedResult)
        {
            var result = ArithmeticProcessor.Calculate(numbers);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculate_NullList_ThrowsArgException()
        {
            _ = Assert.ThrowsAny<ArgumentNullException>(() => { _ = ArithmeticProcessor.Calculate(null); });
        }
    }
}
