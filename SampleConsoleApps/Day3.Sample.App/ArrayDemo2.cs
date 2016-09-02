using System;
using System.Collections.Generic;

namespace Day3.Sample.App
{

    public static class ArrayDemo2
    {

        public static void Run()
        {
            Console.WriteLine("Enter the number of Repetations:");
            var numberOfArray = Console.ReadLine().Trim();
            var rows = int.Parse(numberOfArray);
            var count = new Dictionary<string, int>();

            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                Console.WriteLine("Enter the number of Elements:");
                var numberOfElements = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the Values for Array:");
                var arrayValues = Console.ReadLine().Trim().Split(' ');
            }
        }

    }

}
