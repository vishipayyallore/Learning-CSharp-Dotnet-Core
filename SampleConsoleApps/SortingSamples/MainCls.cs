using System;
using System.Linq;

namespace SortingSamples
{

    public class MainCls
    {

        public static void Main(string[] args)
        {

            var arrayData = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            BubbleSort.Run();

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }

    }

}
