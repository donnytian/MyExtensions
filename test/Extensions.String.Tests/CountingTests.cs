using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Extensions.String.Tests
{
    public class CountingTests
    {
        [Fact]
        public void SizeTests()
        {
            // Arrange
            var s = "Dummy!";
            var unicode = Encoding.Unicode;
            var ascii = Encoding.ASCII;
            var utf8 = Encoding.UTF8;

            // Act
            var sizeOfEmpty = string.Empty.Size();
            var size = s.Size(null);
            var sizeOfUnicode = s.Size(unicode);
            var sizeOfAscii = s.Size(ascii);
            var sizeOfUtf8 = s.Size(utf8);

            // Assert
            Assert.Equal(0, sizeOfEmpty);
            Assert.Equal(12, size);
            Assert.Equal(12, sizeOfUnicode);
            Assert.Equal(6, sizeOfAscii);
            Assert.Equal(6, sizeOfUtf8);
        }
    }
}
