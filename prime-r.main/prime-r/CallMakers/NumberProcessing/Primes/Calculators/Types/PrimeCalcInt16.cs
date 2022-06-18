using System;

namespace prime_r.CallMakers.NumberProcessing.Primes.Calculators.Types
{
    //This does prime-related calculations for Int16-sized numbers. 
    internal class PrimeCalcInt16:APrimeCalcType
    {
        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(short number, out short divisibleBy)
        {
            numberShort = number;
         
            var primeCalc = new PrimeCalcInt16();
            var isPrime = primeCalc.IsPrimeOrIsNotPrimeAndGetDividedBy();

            divisibleBy = divisibleByShort;

            return isPrime;
        }

        private static short numberShort;
        private static short divisibleByShort;

        internal override bool IsPrimeOrIsNotPrimeAndGetDividedBy() 
        {
            var halfwayPoint = Convert.ToDouble(numberShort) / 2;

            for (short i = 2; i < halfwayPoint + 1; i++)
            {
                if (numberShort % i == 0 && i != numberShort)
                {
                    divisibleByShort = i;
                    return false;
                }
            }

            divisibleByShort = numberShort;
            return true;
        }
    }
}
