using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsTests
    {
        RomanNumerals _romanNumerals;
        public RomanNumeralsTests()
        {
            _romanNumerals = new RomanNumerals();
        }

        [Fact]
        public void FromArabicZeroConvertsToNothing()
        {
            // 1. Setup          

            // 2. Exercise
            var result = _romanNumerals.FromArabic(0);

            // 3. Verify
            Assert.True(string.Empty == result, "We don't have anything yet");

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicOneConvertsToRomanNumeralsI()
        {
            // 1. Setup          
            var expectedValue = "I";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(1);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicTwoConvertsToRomanNumeralsII()
        {
            // 1. Setup          
            var expectedValue = "II";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(2);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabicThreeConvertsToRomanNumeralsIII()
        {
            // 1. Setup          
            var expectedValue = "III";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(3);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }    

        [Fact]
        public void FromArabicFourConvertsToRomanNumeralsIV()
        {
            // 1. Setup          
            var expectedValue = "IV";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(4);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }     

        [Fact]
        public void FromArabicFiveConvertsToRomanNumeralsV()
        {
            // 1. Setup          
            var expectedValue = "V";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(5);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }                
    }
}