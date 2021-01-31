using FantasyBaseball.Common.Enums;
using FantasyBaseball.Common.Models;
using System;
using Xunit;

namespace FantasyBaseball.Common.Models.UnitTests
{
    public class BaseballPlayerTest
    {
        [Fact] public void DefaultsSetTest()
        {
            var obj = new BaseballPlayer();
            Assert.Equal(Guid.Empty, obj.Id);
            Assert.Equal(0, obj.BhqId);
            Assert.Null(obj.FirstName);
            Assert.Null(obj.LastName);
            Assert.Equal(0, obj.Age);
            Assert.Equal(PlayerType.U, obj.Type);
            Assert.Null(obj.Positions);
            Assert.Null(obj.Team);
            Assert.Equal(PlayerStatus.XX, obj.Status);
            Assert.Equal(LeagueStatus.A, obj.League1);
            Assert.Equal(LeagueStatus.A, obj.League2);
            Assert.Equal(9999, obj.DraftRank);
            Assert.Equal(9999, obj.AverageDraftPick);
            Assert.Equal(9999, obj.HighestPick);
            Assert.Equal(0, obj.DraftedPercentage);
            Assert.Equal(0, obj.Reliability);
            Assert.Equal(0, obj.MayberryMethod);
            Assert.NotNull(obj.YearToDateBattingStats);
            Assert.NotNull(obj.YearToDatePitchingStats);
            Assert.NotNull(obj.ProjectedBattingStats);
            Assert.NotNull(obj.ProjectedPitchingStats);
            Assert.NotNull(obj.CombinedBattingStats);
            Assert.NotNull(obj.CombinedPitchingStats);
        }
    }
}