using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise5;
using Xunit;

#pragma warning disable IDE0160
namespace Hw3.Tests.Exercise5;
#pragma warning restore IDE0160

[SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
public class BinaryTreeSorterTests
{
    public static IEnumerable<object[]> ValidData =>
        new List<object[]>
        {
            new object[]
            {
                new BinaryNode(new BinaryNode(null, new BinaryNode(null, null, 35), 15),
                    new BinaryNode(new BinaryNode(null, null, 45), new BinaryNode(null, null, 2), 25), 1),
                new List<int> { 1, 15, 25, 35, 45, 2}
            },
            new object[]
            {
                new BinaryNode(null, new BinaryNode(new BinaryNode(new BinaryNode(null, new BinaryNode(null,null, 1), 27),null,14), null, 5), 16),
                    new List<int> { 16, 5, 14, 27, 1}
            },
            new object[]
            {
                new BinaryNode(new BinaryNode(null, new BinaryNode(null, null, 0), -6),
                    new BinaryNode(new BinaryNode(null, null, 15), new BinaryNode(null, null, 100), 100), 0),
                new List<int> { 0, -6, 100, 0, 15, 100}
            },
        };

    [Theory]
    [MemberData(nameof(ValidData))]
    public void FindWords_WithValidParameters(BinaryNode node, List<int> expectedResult)
    {
        var result = BinaryTreeSorter.Sort(node);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Run_WithNullArguments_ReturnsEmptyCollection()
    {
        Assert.Equal(BinaryTreeSorter.Sort(null), new List<int>());
    }
}
