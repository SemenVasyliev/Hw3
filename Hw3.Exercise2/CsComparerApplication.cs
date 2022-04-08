using Hw3.Exercise2.Comparers;
using Hw3.Exercise2.Models;

namespace Hw3.Exercise2
{
    public sealed class CsComparerApplication
    {
        /// <summary>
        /// CsCompare application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1
        }

        public ReturnCode Run(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                return ReturnCode.InvalidArgs;
            }
            switch (args[0])
            {
                case "age":
                    IComparer<PlayerInfo> comparer = new AgeComparer();
                    var players = CsComparerService.Compare(comparer);
                    Console.WriteLine(string.Join("\n", players));

                    return ReturnCode.Success;

                case "lastname":
                    comparer = new LastNameComparer();
                    players = CsComparerService.Compare(comparer);
                    Console.WriteLine(string.Join("\n", players));

                    return ReturnCode.Success;
                case "rank":
                    comparer = new PlayerRankComparer();
                    players = CsComparerService.Compare(comparer);
                    Console.WriteLine(string.Join("\n", players));

                    return ReturnCode.Success;

                default:
                    return ReturnCode.InvalidArgs;
            }

        }
    }
}
