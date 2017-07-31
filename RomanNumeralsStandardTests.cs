using Xunit;
using NumberSystems;

namespace NumberSystems
{
    public class RomanNumeralsStandardTests : RomanNumeralsTests
    {

        [Fact]
        public void FromArabicZeroConvertsToNothing()
        {
            exerciseAndVerify(0, string.Empty);

        }

        [Fact]
        public void FromArabicOneConvertsToRomanNumeralsI()
        {
            exerciseAndVerify(1, "I");
        }

        [Fact]
        public void FromArabicTwoConvertsToRomanNumeralsII()
        {
            exerciseAndVerify(2, "II");
        }

        [Fact]
        public void FromArabicThreeConvertsToRomanNumeralsIII()
        {
            exerciseAndVerify(3, "III");
        }    

        [Fact]
        public void FromArabicFourConvertsToRomanNumeralsIV()
        {
            exerciseAndVerify(4, "IV");
        }     

        [Fact]
        public void FromArabicFiveConvertsToRomanNumeralsV()
        {
            exerciseAndVerify(5, "V");
        }   

        [Fact]
        public void FromArabicNineConvertsToRomanNumeralsIX()
        {
            exerciseAndVerify(9, "IX");
        }   

        [Fact]
        public void FromArabicTenConvertsToRomanNumeralsX()
        {
            exerciseAndVerify(10, "X");
        } 

        [Fact]
        public void FromArabic6ConvertsToRomanNumeralsVI()
        {
            exerciseAndVerify(6, "VI");
        } 

        [Fact]
        public void FromArabic7ConvertsToRomanNumeralsVII()
        {
            exerciseAndVerify(7, "VII");
        }

        [Fact]
        public void FromArabic8ConvertsToRomanNumeralsVIII()
        {
            exerciseAndVerify(8, "VIII");
        }

        [Fact]
        public void FromArabic15ConvertsToRomanNumeralsXV()
        {
            exerciseAndVerify(15, "XV");
        }

       [Fact]
        public void FromArabic50ConvertsToRomanNumeralsL()
        {
            exerciseAndVerify(50, "L");
        }

       [Fact]
        public void FromArabic100ConvertsToRomanNumeralsC()
        {
            exerciseAndVerify(100, "C");
        }

       [Fact]
        public void FromArabic1000ConvertsToRomanNumeralsM()
        {
            exerciseAndVerify(1000, "M");
        }
    }
}