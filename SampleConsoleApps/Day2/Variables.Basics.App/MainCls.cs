using Variables.Basics;
using static System.Console;

namespace Variables.Basics.App
{

    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;
            var variablesDemo1 = new VariablesDemo1Cls();
            variablesDemo1.DisplayDetails();

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }

}
