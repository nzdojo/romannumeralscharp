using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsCombosTests : RomanNumeralsTests
    {

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic150ConvertsToRomanNumeralsCL()
        {
            // 1. Setup          
            var expectedValue = "CL";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(150);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

       [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic11ConvertsToRomanNumeralsXI()
        {
            // 1. Setup          
            var expectedValue = "XI";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(11);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic15ConvertsToRomanNumeralsXV()
        {
            // 1. Setup          
            var expectedValue = "XV";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(15);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic2002ConvertsToRomanNumeralsMMII()
        {
            // 1. Setup          
            var expectedValue = "MMII";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(2002);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic88ConvertsToRomanNumeralsLXXXVIII()
        {
            // 1. Setup          
            var expectedValue = "LXXXVIII";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(88);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue + " but got " + result);

            // 4. Cleanup
        }

      }
}