using System;

namespace NumberSystems
{
    public class RomanNumerals
    {
        public string FromArabic(int arabicNumber) 
        {
            if (arabicNumber == 0)
                return string.Empty;
            else if (arabicNumber == 1)
                return "I";

            return string.Empty;
        } 
    }
}