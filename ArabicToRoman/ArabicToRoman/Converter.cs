namespace ArabicToRoman
{
    using ArabicToRoman.enums;
    using System;
    public static class Converter
    {
        public static string ArabicToRoman(uint num)
        {
            if (num < 0 || num > 3999)
            {
                throw new ArgumentOutOfRangeException("Number should be between 1 and 3999(inclusive)!");
            }

            if (num >= 1000)
            {
                return RNums.M.ToString() + ArabicToRoman(num - ((uint)RNums.M));
            }
            else if (num >= 900)
            {
                return RNums.CM.ToString() + ArabicToRoman(num - ((uint)RNums.CM));
            }
            else if (num >= 500)
            {
                return RNums.D.ToString() + ArabicToRoman(num - ((uint)RNums.D));
            }
            else if (num >= 400)
            {
                return RNums.CD.ToString() + ArabicToRoman(num - ((uint)RNums.CD));
            }
            else if (num >= 100)
            {
                return RNums.C.ToString() + ArabicToRoman(num - ((uint)RNums.C));
            }
            else if (num >= 90)
            {
                return RNums.XC.ToString() + ArabicToRoman(num - ((uint)RNums.XC));
            }
            else if (num >= 50)
            {
                return RNums.L.ToString() + ArabicToRoman(num - ((uint)RNums.L));
            }
            else if (num >= 40)
            {
                return RNums.XL.ToString() + ArabicToRoman(num - ((uint)RNums.XL));
            }
            else if (num >= 10)
            {
                return RNums.X.ToString() + ArabicToRoman(num - ((uint)RNums.X));
            }
            else if (num >= 9)
            {
                return RNums.lX.ToString() + ArabicToRoman(num - ((uint)RNums.lX));
            }
            else if (num >= 5)
            {
                return RNums.V.ToString() + ArabicToRoman(num - ((uint)RNums.V));
            }
            else if (num >= 4)
            {
                return RNums.lV.ToString() + ArabicToRoman(num - ((uint)RNums.lV));
            }
            else if (num >= 1)
            {
                return RNums.l.ToString() + ArabicToRoman(num - ((uint)RNums.l));
            }

            return string.Empty;
        }
    }
}
