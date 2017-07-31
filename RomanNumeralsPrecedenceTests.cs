using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsPrecedenceTests
    {
        RomanNumerals _romanNumerals;
        public RomanNumeralsPrecedenceTests()
        {
            _romanNumerals = new RomanNumerals();
        }

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

      }
}