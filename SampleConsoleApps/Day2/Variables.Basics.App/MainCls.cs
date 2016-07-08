using System;
using static System.Console;

namespace Variables.Basics.App
{

    public class MainCls
    {
        #region Variables.
        private const string HeaderDoubleDash = "======================================================================================================";
        private const string HeaderSingleDash = "------------------------------------------------------------------------------------------------------";
        #endregion

        public static void Main(string[] args)
        {
            var color = args.Length > 0 ? args[0] : "Cyan";
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);

            const int startValue = 7;
            const int breakAt = 7;
            const int endValue = 67;

            var fizzBuzz = new FizzBuzz(endValue: endValue, breakAt: breakAt, startValue: startValue);
            DisplayOutput($"\tFizz Buzz display from {startValue} to {endValue} ", fizzBuzz.GetFizzBuzz());

            var person1 = new Person();
            WriteLine(person1);

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }

        #region Private Methods.

        private static void DisplayOutput(string titile, string outputData)
        {
            WriteLine(HeaderDoubleDash);
            WriteLine(titile);
            WriteLine(HeaderSingleDash);
            WriteLine(outputData);
            WriteLine(HeaderDoubleDash);
        }
        #endregion

    }

}
