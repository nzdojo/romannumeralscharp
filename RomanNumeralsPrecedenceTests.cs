using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsPrecedenceTests : RomanNumeralsTests
    {

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic19ConvertsToRomanNumeralsXIX()
        {
            exerciseAndVerify(19, "XIX");
        }

        [Fact]
        [Trait("Type", "Precedence")]
        public void FromArabic49ConvertsToRomanNumeralsXLIX()
        {
            exerciseAndVerify(49, "XLIX");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1990ConvertsToRomanNumeralsMCMXC()
        {
            exerciseAndVerify(1990, "MCMXC");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1999ConvertsToRomanNumeralsMCMXCIX()
        {
            exerciseAndVerify(1999, "MCMXCIX");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1998ConvertsToRomanNumeralsMCMXCVIII()
        {
            exerciseAndVerify(1998, "MCMXCVIII");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic1995ConvertsToRomanNumeralsMCMXCV()
        {
            exerciseAndVerify(1995, "MCMXCV");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic900ConvertsToRomanNumeralsCM()
        {
            exerciseAndVerify(900, "CM");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic400ConvertsToRomanNumeralsCD()
        {
            exerciseAndVerify(400, "CD");
        }

        [Fact]
        [Trait("Type", "Precedence")] 
        public void FromArabic401ConvertsToRomanNumeralsCDI()
        {
            exerciseAndVerify(401, "CDI");
        }

      }
}