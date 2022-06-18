using System;

namespace prime_r.CallMakers.NumberProcessing.Primes.Calculators.Types
{
    //This does prime-related calculations for Int64-sized numbers. 
    internal class PrimeCalcInt64:APrimeCalcType
    {
        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(long number, out long divisibleBy)
        {
            numberLong = number;

            var primeCalc = new PrimeCalcInt64();
            var isPrime = primeCalc.IsPrimeOrIsNotPrimeAndGetDividedBy();

            divisibleBy = divisibleByLong;

            return isPrime;
        }

        private static long numberLong;
        private static long divisibleByLong;

        internal override bool IsPrimeOrIsNotPrimeAndGetDividedBy()
        {
            var halfwayPoint = Convert.ToDouble(numberLong) / 2;

            for (long i = 2; i < halfwayPoint + 1; i++)
            {
                if (numberLong % i == 0 && i != numberLong)
                {
                    divisibleByLong = i;
                    return false;
                }
            }

            divisibleByLong = numberLong;
            return true;
        }
    }
}
