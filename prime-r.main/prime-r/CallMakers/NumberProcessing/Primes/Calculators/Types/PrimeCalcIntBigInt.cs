using System;
using System.Numerics;

namespace prime_r.CallMakers.NumberProcessing.Primes.Calculators.Types
{
    //This does prime-related calculations for BigInt-sized numbers. 
    internal class PrimeCalcBigInt:APrimeCalcType
    {
        internal static bool IsPrimeOrIsNotPrimeAndGetDividedBy(BigInteger number, out BigInteger divisibleBy)
        {
            numberBigInt = number;

            var primeCalc = new PrimeCalcBigInt();
            var isPrime = primeCalc.IsPrimeOrIsNotPrimeAndGetDividedBy();

            divisibleBy = divisibleByBigInt;

            return isPrime;
        }

        private static BigInteger numberBigInt;
        private static BigInteger divisibleByBigInt;

        internal override bool IsPrimeOrIsNotPrimeAndGetDividedBy()
        {
            var halfwayPoint = numberBigInt / 2 ;

            for (BigInteger i = 2; i < halfwayPoint + 1; i++)
            {
                if (numberBigInt % i == 0 && i != numberBigInt)
                {
                    divisibleByBigInt = i;
                    return false;
                }
            }

            divisibleByBigInt = numberBigInt;
            return true;
        }
    }
}
