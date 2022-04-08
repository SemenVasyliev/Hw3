namespace Hw3.Exercise2.Models
{
    public class PlayerInfo
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Age { get; set; }

        public PlayerRank Rank { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} | {Age} | {Rank}";
        }
    }
}
