using System;
using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise2;
using Xunit;
#pragma warning disable CS8625

namespace Hw3.Tests.Exercise2
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class CsComparerApplicationTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData("abc")]
        [InlineData("some command")]
        [InlineData("1231321321")]
        public void Run_WithInvalidArgs_ReturnsInvalidArgs(string command)
        {
            var app = new CsComparerApplication();
            var result = app.Run(command.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Assert.Equal(CsComparerApplication.ReturnCode.InvalidArgs, result);
        }

        [Theory]
        [InlineData("age")]
        [InlineData("lastname")]
        [InlineData("rank")]
        public void Run_WithValidCommands_ReturnsValid(string command)
        {
            var app = new CsComparerApplication();
            var result = app.Run(command.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Assert.Equal(CsComparerApplication.ReturnCode.Success, result);
        }

        [Fact]
        public void Run_WithNullArguments_ReturnsInvalidArgs()
        {
            var app = new CsComparerApplication();
            var result = app.Run(null);

            Assert.Equal(CsComparerApplication.ReturnCode.InvalidArgs, result);
        }
    }
}
