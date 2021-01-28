namespace FantasyBaseball.CommonModels.Player
{
    /// <summary>Draft Info for a given Player.</summary>
    public class DraftInfo
    {   
        private const int MaxDraftPick = 9999;

        /// <summary>The rank of this player in the draft.</summary>
        public int DraftRank { get; set; } = MaxDraftPick;

        /// <summary>The average draft position (ADP) for this player.</summary>
        public int AverageDraftPick { get; set; } = MaxDraftPick;

        /// <summary>The highest pick that was used on this player.</summary>
        public int HighestPick { get; set; } = MaxDraftPick;

        /// <summary>The percentage of time that this player was drafted.</summary>
        public double DraftedPercentage { get; set; }
    }
}