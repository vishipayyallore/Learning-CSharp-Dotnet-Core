using System;
using System.Linq;

namespace SortingSamples
{

    public class MainCls
    {

        public static void Main(string[] args)
        {

            //Selection Sort. {76 45 92 67 89 12 99 | 7 4 5 2 | 4 83 9 6 34 45}

            //Selection Sort
            SelectionSort.Run();

            //Bubble Sort
            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
