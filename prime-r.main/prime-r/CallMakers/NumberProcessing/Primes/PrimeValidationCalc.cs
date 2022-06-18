using prime_r.CallMakers.NumberProcessing.Primes.Calculators;

namespace prime_r.CallMakers.NumberProcessing.Primes
{
    //This class does prime-related number manipulation on number strings.
    static internal class PrimeValidationCalc 
    {
        internal static bool IsNotZeroOrOne(string numberString)
        {
            if (numberString.Length == 1)
            {
                if (numberString == "1" || numberString == "0")
                {
                    return false;
                }
            }

            return true;
        }

        internal static bool IsMaybePrime(string numberString)
        {
            if (LongerThanOne(numberString))
            {
                return CorrectEnding(numberString);
            }

            return numberString.Length == 1;
        }

        private static bool LongerThanOne(string numberString)
        {
            return numberString.Replace("-", "").Length > 1;
        }

        private static bool CorrectEnding(string numberString)
        {
            if (numberString.EndsWith("1")
                || numberString.EndsWith("3")
                || numberString.EndsWith("7")
                || numberString.EndsWith("9"))
            {
                return true;
            }

            return false;
        }

        //not using this right now -->
        private static bool IsMaybePrime(int number)
        {
            var numberString = number.ToString();
            return IsMaybePrime(numberString);
        }
        // <--

        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(string numberString, out string divisibleBy)
        {
            return PrimeCalc.IsPrimeOrIsNotPrimeAndGetDividedBy(numberString, out divisibleBy);
        }
    }
}
