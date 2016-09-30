
using static System.Console;

namespace _30Sep2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;
            const string output = "Hello .Net Core!!!";

            WriteLine($"{output}");

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
