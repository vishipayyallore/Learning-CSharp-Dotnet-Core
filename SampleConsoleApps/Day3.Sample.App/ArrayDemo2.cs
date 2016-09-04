using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3.Sample.App
{
     
    public static class ArrayDemo2
    {

        public static void Run()
        {
            Console.WriteLine("Enter the number of Repetations:");
            var numberOfArray = Console.ReadLine().Trim();
            var rows = int.Parse(numberOfArray);
            var sum = 0;
            var count = new Dictionary<int, int>();

            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                Console.WriteLine("Enter the number of Elements:");
                var numberOfElements = int.Parse(Console.ReadLine().Trim());
                sum += numberOfElements;
                Console.WriteLine("Enter the Values for Array:");
                var arrayValues = Console.ReadLine().Trim().Split(' ');
                var dataArray = arrayValues.Select(int.Parse).ToArray();
                count[iCtr] = dataArray.Where(e => e > 0).Sum();
            }

            foreach (var keyValuePair in count)
            {
                Console.WriteLine($"Number Sum = {sum} :: Array Sum = {keyValuePair.Value}");
            }
            
        }

    }

}
