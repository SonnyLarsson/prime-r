using prime_r.CallMakers.NumberProcessing.Validation;
using prime_r.CallMakers.NumberProcessing.Messages;
using prime_r.CallMakers.NumberProcessing.Primes;

namespace prime_r.CallMakers.NumberProcessing
{
    internal static class CalculationAndValidation
    {
        //This class compiles calculation and validation results and combines them with information about the results.
        internal static string TestIfValidIntegerAndGetInfo(string numberString, out bool continueTesting)
        {
            continueTesting = ValidationCalc.IsValidInteger(numberString);

            if (continueTesting)
            {
                return CalculationAndValidationMessages.IsValidInteger(numberString);
            }
            else
            {
                return CalculationAndValidationMessages.IsNotValidInteger(numberString);
            }
        }

        internal static string TestIfPositiveNumberAndGetInfo(ref string numberString, out bool isPositive)
        {
            string originalNumberString = numberString;
            isPositive = ValidationCalc.IsPositiveMakePositive(ref numberString);

            if (isPositive)
            {
                return CalculationAndValidationMessages.IsPositiveNumber(numberString);
            }
            else
            {
                return CalculationAndValidationMessages.IsNotPositiveNumber(originalNumberString, numberString);
            }
        }

        internal static string TestIfNotZeroOrOneAndGetInfo(string numberString, out bool isNotZeroOrOne)
        {
            isNotZeroOrOne = PrimeValidationCalc.IsNotZeroOrOne(numberString);

            if (isNotZeroOrOne)
            {
                return CalculationAndValidationMessages.IsNotZeroOrOne(numberString);
            }
            else
            {
                return CalculationAndValidationMessages.IsZeroOrOne(numberString);
            }
        }

        internal static string TestIfMaybePrimeAndGetInfo(string numberString, out bool continueTesting)
        {
            continueTesting = PrimeValidationCalc.IsMaybePrime(numberString);

            if (continueTesting)
            {
                return CalculationAndValidationMessages.IsPossiblePrime(numberString);
            }
            else
            {
                return CalculationAndValidationMessages.IsNotPrimeAndEndsWith(numberString, numberString.LastCharacter());
            }
        }

        internal static string TestIfPrimeAndGetInfo(string numberString)
        {
            var isPrime = PrimeValidationCalc.IsPrimeOrIsNotPrimeAndGetDividedBy(numberString, out string divisibleBy);

            if (isPrime)
            {
                return CalculationAndValidationMessages.IsPrime(numberString);
            }
            else
            {
                return CalculationAndValidationMessages.IsNotPrimeIsDivisibleBy(numberString, divisibleBy.ToString());
            }
        }
    }
}
