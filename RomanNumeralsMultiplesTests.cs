using System;
using Xunit;

namespace NumberSystems
{
    public class RomanNumeralsMultiplesTests : RomanNumeralsTests
    {
        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic20ConvertsToRomanNumeralsXX()
        {
            exerciseAndVerify(20, "XX");
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic30ConvertsToRomanNumeralsXXX()
        {
            exerciseAndVerify(30, "XXX");
        }
  
        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic200ConvertsToRomanNumeralsCC()
        {
            exerciseAndVerify(200, "CC");
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic300ConvertsToRomanNumeralsCCC()
        {
            exerciseAndVerify(300, "CCC");
        }

        [Fact]
        [Trait("Type", "Multiple")]
        public void FromArabic2000ConvertsToRomanNumeralsMM()
        {
            exerciseAndVerify(2000, "MM");
        }
     }
}