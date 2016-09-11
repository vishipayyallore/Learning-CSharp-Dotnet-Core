using System;
using System.Linq;

namespace SortingSamples
{
    public class SelectionSort
    {
        public static void Run()
        {
            //Selection Sort. {76 45 92 67 89 12 99 | 7 4 5 2 | 4 83 9 6 34 45}
            var arrayData = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            for (var iCtr = 0; iCtr < arrayData.Length - 1; iCtr++)
            {
                var itemIndex = iCtr;
                for (var jCtr = iCtr; jCtr < arrayData.Length; jCtr++)
                {
                    if (arrayData[jCtr] < arrayData[itemIndex])
                    {
                        itemIndex = jCtr;
                    }
                }
                var temp = arrayData[iCtr];
                arrayData[iCtr] = arrayData[itemIndex];
                arrayData[itemIndex] = temp;
                Console.WriteLine($"Pass {iCtr + 1}: {string.Join(" ", arrayData)}");
            }
            Console.WriteLine($"Selection Sorted: {string.Join(" ", arrayData)}\n");
        }
    }
}
