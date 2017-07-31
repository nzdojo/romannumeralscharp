using Xunit;

namespace NumberSystems
{
    public class RomanNumeralsMultiplesTests : RomanNumeralsTests
    {

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
  
        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic200ConvertsToRomanNumeralsCC()
        {
            // 1. Setup          
            var expectedValue = "CC";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(200);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic300ConvertsToRomanNumeralsCCC()
        {
            // 1. Setup          
            var expectedValue = "CCC";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(300);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic2000ConvertsToRomanNumeralsMM()
        {
            // 1. Setup          
            var expectedValue = "MM";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(2000);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

     }
}