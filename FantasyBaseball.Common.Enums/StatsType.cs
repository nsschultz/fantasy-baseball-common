using System.ComponentModel;

namespace FantasyBaseball.Common.Enums
{
    /// <summary>The type of stats.</summary>
    public enum StatsType
    {
        /// <summary>Unknown Stats</summary>
        [Description("Unknown Stats")] UNKN = 0,
        /// <summary>Year To Date Stats</summary>
        [Description("Year to Date Stats")] YTD = 1,
        /// <summary>Projected Stats</summary>
        [Description("Projected Stats")] PROJ = 2,
        /// <summary>Combined Stats</summary>
        [Description("Combined Stats")] CMBD = 3
    }
}