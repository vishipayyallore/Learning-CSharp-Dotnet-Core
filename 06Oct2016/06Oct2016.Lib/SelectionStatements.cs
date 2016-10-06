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

            Generate_RandomNumer:
            var number = (new Random()).Next(1, 10);
            WriteLine($"My random number is {number}");

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
        #endregion
    }
}
