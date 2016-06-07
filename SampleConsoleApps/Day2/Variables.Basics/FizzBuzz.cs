using System.Collections.Generic;
using System.Text;

namespace Variables.Basics
{

    public class FizzBuzz
    {
        #region Variables.
        private readonly int _endValue;
        private static readonly Dictionary<int, string> Values = new Dictionary<int, string>{{3, "Fizz" }, {5, "Buzz"}};
        private static char _tab = '\t';
        private static char _newLine = '\n';
        #endregion

        public FizzBuzz(int endValue)
        {
            _endValue = endValue;
        }

        #region Methods.
        public string GetFizzBuzz()
        {
            var outputBuilder = new StringBuilder(250);
            for (var iCtr = 1; iCtr <= _endValue; iCtr++)
            {
                outputBuilder.Append($"{CheckDivisibility(iCtr)}");
            }
            return outputBuilder.ToString();
        }
        #endregion

        #region Private Methods.
        private static dynamic CheckDivisibility(int number)
        {
            dynamic output = string.Format("{0}{1}", IsDivisible(number, 3), IsDivisible(number, 5));
            return string.Format("{0}{1}", ((output == string.Empty) ? number : output), ((number%5 == 0) ? _newLine : _tab));
        }

        private static string IsDivisible(int number, int divider)
        {
            return string.Format("{0}", (number % divider == 0) ? Values[divider] : string.Empty); ;
        }
        #endregion

    }

}
