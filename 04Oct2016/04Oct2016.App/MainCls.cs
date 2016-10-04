using _04Oct2016.Lib;
using static System.Console;

namespace _04Oct2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;

            AboutNumbers.DisplayAccuracy();

            AboutNumbers.DisplayMinAndMax();

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
