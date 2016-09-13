using System;

namespace SortingSamples
{

    
    public class MainCls
    {

        public static void Main(string[] args)
        {

            //Selection Sort
            SelectionSort.Run();

            //Bubble Sort
            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
