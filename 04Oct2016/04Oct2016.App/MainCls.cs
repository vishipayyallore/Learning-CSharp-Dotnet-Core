using _04Oct2016.Lib;
using static System.Console;

namespace _04Oct2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;

            //"George Mathew"  "Jerry Thomas" "Manish Agarwal" "Sajad Ali"
            WriteLine($"There are {args.Length} arguments.");
            WriteLine($"{string.Join(" ", args)}");

            new DataTypes().DisplayData()
                    .DisplayData1()
                    .DisplayData2()
                    .DisplayData3();

            SpecialDataTypes.DisplayDynamicType();

            SpecialDataTypes.DisplayObjectType();

            AboutNumbers.DisplayAccuracy();

            AboutNumbers.DisplayMinAndMax();

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
