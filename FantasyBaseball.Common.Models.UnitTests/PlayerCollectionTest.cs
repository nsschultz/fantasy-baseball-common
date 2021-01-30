using FantasyBaseball.Common.Models;
using Xunit;

namespace FantasyBaseball.Common.Models.UnitTests
{
    public class PlayerCollectionTest
    {
        [Fact] public void DefaultsSetTest() => Assert.NotNull(new PlayerCollection().Players);
    }
}