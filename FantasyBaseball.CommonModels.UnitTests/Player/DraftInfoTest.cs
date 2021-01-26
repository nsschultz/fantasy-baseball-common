using FantasyBaseball.CommonModels.Player;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Player
{
    public class DraftInfoTest
    {
        [Fact] public void DefaultsSetTest()
        {
            var obj = new DraftInfo();
            Assert.Equal(9999, obj.DraftRank);
            Assert.Equal(9999, obj.AverageDraftPick);
            Assert.Equal(9999, obj.HighestPick);
            Assert.Equal(0, obj.DraftedPercentage);
        }
    }
}