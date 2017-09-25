using Basic.Programs;
using System;
using static System.Console;

namespace Programs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;

            var currentObject = new LifeUniverseEverything();
            currentObject.Run();

            WriteLine("Hello World!");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
