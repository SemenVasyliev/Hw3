using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Hw3.Exercise2;
using Hw3.Exercise2.Comparers;
using Hw3.Exercise2.Models;
using Xunit;
#pragma warning disable CS8625

namespace Hw3.Tests.Exercise2
{
    [SuppressMessage("Naming", "CA1707", MessageId = "Identifiers should not contain underscores")]
    public class CsComparerServiceTests
    {
        [Fact]
        public void Compare_WithAgeComparer()
        {
            var result = CsComparerService.Compare(new AgeComparer());

            var firstPlayer = result.First();
            var lastPlayer = result.Last();

            Assert.Equal(33, firstPlayer.Age);
            Assert.Equal(11, lastPlayer.Age);
        }

        [Fact]
        public void Compare_WithLastNameComparer()
        {
            var result = CsComparerService.Compare(new LastNameComparer());

            var firstPlayer = result.First();
            var lastPlayer = result.Last();

            Assert.Equal("Zenchenko", firstPlayer.LastName);
            Assert.Equal("Alexeenko", lastPlayer.LastName);
        }

        [Fact]
        public void Compare_WithRankComparer()
        {
            var result = CsComparerService.Compare(new PlayerRankComparer());

            var firstPlayer = result.First();
            var lastPlayer = result.Last();

            Assert.Equal(PlayerRank.Global, firstPlayer.Rank);
            Assert.Equal(PlayerRank.Silver, lastPlayer.Rank);
        }

        [Fact]
        public void Compare_WithNullComparer_ThrowsArgException()
        {
            _ = Assert.ThrowsAny<ArgumentNullException>(() => { _ = CsComparerService.Compare(null); });
        }
    }
}
