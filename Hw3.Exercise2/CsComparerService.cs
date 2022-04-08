using System.Collections.Generic;
using Hw3.Exercise2.Comparers;
using Hw3.Exercise2.Models;

namespace Hw3.Exercise2
{
    public static class CsComparerService
    {
        /// <summary>
        /// Sort players by comparer.
        /// </summary>
        /// <param name="comparer">Comparer that will be using.</param>
        /// <returns>
        /// Returns <c>IEnumerable</c> of sorted players. 
        /// </returns>
        /// <exception cref="ArgumentNullException">Comparer is null.</exception>
        public static IEnumerable<PlayerInfo> Compare(IComparer<PlayerInfo> comparer)
        {
            if (comparer is null)
                throw new ArgumentNullException(nameof(comparer));
            var players = new List<PlayerInfo>();
            players.AddRange(CsComparerData.Players);
            if (comparer is AgeComparer)
            {
                players.Sort(new AgeComparer());
            }
            else if (comparer is LastNameComparer)
            {
                players.Sort(new LastNameComparer());
            }
            else if (comparer is PlayerRankComparer)
            {
                players.Sort(new PlayerRankComparer());
            }
            return players;
        }
    }
}
