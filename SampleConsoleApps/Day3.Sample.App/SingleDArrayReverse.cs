using System;

namespace Day3.Sample.App
{
    public class SingleDArrayReverse
    {
        public static void Run()
        {
            Console.WriteLine("Enter the number of Elements:");
            var numberOfElements = int.Parse(Console.ReadLine().Trim());
            var arrayElements = new int[numberOfElements];
            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                Console.WriteLine($"Enter the {iCtr + 1} Element:");
                arrayElements[iCtr] = int.Parse(Console.ReadLine().Trim());
            }

            for (var iCtr = numberOfElements - 1; iCtr >= 0; iCtr--)
            {
                Console.WriteLine($"{iCtr + 1} Element: {arrayElements[iCtr]}");
            }
        }
    }
}
