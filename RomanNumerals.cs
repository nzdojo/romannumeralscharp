using System;

namespace NumberSystems
{
    public class RomanNumerals
    {
        public string FromArabic(int arabicNumber) 
        {
            var romanNumber = string.Empty;

            if (arabicNumber == 0)
                return string.Empty;

            while (arabicNumber <= 5 && arabicNumber > 0) {
                if (arabicNumber == 5) {
                    romanNumber += "V";
                    arabicNumber -= 5;
                } else if (arabicNumber == 4) {
                    romanNumber += "IV";
                    arabicNumber -= 4;
                } else {
                    romanNumber += "I";
                    arabicNumber -= 1;
                }
            }

            return romanNumber;
        } 
    }
}