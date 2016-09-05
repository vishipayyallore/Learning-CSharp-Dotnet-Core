using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3.Sample.App
{

    public static class ArrayDemo1
    {

        public static void Run()
        {
            var inputRows = Console.ReadLine().Trim();
            var inputcolumns = Console.ReadLine().Trim();
            var rows = int.Parse(inputRows);
            var columns = int.Parse(inputcolumns);
            var count = new Dictionary<string, int>();

            var numbers = new int[rows, columns];
            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var data = Console.ReadLine().Trim().Split(' ');
                for (var jCtr = 0; jCtr < columns; jCtr++)
                {
                    numbers[iCtr, jCtr] = int.Parse(data[jCtr]);
                }
            }

            for (var iCtr = 0; iCtr < rows - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < columns; jCtr++)
                {
                    if ((numbers[iCtr, jCtr] != 1) || (jCtr+1 == columns)) continue;
                    if (numbers[iCtr, jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1, jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1, jCtr] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr)] = 1;
                    }
                }
            }

            Console.WriteLine($"Count: {count.Count + 1}");
        }

        public static void Run1()
        {
            var rows = int.Parse(Console.ReadLine().Trim());
            if ((rows < 1) || (rows > 10))
            {
                return;
            }
            var columns = int.Parse(Console.ReadLine().Trim());
            if ((columns < 1) || (columns > 10))
            {
                return;
            }

            var count = new Dictionary<string, int>();

            var numbers = new int[rows, columns];
            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var data = Console.ReadLine().Trim().Split(' ');
                for (var jCtr = 0; jCtr < columns; jCtr++)
                {
                    numbers[iCtr, jCtr] = int.Parse(data[jCtr]);
                }
            }

            for (var iCtr = 0; iCtr < rows - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < columns; jCtr++)
                {
                    if ((numbers[iCtr, jCtr] != 1) || (jCtr + 1 == columns)) continue;
                    if (numbers[iCtr, jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1, jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1, jCtr] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr)] = 1;
                    }
                }
            }

            Console.WriteLine($"{count.Count + 1}");
        }

        public static void Run2()
        {
            var count = new Dictionary<string, int>();
            var rows = int.Parse(Console.ReadLine().Trim());
            var columns = int.Parse(Console.ReadLine().Trim());
            if (((columns < 1) || (columns > 10)) || ((rows < 1) || (rows > 10)))
            {
                return;
            }

            var numbers = new int[rows][];
            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var data = Console.ReadLine().Trim().Split(' ');
                numbers[iCtr] = data.Select(int.Parse).ToArray();
            }

            for (var iCtr = 0; iCtr < rows - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < columns; jCtr++)
                {
                    if ((numbers[iCtr][jCtr] != 1) || (jCtr + 1 == columns)) continue;
                    if (numbers[iCtr][jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1][jCtr + 1] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr + 1)] = 1;
                    }
                    if (numbers[iCtr + 1][jCtr] == 1)
                    {
                        count[string.Format("{0}{1}", iCtr + 1, jCtr)] = 1;
                    }
                }
            }
            Console.WriteLine($"{count.Count + 1}");
        }

    }

}
