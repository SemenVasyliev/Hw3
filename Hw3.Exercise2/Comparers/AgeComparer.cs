using Hw3.Exercise2.Models;

namespace Hw3.Exercise2.Comparers
{
    public class AgeComparer : IComparer<PlayerInfo>
    {
        public int Compare(PlayerInfo? x, PlayerInfo? y)
        {
            if (x?.Age < y?.Age)
                return 1;
            if (x?.Age > y?.Age)
                return -1;

            return 0;
        }
    }
}
