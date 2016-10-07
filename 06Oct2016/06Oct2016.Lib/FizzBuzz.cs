using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace _06Oct2016.Lib
{
    public class FizzBuzz
    {
        #region Methods.
        public static void Run()
        {
            Write("Enter start Value {1 and 255} : ");
            var startValue = int.Parse(ReadLine().Trim());
            Write("Enter End Value {1 and 255} : ");
            var endValue = int.Parse(ReadLine().Trim());

            for (; startValue <= endValue; startValue++)
            {
                var toPrint = startValue % 3 == 0 ? "Fizz" : string.Empty;
                toPrint += startValue % 5 == 0 ? "Buzz" : string.Empty;
                toPrint = (startValue % 3 != 0) && (startValue % 5 != 0) ? startValue.ToString() : toPrint;
                WriteLine(toPrint);
            }
        }
        #endregion
    }
}
