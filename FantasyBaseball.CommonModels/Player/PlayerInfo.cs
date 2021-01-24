using FantasyBaseball.CommonModels.Enums;

namespace FantasyBaseball.CommonModels.Player
{
    /// <summary>Info for a given Player.</summary>
    public class PlayerInfo
    {
        /// <summary>The player's ID.</summary>
        public int Id { get; set; }

        /// <summary>The player's first name.</summary>
        public string FirstName { get; set; }

        /// <summary>The player's last name.</summary>
        public string LastName { get; set; }

        /// <summary>The player's age.</summary>
        public int Age { get; set; }

        /// <summary>The player's type (B for Batter or P for Pitcher).</summary>
        public PlayerType Type { get; set; }

        /// <summary>The position(s) this player plays.</summary>
        public string Positions { get; set; }

        /// <summary>The player's team.</summary>
        public string Team { get; set; }

        /// <summary>The player's status.</summary>
        public PlayerStatus Status { get; set; }
    }
}