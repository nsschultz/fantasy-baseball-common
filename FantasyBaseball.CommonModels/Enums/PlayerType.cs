using System.ComponentModel;

namespace FantasyBaseball.CommonModels.Enums
{
    /// <summary>The type of player.</summary>
    public enum PlayerType
    {
        /// <summary>Unknown</summary>
        [Description("Unknown")] U = 0,
        /// <summary>Batter</summary>
        [Description("Batter")] B = 1,
        /// <summary>Pitcher</summary>
        [Description("Pitcher")] P = 2
    }
}