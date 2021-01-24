using FantasyBaseball.CommonModels.Player;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Player
{
    public class PlayerCollectionTest
    {
        [Fact] public void DefaultsSetTest() => Assert.NotNull(new PlayerCollection().Players);
    }
}