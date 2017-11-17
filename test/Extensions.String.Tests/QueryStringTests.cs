﻿using Extensions.String.Web;
using Xunit;

namespace Extensions.String.Tests
{
    public class QueryStringTests
    {
        [Theory]
        [InlineData(null, "", "123", "")]
        [InlineData("", "id", "123", "?id=123")]
        [InlineData("a.b.com", "id", "123", "a.b.com?id=123")]
        [InlineData("a.b.com/?a=b", "id", "123", "a.b.com/?a=b&id=123")]
        [InlineData("a.b.com/?a=b&b=c", "id", "123", "a.b.com/?a=b&b=c&id=123")]
        public void SetQueryStringParameterTests(string url, string name, string value, string result)
        {
            // Arrange

            // Act
            var newUrl = url.SetQueryStringParameter(name, value);

            // Assert
            Assert.Equal(result, newUrl);
        }
    }
}
