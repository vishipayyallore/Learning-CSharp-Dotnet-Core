﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day3.Sample.App
{

    public static class ArrayDemo1
    {

        public static void Run()
        {
            var rows = Console.ReadLine().Trim();
            var columns = Console.ReadLine().Trim();
            var _rows = int.Parse(rows);
            var _columns = int.Parse(columns);
            var count = new Dictionary<string, int>();

            var numbers = new int[_rows, _columns];
            for (var iCtr = 0; iCtr < _rows; iCtr++)
            {
                var data = Console.ReadLine().Trim().Split(' ');
                for (var jCtr = 0; jCtr < _columns; jCtr++)
                {
                    numbers[iCtr, jCtr] = int.Parse(data[jCtr]);
                }
            }

            for (var iCtr = 0; iCtr < _rows - 1; iCtr++)
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
