using System;
using static System.Console;

namespace hwappwincli
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("Hello World! \nFrom Windows .Net CLI.");

            WriteLine("\n\nPress any key ....");
            ReadLine();
        }
    }

}
