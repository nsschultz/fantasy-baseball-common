using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FantasyBaseball.CommonModels.Exceptions;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Exceptions
{
    public class BadRequestExceptionTest
    {
        [Fact] public void EqualsMessageTest() => Assert.Equal("message", new BadRequestException("message").Message);

        [Fact] public void SerializationTest()
        {
            var mem = new MemoryStream();
            var b = new BinaryFormatter();
            b.Serialize(mem, new BadRequestException("message"));
            mem.Position = 0;
            Assert.Equal("message", ((BadRequestException)b.Deserialize(mem)).Message);
        }
    }
}