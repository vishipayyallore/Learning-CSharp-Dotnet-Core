using System;
using System.Linq;

namespace Day3.Sample.App
{
    public class CallingNIdealOrder
    {
        public static void Run()
        {
            Console.WriteLine("Enter the number of Elements:");
            var numberOfElements = int.Parse(Console.ReadLine().Trim());
            var lastIndex = numberOfElements - 1;
            var count = 0;

            Console.WriteLine("Enter Elements for Calling Order:");
            var arrayValues = Console.ReadLine().Trim().Split(' ');
            var callingOrder = arrayValues.Select(int.Parse).ToArray();
            Console.WriteLine("Enter Elements for Ideal Order:");
            arrayValues = Console.ReadLine().Trim().Split(' ');
            var idealOrder = arrayValues.Select(int.Parse).ToArray();


            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                for (var jCtr = iCtr; jCtr < numberOfElements; jCtr++)
                {
                    if (idealOrder[iCtr] != callingOrder[iCtr])
                    {
                        var temp = callingOrder[iCtr];
                        Array.Copy(callingOrder, iCtr + 1, callingOrder, iCtr, callingOrder.Length - (iCtr + 1));
                        callingOrder[lastIndex] = temp;
                        count++;
                    }
                    else
                    {
                        count++;
                        break;
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine($"{count}");

            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                Console.WriteLine($" {idealOrder[iCtr]} --- {callingOrder[iCtr]}");
            }
        }
    }

}
