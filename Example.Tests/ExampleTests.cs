using System;
using System.Threading.Tasks;
using Xunit;

namespace Example.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void Parse_WithValidInput_ReturnsValue()
        {
            var example = new Example();
            
            Assert.Equal(10, example.Parse("10"));
        }

        [Fact]
        public void Parse_WithInvalidInput_ThrowsFormatException()
        {
            var example = new Example();

            Assert.Throws<FormatException>(() => example.Parse("test"));
        }

        [Fact]
        public async Task ParseAsync_WithValidInput_ReturnsValue()
        {
            var example = new Example();

            Assert.Equal(10, await example.ParseAsync("10"));
        }

        [Fact]
        public async Task ParseAsync_WithInvalidInput_ThrowsFormatException()
        {
            var example = new Example();

            await Assert.ThrowsAsync<FormatException>(() => example.ParseAsync("test"));
        }
    }
}
