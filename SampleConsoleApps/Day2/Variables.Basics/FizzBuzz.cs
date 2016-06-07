using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this._endValue = endValue;
        }

        public string GetFizzBuzz()
        {
            var outputBuilder = new StringBuilder(250);
            for (var iCtr = 1; iCtr <= _endValue; iCtr++)
            {
                outputBuilder.Append($"{CheckDivisibility(iCtr)}");
            }
            return outputBuilder.ToString();
        }

        private static dynamic CheckDivisibility(int number)
        {
            dynamic output = string.Format("{0}{1}", IsDivisible(number, 3), IsDivisible(number, 5));
            //output = (output == string.Empty) ? number : output;
            output = string.Format("{0}{1}", ((output == string.Empty) ? number : output), ((number%10 == 0) ? _newLine : _tab));
            return output;
        }

        private static string IsDivisible(int number, int divider)
        {
            return string.Format("{0}", (number % divider == 0) ? Values[divider] : string.Empty); ;
        }

    }

}
