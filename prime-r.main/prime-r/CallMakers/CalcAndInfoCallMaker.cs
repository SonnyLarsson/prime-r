using prime_r.CallMakers.NumberProcessing;
using prime_r.CallMakers.NumberProcessing.Messages;

namespace prime_r.CallMakers
{
    internal static class CalcAndInfoCallMaker
    {
        //This class handles the function calls that do the calculations and get the result info.
        internal static string DoCalcsAndGetInfo(string numberStringForCalc)
        {
            var infoMessage = "";

            try
            {
                var numberString = numberStringForCalc;

                var notValidInteger = CalculationAndValidation.TestIfValidIntegerAndGetInfo(numberString, out bool continueTesting);

                if (continueTesting)
                {
                    var isNegative = CalculationAndValidation.TestIfPositiveNumberAndGetInfo(ref numberString, out bool isPositive);
                    infoMessage = infoMessage + CalculationAndValidation.TestIfMaybePrimeAndGetInfo(numberString, out continueTesting);

                    if (continueTesting)
                    {
                        var zeroOrOne = CalculationAndValidation.TestIfNotZeroOrOneAndGetInfo(numberString, out continueTesting);

                        if (continueTesting)
                        {
                            if (!isPositive)
                            {
                                infoMessage = isNegative;
                            }

                            infoMessage = infoMessage + CalculationAndValidation.TestIfPrimeAndGetInfo(numberString);
                        }
                        else
                        {
                            var message = zeroOrOne;

                            if (!isPositive)
                            {
                                message = isNegative + message;
                            }

                            infoMessage = message;
                        }
                    }
                }
                else
                {
                    infoMessage = notValidInteger;
                }
            }
            catch
            {
                infoMessage = CalculationAndValidationMessages.InvalidFormat();
            }

            return infoMessage;
        }
    }
}
