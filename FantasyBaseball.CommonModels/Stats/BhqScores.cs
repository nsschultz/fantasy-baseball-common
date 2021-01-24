namespace FantasyBaseball.CommonModels.Stats
{
    /// <summary>Baseball HQ scores for a given player.</summary>
    public class BhqScores
    {
        /// <summary>The player's projected reliability.</summary>
        public double Reliability { get; set; }

        /// <summary>The player's Mayberry Method score.</summary>
         public int MayberryMethod { get; set; }
    }
}