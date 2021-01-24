using FantasyBaseball.CommonModels.Player;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Player
{
    public class DraftInfoTest
    {
        [Fact] public void DefaultsSetTest()
        {
            var obj = new DraftInfo();
            Assert.Equal(DraftInfo.MaxDraftPick, obj.DraftRank);
            Assert.Equal(DraftInfo.MaxDraftPick, obj.AverageDraftPick);
            Assert.Equal(DraftInfo.MaxDraftPick, obj.HighestPick);
            Assert.Equal(0, obj.DraftedPercentage);
        }
    }
}