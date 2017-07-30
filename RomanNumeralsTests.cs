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

            // 2. Exercise
            var result = romanNumerals.FromArabic(1);

            // 3. Verify
            Assert.True("1" == result, "We don't have anything yet");

            // 4. Cleanup
        }
    }
}