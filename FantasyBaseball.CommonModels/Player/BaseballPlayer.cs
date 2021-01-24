using FantasyBaseball.CommonModels.Stats;

namespace FantasyBaseball.CommonModels.Player
{
    /// <summary>All of the information that makes up a baseball player.</summary>
    public class BaseballPlayer
    {
        /// <summary>Info for a given Player.</summary>
        public PlayerInfo PlayerInfo { get; set; } = new PlayerInfo();

        /// <summary>League Info for a given Player.</summary>
        public LeagueInfo LeagueInfo { get; set; } = new LeagueInfo();

        /// <summary>Draft Info for a given Player.</summary>
        public DraftInfo DraftInfo { get; set; } = new DraftInfo();

        /// <summary>Baseball HQ scores for a given player.</summary>
        public BhqScores BhqScores { get; set; } = new BhqScores();

        /// <summary>Year To Date Batting Stats for a given player.</summary>
        public BattingStats YearToDateBattingStats { get; set; } = new BattingStats();

        /// <summary>Year To Date Pitching Stats for a given player.</summary>
        public PitchingStats YearToDatePitchingStats { get; set; } = new PitchingStats();

        /// <summary>Projected Batting Stats for a given player.</summary>
        public BattingStats ProjectedBattingStats { get; set; } = new BattingStats();

        /// <summary>Projected Pitching Stats for a given player.</summary>
        public PitchingStats ProjectedPitchingStats { get; set; } = new PitchingStats();

        /// <summary>Combined Batting Stats for a given player.</summary>
        public BattingStats CombinedBattingStats { get; set; } = new BattingStats();

        /// <summary>Combined Pitching Stats for a given player.</summary>
        public PitchingStats CombinedPitchingStats { get; set; } = new PitchingStats();
    }
}