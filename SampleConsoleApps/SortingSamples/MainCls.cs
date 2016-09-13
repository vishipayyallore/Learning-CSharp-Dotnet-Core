using System;

namespace SortingSamples
{

    
    public class MainCls
    {

        public static void Main(string[] args)
        {
            //Sample Data: {76 45 92 67 89 12 99 | 7 4 5 2 | 34 4 83 9 6 45}

            //Insertion Sort.
            InsertionSort.Run();

            //Selection Sort
            SelectionSort.Run();

            //Bubble Sort
            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
