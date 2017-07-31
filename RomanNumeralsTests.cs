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

        [Fact]
        public void FromArabicNineConvertsToRomanNumeralsIX()
        {
            // 1. Setup          
            var expectedValue = "IX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(9);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }   

        [Fact]
        public void FromArabicTenConvertsToRomanNumeralsX()
        {
            // 1. Setup          
            var expectedValue = "X";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(10);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        } 

        [Fact]
        public void FromArabic6ConvertsToRomanNumeralsVI()
        {
            // 1. Setup          
            var expectedValue = "VI";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(6);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        } 

        [Fact]
        public void FromArabic7ConvertsToRomanNumeralsVII()
        {
            // 1. Setup          
            var expectedValue = "VII";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(7);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabic8ConvertsToRomanNumeralsVIII()
        {
            // 1. Setup          
            var expectedValue = "VIII";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(8);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabic20ConvertsToRomanNumeralsXX()
        {
            // 1. Setup          
            var expectedValue = "XX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(20);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabic19ConvertsToRomanNumeralsXIX()
        {
            // 1. Setup          
            var expectedValue = "XIX";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(19);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

        [Fact]
        public void FromArabic15ConvertsToRomanNumeralsXV()
        {
            // 1. Setup          
            var expectedValue = "XV";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(15);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

       [Fact]
        public void FromArabic50ConvertsToRomanNumeralsL()
        {
            // 1. Setup          
            var expectedValue = "L";

            // 2. Exercise
            var result = _romanNumerals.FromArabic(50);

            // 3. Verify
            Assert.True(expectedValue == result, "Expect Roman Numeral " + expectedValue);

            // 4. Cleanup
        }

    }
}