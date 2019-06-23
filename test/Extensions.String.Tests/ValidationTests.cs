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
            AssertBool(() => s.Contains(subString, comparison), result);
        }

        [Theory]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "David", StringComparison.OrdinalIgnoreCase, false)]
        [InlineData(new[] { "Bob", "Alice", null }, null, StringComparison.OrdinalIgnoreCase, true)]
        [InlineData(null, "Me", StringComparison.OrdinalIgnoreCase, false)]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "CARL", StringComparison.CurrentCultureIgnoreCase, true)]
        [InlineData(new[] { "Bob", "Alice", "Carl" }, "alice", StringComparison.CurrentCulture, false)]
        public void EnumerableContainsTests(IEnumerable<string> enumerable, string value, StringComparison comparison, bool result)
        {
            AssertBool(() => enumerable.Contains(value, comparison), result);
        }

        [Theory]
        [InlineData("d", StringComparison.OrdinalIgnoreCase, new[] { "Bob", "Alice", "Carl" }, false)]
        [InlineData(null, StringComparison.OrdinalIgnoreCase, new[] { "Bob", "Alice", null }, true)]
        [InlineData(null, StringComparison.OrdinalIgnoreCase, new[] { "Me" }, false)]
        [InlineData("CARL", StringComparison.CurrentCultureIgnoreCase, new[] { "Bob", "Alice", "Carl" }, true)]
        [InlineData("alice", StringComparison.CurrentCulture, new[] { "Bob", "Alice", "Carl" }, false)]
        public void EqualsAny(string s, StringComparison comparison, string[] targets, bool expected)
        {
            AssertBool(() => s.EqualsAny(comparison, targets), expected);
        }

        private static void AssertBool(Func<bool> action, bool expected)
        {
            // Arrange, Act
            var actual = action();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
