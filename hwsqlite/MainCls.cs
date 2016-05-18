using System;
using static System.Console;

namespace ConsoleApplication
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            
            WriteLine("Hello World!");
            
            WriteLine("\nPress any key ...");
            ReadLine();
        }
    }
}
