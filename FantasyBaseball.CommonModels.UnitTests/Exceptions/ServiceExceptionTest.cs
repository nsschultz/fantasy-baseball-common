using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FantasyBaseball.CommonModels.Exceptions;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Exceptions
{
    public class ServiceExceptionTest
    {
        [Fact] public void EqualsMessage() => Assert.Equal("message", new ServiceException("message").Message);

        [Fact] public void SerializationTest()
        {
            var mem = new MemoryStream();
            var b = new BinaryFormatter();
            b.Serialize(mem, new ServiceException("message"));
            mem.Position = 0;
            Assert.Equal("message", ((ServiceException)b.Deserialize(mem)).Message);
        }
    }
}