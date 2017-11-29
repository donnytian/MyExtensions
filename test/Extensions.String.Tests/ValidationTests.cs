using System;
using System.Collections.Generic;
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

        [Theory]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "David", StringComparison.OrdinalIgnoreCase, false)]
        [InlineData(new[] { "Bob", "Alice", null }, null, StringComparison.OrdinalIgnoreCase, true)]
        [InlineData(null, "Me", StringComparison.OrdinalIgnoreCase, false)]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "CARL", StringComparison.CurrentCultureIgnoreCase, true)]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "alice", StringComparison.CurrentCulture, false)]
        public void EnumerableContainsTests(IEnumerable<string> enumerable, string value, StringComparison comparison, bool result)
        {
            // Arrange

            // Act
            var b = enumerable.Contains(value, comparison);

            // Assert
            Assert.Equal(result, b);
        }
    }
}
