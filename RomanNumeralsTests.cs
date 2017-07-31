using Xunit;

namespace NumberSystems
{
    public abstract class RomanNumeralsTests
    {
        protected RomanNumerals _romanNumerals = new RomanNumerals();

        protected void exerciseAndVerify(int arabicNumber, string expectedRomanNumber)
        {
           // 1. Setup          

            // 2. Exercise
            var result = _romanNumerals.FromArabic(arabicNumber);

            // 3. Verify
            Assert.True(expectedRomanNumber == result, "Expect Roman Numeral " + expectedRomanNumber + " but got " + result);

            // 4. Cleanup
        }
    }
}