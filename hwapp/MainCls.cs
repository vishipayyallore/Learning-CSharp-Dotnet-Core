using System;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string userName = "Lord Krishna";
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine($"{userName}\nPlease shower your grace!");
            WriteLine("Hello Satya! and other folks at JH");

            WriteLine("\n\nPress any key ....");
            ReadLine();
        }
    }
}
