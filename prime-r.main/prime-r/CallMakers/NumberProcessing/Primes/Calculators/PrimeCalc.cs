using System;
using System.Numerics;
using prime_r.CallMakers.NumberProcessing.Primes.Calculators.Types;

namespace prime_r.CallMakers.NumberProcessing.Primes.Calculators
{
    internal static class PrimeCalc
    {
        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(string numberString, out string divisibleBy)
        {
            if (Int16.TryParse(numberString, out short numberShort))
            {
                return IsPrimeOrIsNotPrimeAndGetDividedBy(numberShort, out divisibleBy);
            }
            else
            {
                if (Int32.TryParse(numberString, out int numberInt))
                {
                    return IsPrimeOrIsNotPrimeAndGetDividedBy(numberInt, out divisibleBy);
                }
                else
                {
                    if (Int64.TryParse(numberString, out long numberLong))
                    {
                        return IsPrimeOrIsNotPrimeAndGetDividedBy(numberLong, out divisibleBy);
                    }
                    else
                    {
                        if (BigInteger.TryParse(numberString, out BigInteger numberBigInt))
                        {
                            return IsPrimeOrIsNotPrimeAndGetDividedBy(numberBigInt, out divisibleBy);
                        }
                        else
                        {
                            divisibleBy = "-1";
                            return false;
                        }
                    }
                }
            }
        }

        private static bool IsPrimeOrIsNotPrimeAndGetDividedBy(short number, out string divisibleBy)
        {
            bool isPrime = PrimeCalcInt16.IsPrimeOrIsNotPrimeAndGetDividedBy(number, out short divisibleByShort);
            divisibleBy = divisibleByShort.ToString();
            return isPrime;
        }

        private static bool IsPrimeOrIsNotPrimeAndGetDividedBy(int number, out string divisibleBy)
        {
            bool isPrime = PrimeCalcInt32.IsPrimeOrIsNotPrimeAndGetDividedBy(number, out int divisibleByInt);
            divisibleBy = divisibleByInt.ToString();
            return isPrime;
        }

        private static bool IsPrimeOrIsNotPrimeAndGetDividedBy(long number, out string divisibleBy)
        {
            bool isPrime = PrimeCalcInt64.IsPrimeOrIsNotPrimeAndGetDividedBy(number, out long divisibleByLong);
            divisibleBy = divisibleByLong.ToString();
            return isPrime;
        }

        private static bool IsPrimeOrIsNotPrimeAndGetDividedBy(BigInteger number, out string divisibleBy)
        {
            bool isPrime = PrimeCalcBigInt.IsPrimeOrIsNotPrimeAndGetDividedBy(number, out BigInteger divisibleByBigInt);
            divisibleBy = divisibleByBigInt.ToString();
            return isPrime;
        }

    }
}
