 using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hw3.Exercise4;
using Xunit;
#pragma warning disable CS8625

#pragma warning disable IDE0160
namespace Hw3.Tests.Exercise4;
#pragma warning restore IDE0160

[SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
public class WordsFinderTests
{
    public static IEnumerable<object[]> ValidData =>
        new List<object[]>
        {
            new object[] { "a", new List<string>{ "a", "abc", "aa" }, new List<string>{ "a" } },
            new object[] { "xyz", new List<string>{ "xyz", "xy", "xz", "zyx", "yx", "zz" }, new List<string>{ "xyz", "zyx" } },
            new object[] { "abba", new List<string>{ "aabb", "bbba", "abcd", "bbaa", "abcd", "baaab", "baab" }, new List<string>{ "aabb", "bbaa", "baab" } },
            new object[] { "some_word", new List<string> {"xxxxx"}, new List<string>()  }
        };

    public static IEnumerable<object[]> InvalidData =>
        new List<object[]>
        {
            new object[] { "", null },
            new object[] { null, new List<string>{ "test", "abc" } },
            new object[] { null, null },
            new object[] { "some_word", null }
        };

    [Theory]
    [MemberData(nameof(ValidData))]
    public void FindWords_WithValidParameters(string word, List<string> listOfWords, List<string>? expectedResult)
    {
        var result = WordsFinder.FindWords(word, listOfWords);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(InvalidData))]
    public void FindWords_WithInvalidParameters_ThrowsArgException(string word, List<string> listOfWords)
    {
        _ = Assert.ThrowsAny<ArgumentNullException>(() => { _ = WordsFinder.FindWords(word, listOfWords); });
    }
}
