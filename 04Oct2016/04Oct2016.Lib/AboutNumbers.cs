
using static System.Console;

namespace _04Oct2016.Lib
{
    public class AboutNumbers
    {
        public static void DisplayMinAndMax()
        {
            WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
        }

        public static void DisplayAccuracy()
        {
            const double doubleValue1 = 0.1;
            const double doubleValue2 = 0.2;
            const double doubleSum = 0.3;
            const string outputForDouble = ((doubleValue1 + doubleValue2) == doubleSum) ? " equals " : " does NOT equal ";
            WriteLine($"Double Data Type: {doubleValue1} + {doubleValue2} {outputForDouble} {doubleSum}");

            const decimal decimalValue1 = 0.1M; // M indicates a decimal literal value
            const decimal decimalValue2 = 0.2M;
            const decimal decimalSum = 0.3M;
            const string outputForDecimal = ((decimalValue1 + decimalValue2) == decimalSum) ? " equals " : " does NOT equal ";
            WriteLine($"Decimal Data Type: {decimalValue1} + {decimalValue2} {outputForDecimal} {decimalSum}");
        }
    }
}
