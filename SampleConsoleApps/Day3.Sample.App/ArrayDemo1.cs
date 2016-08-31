using System;
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
            var _count = new Dictionary<string, int>();

            var _number = new int[_rows, _columns];
            for (var iCtr = 0; iCtr < _rows; iCtr++)
            {
                var _data = Console.ReadLine().Trim().Split(' ');
                for (var jCtr = 0; jCtr < _columns; jCtr++)
                {
                    _number[iCtr, jCtr] = int.Parse(_data[jCtr]);
                }
            }

            for (var iCtr = 0; iCtr < _rows - 1; iCtr++)
            {
                for (var jCtr = 0; jCtr < _columns; jCtr++)
                {
                    if (_number[iCtr, jCtr] != 1) continue;
                    if (_number[iCtr, jCtr + 1] == 1)
                    {
                        _count[string.Format("{0}{1}", iCtr, jCtr + 1)] = 1;
                    }
                    if (_number[iCtr + 1, jCtr + 1] == 1)
                    {
                        _count[string.Format("{0}{1}", iCtr + 1, jCtr + 1)] = 1;
                    }
                    if (_number[iCtr + 1, jCtr] == 1)
                    {
                        _count[string.Format("{0}{1}", iCtr + 1, jCtr)] = 1;
                    }
                }
            }

            Console.WriteLine($"Count: {_count.Count + 1}");
        }

    }

}
