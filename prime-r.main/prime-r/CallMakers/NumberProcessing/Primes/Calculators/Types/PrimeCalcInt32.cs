using System;

namespace prime_r.CallMakers.NumberProcessing.Primes.Calculators.Types
{
    //This does prime-related calculations for Int32-sized numbers. 
    internal class PrimeCalcInt32:APrimeCalcType
    {
        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(int number, out int divisibleBy)
        {
            numberInt = number;

            var primeCalc = new PrimeCalcInt32();
            var isPrime = primeCalc.IsPrimeOrIsNotPrimeAndGetDividedBy();

            divisibleBy = divisibleByInt;

            return isPrime;
        }

        private static int numberInt;
        private static int divisibleByInt;

        internal override bool IsPrimeOrIsNotPrimeAndGetDividedBy()
        {
            var halfwayPoint = Convert.ToDouble(numberInt) / 2;

            for (int i = 2; i < halfwayPoint + 1; i++)
            {
                if (numberInt % i == 0 && i != numberInt)
                {
                    divisibleByInt = i;
                    return false;
                }
            }

            divisibleByInt = numberInt;
            return true;
        }
    }
}
