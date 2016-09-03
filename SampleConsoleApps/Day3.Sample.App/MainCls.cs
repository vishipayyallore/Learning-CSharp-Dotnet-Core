using System;

namespace Day3.Sample.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of Elements:");
            var numberOfElements = int.Parse(Console.ReadLine().Trim());
            var arrayElements = new int[numberOfElements];
            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                Console.WriteLine($"Enter the {iCtr+1} Element:");
                arrayElements[iCtr] = int.Parse(Console.ReadLine().Trim());
            }

            for (var iCtr = numberOfElements-1; iCtr >= 0; iCtr--)
            {
                Console.WriteLine($"{iCtr + 1} Element: {arrayElements[iCtr]}");
            }

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
