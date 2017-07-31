using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsPrecedenceTests : RomanNumeralsTests
    {

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic19ConvertsToRomanNumeralsXIX()
        {
            // 1. Setup          
            var expectedValue = "XIX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(19);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Precedence")]
        public void FromArabic49ConvertsToRomanNumeralsXLIX()
        {
            // 1. Setup          
            var expectedValue = "XLIX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(49);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1990ConvertsToRomanNumeralsMCMXC()
        {
            // 1. Setup          
            var expectedValue = "MCMXC";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(1990);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1999ConvertsToRomanNumeralsMCMXCIX()
        {
            // 1. Setup          
            var expectedValue = "MCMXCIX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(1999);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1998ConvertsToRomanNumeralsMCMXCVIII()
        {
            // 1. Setup          
            var expectedValue = "MCMXCVIII";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(1998);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1995ConvertsToRomanNumeralsMCMXCV()
        {
            // 1. Setup          
            var expectedValue = "MCMXCV";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(1995);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

      }
}