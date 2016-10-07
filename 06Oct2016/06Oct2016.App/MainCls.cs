using _06Oct2016.Lib;
using static System.Console;

namespace _06Oct2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;

            FizzBuzz.Run();

            new ExceptionsHandling()
                .DisplayErrorDemo1()
                .DisplayErrorDemo2()
                .DisplayTryCatch()
                .DisplayTryCatchFinally()
                .DisplayUsingDemo();

            new CastingNParsing()
                .DisplayCastingConverting()
                .DisplayParsing();

            new SelectionStatements()
                .DisplaySwitchStatements()
                .DisplayWhile_DoWhileStatements()
                .DisplayFor_ForEachStatements();

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
