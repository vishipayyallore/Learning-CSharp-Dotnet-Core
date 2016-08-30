using System;

namespace Day3.Sample.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            int startValue = Int32.Parse(args[0]);
            int endValue = 10;

            if (args.Length == 2)
            {
                endValue = Int32.Parse(args[1]);
            }

            Console.WriteLine("\n\nPress any key ...");
            Console.ReadKey();
        }
    }
}
