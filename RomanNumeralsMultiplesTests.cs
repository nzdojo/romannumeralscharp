using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsMultiplesTests
    {
        RomanNumerals _romanNumerals;
        public RomanNumeralsMultiplesTests()
        {
            _romanNumerals = new RomanNumerals();
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic20ConvertsToRomanNumeralsXX()
        {
            // 1. Setup          
            var expectedValue = "XX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(20);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic30ConvertsToRomanNumeralsXXX()
        {
            // 1. Setup          
            var expectedValue = "XXX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(30);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }
  
     }
}