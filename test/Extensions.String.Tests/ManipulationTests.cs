using Xunit;

namespace Extensions.String.Tests
{
    public class ManipulationTests
    {
        [Theory]
        [InlineData("", 5, null, "")]
        [InlineData(null, 10, null, "")]
        [InlineData("dummy", 5, ".", "dummy")]
        [InlineData("this is a test", 10, "...", "this is a ...")]
        [InlineData("123456", 10, "...", "123456")]
        public void TruncateTests(string s, int length, string suffix, string result)
        {
            // Arrange

            // Act
            var truncated = s.Truncate(length, suffix);

            // Assert
            Assert.Equal(result, truncated);
        }
    }
}
