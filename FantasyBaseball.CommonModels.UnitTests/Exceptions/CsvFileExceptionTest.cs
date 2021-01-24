using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FantasyBaseball.CommonModels.Exceptions;
using Xunit;

namespace FantasyBaseball.CommonModels.UnitTests.Exceptions
{
    public class CsvFileExceptionTest
    {
        [Fact] public void EqualsMessage() => Assert.Equal("message", new CsvFileException("message").Message);

        [Fact] public void SerializationTest()
        {
            var mem = new MemoryStream();
            var b = new BinaryFormatter();
            b.Serialize(mem, new CsvFileException("message"));
            mem.Position = 0;
            Assert.Equal("message", ((CsvFileException)b.Deserialize(mem)).Message);
        }
    }
}