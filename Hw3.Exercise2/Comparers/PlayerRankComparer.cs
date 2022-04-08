using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class PlayerRankComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            if (x?.Rank < y?.Rank)
                return 1;
            if (x?.Rank > y?.Rank)
                return -1;

            return 0;
        }
    }
}
