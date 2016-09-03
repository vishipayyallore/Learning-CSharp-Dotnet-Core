using System;
using System.Linq;

namespace Day3.Sample.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of Elements:");
            var numberOfElements = int.Parse(Console.ReadLine().Trim());
            var callingOrder = new int[numberOfElements];
            var idealOrder = new int[numberOfElements];
            var lastIndex = numberOfElements - 1;

            Console.WriteLine("Enter Elements for Calling Order:");
            var arrayValues = Console.ReadLine().Trim().Split(' ');
            callingOrder = arrayValues.Select(int.Parse).ToArray();
            Console.WriteLine("Enter Elements for Ideal Order:");
            arrayValues = null;
            arrayValues = Console.ReadLine().Trim().Split(' ');
            idealOrder = arrayValues.Select(int.Parse).ToArray();

            
            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                for (var jCtr = iCtr; jCtr < numberOfElements; jCtr++)
                {
                    if (idealOrder[iCtr] != callingOrder[iCtr])
                    {
                        var temp = callingOrder[lastIndex];
                        Array.Copy(callingOrder, 0, callingOrder, 1, callingOrder.Length - 1);
                        callingOrder[lastIndex] = temp;
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine($" {idealOrder[iCtr]} --- {callingOrder[jCtr]}");
                }
                Console.WriteLine();
            }

            SingleDArrayReverse.Run();

            ArrayDemo2.Run();

            ArrayDemo1.Run();

            int startValue = int.Parse(args[0]);
            int endValue = 10;

            if (args.Length == 2)
            {
                endValue = Int32.Parse(args[1]);
            }

            endValue -= startValue - 1;
            for (int iCtr = 0; iCtr < endValue; iCtr++)
            {
                var toPrint = (startValue%3 == 0) ? "Fizz" : "";
                toPrint += (startValue % 5 == 0) ? "Buzz" : "";
                toPrint = ((startValue%3 != 0) && (startValue%5 != 0)) ? startValue.ToString() : toPrint;
                Console.WriteLine(toPrint);
                startValue++;
            }


            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }
}
