using System;
using System.Threading.Tasks;
using static System.Console;

namespace _06Oct2016.Lib
{
    public class SelectionStatements
    {
        #region Methods.
        /// <summary>
        /// Key take away is GoTo can Navigate to 1. A Lable and 2. Another Case statement.
        /// </summary>
        /// <returns></returns>
        public SelectionStatements DisplaySwitchStatements()
        {
            WriteLine("While Statement Demo -----");

            Generate_RandomNumer:
                var number = (new Random()).Next(1, 10);
                WriteLine($"Random number is {number}");

            switch (number)
            {
                case 1: 
                    WriteLine("One");
                    break; 
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    Task.Delay(500);
                    goto Generate_RandomNumer;
                default:
                    WriteLine($"Just {number}");
                    break;
            }
            return this;
        }

        public SelectionStatements DisplayWhile_DoWhileStatements()
        {
            var iCtr = 0;
            WriteLine("While Statement Demo -----");
            while (iCtr < 10)
            {
                WriteLine(iCtr);
                iCtr++;
            }

            WriteLine("Do While Statement Demo -----");
            iCtr = 0;
            do
            {
                WriteLine(iCtr);
                iCtr++;
            } while (iCtr < 10);
            return this;
        }

        public SelectionStatements DisplayFor_ForEachStatements()
        {
            WriteLine("For Loop Demo -----");
            for (var iCtr = 0; iCtr < 10; iCtr++)
            {
                WriteLine(iCtr);
            }

            WriteLine("ForEach Loop Demo -----");
            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (var name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
            return this;
        }
        #endregion
    }
}
