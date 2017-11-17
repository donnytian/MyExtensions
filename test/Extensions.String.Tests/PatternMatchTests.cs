using Xunit;

namespace Extensions.String.Tests
{
    public class PatternMatchTests
    {
        private const string SimpleString = "This is a test string!";
        private const string LocalizedString = "七个隆冬强, 八个隆冬强-> 不服咋滴!";

        [Theory]
        [InlineData(SimpleString, "This?is a ??st strin??")]
        [InlineData(SimpleString, "This is a test string?")]
        [InlineData(SimpleString, "?his is a test string!")]
        [InlineData(LocalizedString, "?个隆冬强, ?个隆冬强?> ??咋滴!")]
        public void IsMatch_SingleWildcard_ShouldMatched(string s, string pattern)
        {
            // Arrange

            // Act
            var isMatched = s.IsMatch(pattern);

            // Assert
            Assert.True(isMatched);
        }

        [Theory]
        [InlineData(SimpleString, "?")]
        [InlineData(SimpleString, "?his?is a ?est string ")]
        [InlineData(SimpleString, "?his?is a ?est string")]
        [InlineData(LocalizedString, "?个隆冬强, ?个隆冬强-> ??咋滴")]
        public void IsMatch_SingleWildcard_ShouldNotMatched(string s, string pattern)
        {
            // Arrange

            // Act
            var isMatched = s.IsMatch(pattern);

            // Assert
            Assert.False(isMatched);
        }
    }
}
