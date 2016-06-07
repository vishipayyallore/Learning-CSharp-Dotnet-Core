using Variables.Basics;
using System;
using static System.Console;

namespace Variables.Basics.App
{

    public class MainCls
    {
        public static void Main(string[] args)
        {
            var color = args.Length > 0 ? args[0] : "Cyan";
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);

            var person1 = new Person();
            WriteLine(person1);

            var fizzBuzz = new FizzBuzz(20);
            WriteLine(fizzBuzz.GetFizzBuzz());

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }

}
