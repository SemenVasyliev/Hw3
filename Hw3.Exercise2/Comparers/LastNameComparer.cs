using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class LastNameComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            return string.Compare(y?.LastName, x?.LastName, StringComparison.Ordinal);
        }
    }
}
