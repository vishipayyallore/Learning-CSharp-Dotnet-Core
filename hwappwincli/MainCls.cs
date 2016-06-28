using System;
using static System.Console;

namespace hwappwincli
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("Hello World! \n From Windows .Net CLI.");

            WriteLine("\n\nPress any key ....");
            ReadLine();
        }
    }

}
