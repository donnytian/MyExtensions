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

        [Theory]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("dummy", "ymmud")]
        public void ReverseTests(string s, string exptected)
        {
            // Arrange

            // Act
            var reversed = s.Reverse();

            // Assert
            Assert.Equal(exptected, reversed);
        }

        [Theory]
        [InlineData("", 5, 2, "")]
        [InlineData("dummy", 5, 5, "dummy")]
        [InlineData("dummy", 4, 5, "dummy")]
        [InlineData("dummy", 3, 1, "dummy")]
        [InlineData("dummy", 3, 2, "dumym")]
        public void ReverseByIndexTests(string s, int index, int length, string exptected)
        {
            // Arrange

            // Act
            var reversed = s.Reverse(index, length);

            // Assert
            Assert.Equal(exptected, reversed);
        }
    }
}
