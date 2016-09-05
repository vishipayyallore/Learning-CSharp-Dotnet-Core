using System;
using System.Linq;

namespace Day3.Sample.App
{
    public class FizzBuzz
    {
        public static void Run()
        {
            var numberOfElements = int.Parse(Console.ReadLine().Trim());
            if ((numberOfElements < 1) || (numberOfElements > 10))
            {
                return;
            }
            var arrayValues = Console.ReadLine().Trim().Split(' ');
            var arrayEndValues = arrayValues.Select(int.Parse).ToArray();


            for (var jCtr = 0; jCtr < numberOfElements; jCtr++)
            {
                var startValue = 1;
                var endValue = arrayEndValues[jCtr];

                endValue -= startValue - 1;
                for (var iCtr = 0; iCtr < endValue; iCtr++)
                {
                    var toPrint = startValue % 3 == 0 ? "Fizz" : "";
                    toPrint += startValue % 5 == 0 ? "Buzz" : "";
                    toPrint = (startValue % 3 != 0) && (startValue % 5 != 0) ? startValue.ToString() : toPrint;
                    Console.WriteLine(toPrint);
                    startValue++;
                }
            }
        }

    }
}
