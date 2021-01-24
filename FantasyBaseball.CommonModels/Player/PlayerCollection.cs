using System.Collections.Generic;

namespace FantasyBaseball.CommonModels.Player
{
    /// <summary>A simple object for holding a collection of <c>BaseballPlayer</c> objects.</summary>
    public class PlayerCollection
    {
        /// <summary>A collection of <c>BaseballPlayer</c> objects.</summary>
        public List<BaseballPlayer> Players { get; set; } = new List<BaseballPlayer>();
    }
}