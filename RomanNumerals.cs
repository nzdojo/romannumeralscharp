using System;
using System.Collections.Generic;

namespace NumberSystems
{
    public class RomanNumerals
    {
        private struct ArabicToRoman {
            public ArabicToRoman(int arabicNumber, string romanNumber) {
                this.ArabicNumber = arabicNumber;
                this.RomanNumber = romanNumber;
            }
            public int ArabicNumber {get;}
            public string RomanNumber {get;}
        }

        private ArabicToRoman[] _arabicToRomanNumeralMap;

        public RomanNumerals()
        {
            _arabicToRomanNumeralMap = new ArabicToRoman[] {
                    new ArabicToRoman(1000, "M"),
                    new ArabicToRoman(900, "CM"),
                    new ArabicToRoman(100, "C"),
                    new ArabicToRoman(90, "XC"),
                    new ArabicToRoman(50, "L"),
                    new ArabicToRoman(40, "XL"),
                    new ArabicToRoman(10, "X"),
                    new ArabicToRoman(9, "IX"),
                    new ArabicToRoman(8, "VIII"),
                    new ArabicToRoman(7, "VII"),
                    new ArabicToRoman(6, "VI"),
                    new ArabicToRoman(5, "V"),
                    new ArabicToRoman(4, "IV"),
                    new ArabicToRoman(3, "III"),
                    new ArabicToRoman(2, "II"), 
                    new ArabicToRoman(1, "I")
                };
        }
        public string FromArabic(int arabicNumber) 
        {
            var romanNumber = string.Empty;
            
            if (arabicNumber == 0)
                return string.Empty;
                
            var numberMapCounter = 0;
            while (arabicNumber > 0 && numberMapCounter < _arabicToRomanNumeralMap.Length) {
                var mappingNumber = _arabicToRomanNumeralMap[numberMapCounter].ArabicNumber;
                if (arabicNumber % mappingNumber == 0) {
                    romanNumber += _arabicToRomanNumeralMap[numberMapCounter].RomanNumber;
                    arabicNumber -= mappingNumber;
                } else if (arabicNumber >= mappingNumber) {
                    romanNumber += _arabicToRomanNumeralMap[numberMapCounter].RomanNumber;
                    arabicNumber -= mappingNumber;
                    if (arabicNumber < mappingNumber)
                        numberMapCounter++;                    
                } else {
                    numberMapCounter++;   
                }
            }

            return romanNumber;
        } 
    }
}