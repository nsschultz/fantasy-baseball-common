using FantasyBaseball.CommonModels.Enums;

namespace FantasyBaseball.CommonModels.Player
{
    /// <summary>League Info for a given Player.</summary>
    public class LeagueInfo
    {
        /// <summary>The player's status for League #1.</summary>
        public LeagueStatus League1 { get; set; }

        /// <summary>The player's status for League #2.</summary>
        public LeagueStatus League2 { get; set; }
    }
}