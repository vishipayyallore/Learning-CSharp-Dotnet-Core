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

        public static void Run1()
        {
            var rows = int.Parse(Console.ReadLine().Trim());
            if ((rows < 1) || (rows > 10))
            {
                return;
            }
            var sum = 0;
            var count = new Dictionary<int, long>();

            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var numberOfElements = int.Parse(Console.ReadLine().Trim());
                if ((numberOfElements < 1) || (numberOfElements > 100000))
                {
                    continue;
                }
                sum += numberOfElements;
                var arrayValues = Console.ReadLine().Trim().Split(' ');
                if (arrayValues[0].Trim().Length < 1)
                {
                    continue;
                }


                var dataArray = arrayValues.Select(int.Parse).ToArray();
                var returnValue = dataArray.All(element => (element >= -10000) && (element <= 10000));
                if (!returnValue) continue;
                count[iCtr] = dataArray.Where(e => e > 0).Sum();
            }

            foreach (var keyValuePair in count)
            {
                Console.WriteLine($"{sum} {keyValuePair.Value}");
            }
        }

    }

}
