﻿using System;
using System.Text;

namespace Day3.Sample.App
{
    public class ConsecutiveLetters
    {

        public static void Run()
        {
            var rows = int.Parse(Console.ReadLine().Trim());
            if ((rows < 1) || (rows > 10))
            {
                return;
            }
            var dataArray = new string[rows];

            for (var iCtr = 0; iCtr < rows; iCtr++)
            {
                var inputData = Console.ReadLine().Trim();
                if (inputData.Length < 1 || inputData.Length > 30)
                {
                    continue;
                }
                dataArray[iCtr] = inputData;
            }

            foreach (var data in dataArray)
            {
                var letter = data[0];
                var outputString = new StringBuilder(40);
                outputString.Append(letter);
                for (var jCtr = 1; jCtr < data.Length; jCtr++)
                {
                    if (letter == data[jCtr])
                    {
                        continue;
                    }
                    letter = data[jCtr];
                    outputString.Append(letter);
                }
                Console.WriteLine(outputString.ToString());
            }

        }
    }
}
