using System;
using System.Numerics;

namespace prime_r.CallMakers.NumberProcessing.Validation
{

    //This class does more basic number manipulation on number strings.
    internal static class ValidationCalc
    {
        internal static bool IsValidInteger(string numberString)
        {
            if (BigInteger.TryParse(numberString, out BigInteger testInt))
            {
                return true;
            }

            return false;
        }

        internal static bool IsPositiveMakePositive(ref string numberString)
        {
            var number = BigInteger.Parse(numberString);
            bool positive = false;

            positive = IsPositiveMakePositive(ref number);
            numberString = number.ToString();

            return positive;
        }

        private static bool IsPositiveMakePositive(ref BigInteger number)
        {
            if (number >= 0 )
            {
                return true;
            }

            number = number * -1;
            return false;
        }
    }
}
