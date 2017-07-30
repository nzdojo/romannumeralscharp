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
    }
}