using System;
using static System.Console;

namespace ConsoleApplication
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            const string userName = "Lord Krishna";
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine($"{userName}\nPlease shower your grace!");
            WriteLine("Hello Satya! and other folks at JH. \nWe do Automated Testing too.");
            
            WriteLine("\n\nPress any key ....");
            ReadLine();
        }
    }
}
