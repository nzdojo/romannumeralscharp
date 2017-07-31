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
            exerciseAndVerify(150, "CL");
        }

       [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic11ConvertsToRomanNumeralsXI()
        {
            exerciseAndVerify(11, "XI");
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic15ConvertsToRomanNumeralsXV()
        {
            exerciseAndVerify(15, "XV");
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic2002ConvertsToRomanNumeralsMMII()
        {
            exerciseAndVerify(2002, "MMII");
        }

        [Fact]
        [Trait("Type", "Combo")]
        public void FromArabic88ConvertsToRomanNumeralsLXXXVIII()
        {
            exerciseAndVerify(88, "LXXXVIII");
        }
      }
}