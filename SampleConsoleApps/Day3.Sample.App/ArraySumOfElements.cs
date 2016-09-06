using System;
using System.Linq;

namespace Day3.Sample.App
{

    public class ArraySumOfElements
    {

        public static void Run()
        {
            var rows = int.Parse(Console.ReadLine().Trim());
            if ((rows < 1) || (rows > 10))
            {
                return;
            }

            for (; rows > 0; rows--)
            {
                var arrayData = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var rangeArray = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                var sum = 0;
                for (var iCtr = rangeArray[0]; iCtr <= rangeArray[1]; iCtr++)
                {
                    sum += arrayData[iCtr];
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }

    }

}
