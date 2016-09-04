using System;

namespace Day3.Sample.App
{
    public class ReverseString
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
                for (var jCtr = data.Length - 1; jCtr >= 0; jCtr--)
                {
                    Console.Write(data[jCtr]);
                }
                Console.WriteLine();
            }
        }
    }
}
