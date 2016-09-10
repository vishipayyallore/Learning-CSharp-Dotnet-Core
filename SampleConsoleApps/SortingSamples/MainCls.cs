using System;
using System.Linq;

namespace SortingSamples
{

    public class MainCls
    {

        public static void Main(string[] args)
        {

            //Selection Sort. {76 45 92 67 89 12 99 | 7 4 5 2 | 4 83 9 6 34 45}
            var arrayData = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (var iCtr = 1; iCtr < arrayData.Length - 1; iCtr++)
            {
                var jCtr = iCtr;
                while (jCtr > 0)
                {
                    if (arrayData[jCtr - 1] > arrayData[jCtr])
                    {
                        var temp = arrayData[jCtr];
                        arrayData[jCtr] = arrayData[jCtr - 1];
                        arrayData[jCtr - 1] = temp;
                        jCtr--;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine($"Pass {iCtr + 1}: {string.Join(" ", arrayData)}");
            }
            Console.WriteLine($"\nBubble Sorted: {string.Join(" ", arrayData)}\n");

            //Selection Sort
            SelectionSort.Run();

            //Bubble Sort
            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
