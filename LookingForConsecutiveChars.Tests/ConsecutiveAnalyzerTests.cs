using NUnit.Framework;
using LookingForConsecutiveChars;

namespace LookingForConsecutiveChars.Tests
{
    [TestFixture]
    public class ConsecutiveAnalyzerTests
    {
        [Test]
        public void GetQuantityOfMaxConsecutiveLetters_ParameterIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveLetters(null));
        }

        [TestCase("", ExpectedResult = 0)]
        public int GetQuantityOfMaxConsecutiveLetters_ParameterIsEmptyString_ReturnsZero(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveLetters(str);
        }

        [TestCase("12234566", ExpectedResult = 0)]
        [TestCase(",...,??", ExpectedResult = 0)]
        public int GetQuantityOfMaxConsecutiveLetters_ParameterIsStringWithoutLetters_ReturnsZero(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveLetters(str);
        }

        [TestCase("a", ExpectedResult = 1)]
        [TestCase("aaabbc99999", ExpectedResult = 3)]
        [TestCase("AaAaAacccccbd ЖЖЖЖЖЖЖ", ExpectedResult = 5)]
        [TestCase("bc          LLLLLL", ExpectedResult = 6)]
        [TestCase("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm", ExpectedResult = 100)]
        public int GetQuantityOfMaxConsecutiveLetters_ParameterIsValid_ReturnsCorrectQuantity(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveLetters(str);
        }

        [Test]
        public void GetQuantityOfMaxConsecutiveDigits_ParameterIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveDigits(null));
        }

        [TestCase("", ExpectedResult = 0)]
        public int GetQuantityOfMaxConsecutiveDigits_ParameterIsEmptyString_ReturnsZero(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveDigits(str);
        }

        [TestCase("Hello, world!", ExpectedResult = 0)]
        [TestCase("AaBbCc +-^^", ExpectedResult = 0)]
        public int GetQuantityOfMaxConsecutiveDigits_ParameterIsStringWithoutDigits_ReturnsZero(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveDigits(str);
        }

        [TestCase("1", ExpectedResult = 1)]
        [TestCase("122333444455555 nnnnnnnnnnnnn", ExpectedResult = 5)]
        [TestCase("11112 bc 111111", ExpectedResult = 6)]
        [TestCase("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", ExpectedResult = 100)]
        public int GetQuantityOfMaxConsecutiveDigits_StrParameterIsValid_ReturnsCorrectQuantity(string str)
        {
            return ConsecutiveAnalyzer.GetQuantityOfMaxConsecutiveDigits(str);
        }
    }
}