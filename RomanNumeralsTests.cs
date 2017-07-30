using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void FromArabicZeroConvertsToNothing()
        {
            // 1. Setup          
            var romanNumerals = new RomanNumerals();

            // 2. Exercise
            var result = romanNumerals.FromArabic(0);

            // 3. Verify
            Assert.True(string.Empty == result, "We don't have anything yet");

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicOneConvertsToRomanNumeralsI()
        {
            // 1. Setup          
            var romanNumerals = new RomanNumerals();
            var expectedValue = "I";

            // 2. Exercise
            var result = romanNumerals.FromArabic(1);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicTwoConvertsToRomanNumeralsII()
        {
            // 1. Setup          
            var romanNumerals = new RomanNumerals();
            var expectedValue = "II";

            // 2. Exercise
            var result = romanNumerals.FromArabic(2);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicThreeConvertsToRomanNumeralsIII()
        {
            // 1. Setup          
            var romanNumerals = new RomanNumerals();
            var expectedValue = "III";

            // 2. Exercise
            var result = romanNumerals.FromArabic(3);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }    

        [Fact]
        public void FromArabicFourConvertsToRomanNumeralsIV()
        {
            // 1. Setup          
            var romanNumerals = new RomanNumerals();
            var expectedValue = "IV";

            // 2. Exercise
            var result = romanNumerals.FromArabic(4);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }             
    }
}