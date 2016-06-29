using System;
using static System.Console;

namespace hwcliconsole
{
    public class HelloWorldCli
    {
        public static void Main(string[] args)
        {
            var user = new Person { Name = "Shiva Sai", Age = 26 };
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("User Details ....");
            WriteLine($"Name: {user.Name}\nAge: {user.Age}");
            
            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
