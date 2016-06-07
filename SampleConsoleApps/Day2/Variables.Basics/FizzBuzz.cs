using System;
using System.Collections.Generic;
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
            dynamic output = "";
            if (number%3 == 0)
            {
                output = string.Format("{0}", (number%3 == 0) ? Values[3] : string.Empty);
            }
            output = number % 5 == 0 ? string.Format("{0}{1}", output, (number % 5 == 0) ? Values[5] : string.Empty) : number;
            output = string.Format("{0}{1}", output, ((number%10 == 0) ? _newLine : _tab));
            return output;
        }

    }

}
