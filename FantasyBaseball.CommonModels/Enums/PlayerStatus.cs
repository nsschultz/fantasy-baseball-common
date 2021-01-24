using System.ComponentModel;

namespace FantasyBaseball.CommonModels.Enums
{
    /// <summary>The status of the player.</summary>
    public enum PlayerStatus
    {
        /// <summary>Normal</summary>
        [Description("")] XX = 0,
        /// <summary>Disabled List</summary>
        [Description("Disabled List")] DL = 1,
        /// <summary>Not Available</summary>
        [Description("Not Available")] NA = 2,
        /// <summary>New Entry</summary>
        [Description("New Entry")] NE = 3
    }
}