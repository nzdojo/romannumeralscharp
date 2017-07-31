using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsOddmentsTests
    {
        RomanNumerals _romanNumerals;
        public RomanNumeralsOddmentsTests()
        {
            _romanNumerals = new RomanNumerals();
        }

        [Fact]
        [Trait("Type", "Oddment")]
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

      }
}