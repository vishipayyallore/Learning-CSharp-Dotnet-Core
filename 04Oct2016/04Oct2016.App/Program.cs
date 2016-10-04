
using static System.Console;

namespace _04Oct2016.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;

            WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
