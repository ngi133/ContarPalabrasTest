



using ContarPalabras;

namespace ContarPalabrasTests
{
    
    public class StringUtilsTests
    {
        public StringUtils _stringUtils;

        public StringUtilsTests()
        {
            _stringUtils = new StringUtils();
        }

        // Prueba para el m�todo CountWords
        [Theory]
        [InlineData("Hola mundo", 2)]
        [InlineData("   Una    dos   tres    ", 3)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void CountWords_ShouldReturnCorrectWordCount(string input, int expectedCount)
        {
            // Act
            int actualCount = _stringUtils.CountWords(input);

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }

        // Prueba para el m�todo ReverseString
        [Theory]
        [InlineData("Hola", "aloH")]
        [InlineData("Programaci�n", "n�icamargorP")]
        [InlineData("", "")]
        public void ReverseString_ShouldReturnReversedString(string input, string expectedReversed)
        {
            // Act
            string actualReversed = _stringUtils.ReverseString(input);

            // Assert
            Assert.Equal(expectedReversed, actualReversed);
        }
    }
}