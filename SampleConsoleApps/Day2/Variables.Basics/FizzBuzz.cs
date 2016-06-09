using System.Collections.Generic;
using System.Text;

namespace Variables.Basics
{

    public class FizzBuzz
    {
        #region Variables.
        private readonly int _startValue;
        private readonly int _endValue;
        private readonly int _breakAt;
        private readonly Dictionary<int, string> _values;
        private const char TabValue = '\t';
        private const char NewLineValue = '\n';
        private const int ThreeValue = 3;
        private const int FiveValue = 5;
        #endregion

        public FizzBuzz(int startValue = 1, int endValue = 10, int breakAt = 5)
        {
            _startValue = startValue;
            _endValue = endValue;
            _breakAt = breakAt;
            _values = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } };
        }

        #region Methods.
        public string GetFizzBuzz()
        {
            var outputBuilder = new StringBuilder(250);
            for (var iCtr = _startValue; iCtr <= _endValue; iCtr++)
            {
                outputBuilder.Append($"{CheckDivisibility(iCtr)}");
            }
            return outputBuilder.ToString();
        }
        #endregion

        #region Private Methods.
        private dynamic CheckDivisibility(int number)
        {
            dynamic output = string.Format("{0}{1}", IsDivisible(number, ThreeValue), IsDivisible(number, FiveValue));
            return string.Format("{0,8}{1}", ((output == string.Empty) ? number : output), ((number% _breakAt == 0) ? NewLineValue : TabValue));
        }

        private string IsDivisible(int number, int divider)
        {
            return string.Format("{0}", (number % divider == 0) ? _values[divider] : string.Empty);
        }
        #endregion

    }

}
