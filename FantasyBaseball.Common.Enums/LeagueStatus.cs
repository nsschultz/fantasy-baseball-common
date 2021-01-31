using System.ComponentModel;

namespace FantasyBaseball.Common.Enums
{
    /// <summary>The status of the player within the league.</summary>
    public enum LeagueStatus
    {
        /// <summary>Available (nobody has rostered the player)</summary>
        [Description("Available")] A = 0,
        /// <summary>Rostered (on the current team's roster)</summary>
        [Description("Rostered")] R = 1,
        /// <summary>Unavailable (on another team's roster)</summary>
        [Description("Unavailable")] X = 2,
        /// <summary>Scouted (available and being monitored)</summary>
        [Description("Scouted")] S = 3
    }
}