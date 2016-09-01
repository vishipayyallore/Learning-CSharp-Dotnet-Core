﻿using System;
using System.Collections.Generic;

namespace Day3.Sample.App
{

    public static class ArrayDemo1
    {

        public static void Run()
        {
            var inputRows = Console.ReadLine().Trim();
            var columns = Console.ReadLine().Trim();
            var rows = int.Parse(inputRows);
            var _columns = int.Parse(columns);
            var count = new Dictionary<string, int>();

            var numbers = new int[rows, _columns];
            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var data = Console.ReadLine().Trim().Split(' ');
                for (var jCtr = 0; jCtr < _columns; jCtr++)
                {
                    numbers[iCtr, jCtr] = int.Parse(data[jCtr]);
                }
            }

            for (var iCtr = 0; iCtr < rows - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < _columns; jCtr++)
                {
                    if ((numbers[iCtr, jCtr] != 1) || (jCtr+1 == _columns)) continue;
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

    }

}
