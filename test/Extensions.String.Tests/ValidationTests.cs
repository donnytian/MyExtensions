using System;
using Xunit;

namespace Extensions.String.Tests
{
    public class ValidationTests
    {
        [Theory]
        [InlineData(null, "TeSt", StringComparison.OrdinalIgnoreCase, false)]
        [InlineData("test", null, StringComparison.OrdinalIgnoreCase, false)]
        [InlineData("this is a test", "TeSt", StringComparison.OrdinalIgnoreCase, true)]
        [InlineData("this is a test", "TeSt", StringComparison.InvariantCulture, false)]
        public void ContainsTests(string s, string subString, StringComparison comparison, bool result)
        {
            // Arrange

            // Act
            var b = s.Contains(subString, comparison);

            // Assert
            Assert.Equal(result, b);
        }
    }
}
