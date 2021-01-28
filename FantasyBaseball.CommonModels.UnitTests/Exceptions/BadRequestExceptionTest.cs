using FantasyBaseball.CommonModels.Exceptions;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Exceptions
{
    public class BadRequestExceptionTest
    {
        [Fact] public void EqualsMessageTest() => Assert.Equal("message", new BadRequestException("message").Message);
    }
}