using System;
using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise1;
using Xunit;
#pragma warning disable CS8625

namespace Hw3.Tests.Exercise1
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class ArithmeticApplicationTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData("abc")]
        [InlineData("a b c")]
        [InlineData("4 b 25")]
        public void Run_WithoutNumbersArgs_ReturnsInvalidArgs(string input)
        {
            var app = new ArithmeticApplication();
            var result = app.Run(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Assert.Equal(ArithmeticApplication.ReturnCode.InvalidArgs, result);
        }

        [Theory]
        [InlineData("5")]
        [InlineData("5 10 15")]
        public void Run_WithValidNumbers_ReturnsValid(string input)
        {
            var app = new ArithmeticApplication();
            var result = app.Run(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Assert.Equal(ArithmeticApplication.ReturnCode.Success, result);
        }

        [Theory]
        [InlineData("2147483647")]
        public void Run_WithInvalidNumber_ReturnsException(string input)
        {
            var app = new ArithmeticApplication();
            var result = app.Run(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Assert.Equal(ArithmeticApplication.ReturnCode.Exception, result);
        }

        [Fact]
        public void Run_WithNullArguments_ReturnsInvalidArgs()
        {
            var app = new ArithmeticApplication();
            var result = app.Run(null);

            Assert.Equal(ArithmeticApplication.ReturnCode.InvalidArgs, result);
        }
    }
}
