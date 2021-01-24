using FantasyBaseball.CommonModels.Enums;
using FantasyBaseball.CommonModels.Player;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Player
{
    public class BaseballPlayerTest
    {
        [Fact] public void DefaultsSetTest()
        {
            var obj = new BaseballPlayer();
            Assert.NotNull(obj.PlayerInfo);
            Assert.Equal(0, obj.PlayerInfo.Id);
            Assert.Null(obj.PlayerInfo.FirstName);
            Assert.Null(obj.PlayerInfo.LastName);
            Assert.Equal(0, obj.PlayerInfo.Age);
            Assert.Equal(PlayerType.U, obj.PlayerInfo.Type);
            Assert.Null(obj.PlayerInfo.Positions);
            Assert.Null(obj.PlayerInfo.Team);
            Assert.Equal(PlayerStatus.XX, obj.PlayerInfo.Status);
            Assert.NotNull(obj.LeagueInfo);
            Assert.Equal(LeagueStatus.A, obj.LeagueInfo.League1);
            Assert.Equal(LeagueStatus.A, obj.LeagueInfo.League2);
            Assert.NotNull(obj.DraftInfo);
            Assert.NotNull(obj.BhqScores);
            Assert.Equal(0, obj.BhqScores.Reliability);
            Assert.Equal(0, obj.BhqScores.MayberryMethod);
            Assert.NotNull(obj.YearToDateBattingStats);
            Assert.NotNull(obj.YearToDatePitchingStats);
            Assert.NotNull(obj.ProjectedBattingStats);
            Assert.NotNull(obj.ProjectedPitchingStats);
            Assert.NotNull(obj.CombinedBattingStats);
            Assert.NotNull(obj.CombinedPitchingStats);
        }
    }
}