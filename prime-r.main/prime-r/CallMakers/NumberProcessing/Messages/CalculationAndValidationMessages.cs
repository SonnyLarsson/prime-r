using System;

namespace prime_r.CallMakers.NumberProcessing.Messages
{
    //This class contains and delivers all the information texts.
    static internal class CalculationAndValidationMessages
    {
        private const string isPrime = " is a prime";
        private const string notPrime = " is not a prime, because the number ";

        private const string endsWith = "ends with the digit ";
        private const string divisibleBy = "is divisible by ";

        private const string end = ". \n\n";
        private const string happyEnd = "! \n\n";

        private const string possiblePrime = " might be a prime. \n\nStarting calculations";

        private const string isNotValidInteger = " is not a valid integer";
        private const string isValidInteger = " is a valid integer";

        private const string isNotPositiveNumber = " is not a positive number, however its positive counterpart ";
        private const string isPositiveNumber = " is a positive number";
        private const string usingNumber = " using ";

        private const string isZeroOrOne = " is not a prime number, because a prime has be bigger than 1";
        private const string isNotZeroOrOne = " is not 0 or 1";

        private const string invalidNumberFormat = "Invalid number format?";

        internal static string IsNotPrimeAndEndsWith(string number, string digit)
        {
            return String.Concat(number, notPrime, endsWith, digit, end);
        }

        internal static string IsPossiblePrime(string number)
        {
            return String.Concat(number, possiblePrime, usingNumber, number, end);
        }

        internal static string IsNotPrimeIsDivisibleBy(string number, string digit)
        {
            return String.Concat(number, notPrime, divisibleBy, digit, end);
        }

        internal static string IsPrime(string number)
        {
            return String.Concat(number, isPrime, happyEnd);
        }

        internal static string IsNotValidInteger(string number)
        {
            return String.Concat(number, isNotValidInteger, end);
        }

        internal static string IsValidInteger(string number)
        {
            return String.Concat(number, isValidInteger, happyEnd);
        }

        internal static string IsNotPositiveNumber(string number, string positiveNumber)
        {
            return String.Concat(number, isNotPositiveNumber, positiveNumber, possiblePrime, usingNumber, positiveNumber, end);
        }

        internal static string IsPositiveNumber(string number)
        {
            return String.Concat(number, isPositiveNumber, happyEnd);
        }

        internal static string IsNotZeroOrOne(string number)
        {
            return String.Concat(number, isNotZeroOrOne, happyEnd);
        }

        internal static string IsZeroOrOne(string number)
        {
            return String.Concat(number, isZeroOrOne, end);
        }

        internal static string InvalidFormat()
        {
            return invalidNumberFormat;
        }
    }
}
