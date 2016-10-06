using System;
using System.Globalization;
using static System.Console;
using static System.Convert;

namespace _06Oct2016.Lib
{
    public class CastingNParsing
    {
        #region Methods

        public CastingNParsing DisplayParsing()
        {
            var age = int.Parse("27");
            var birthday = DateTime.Parse("4 July 1980");
            int count;

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            Write("How many eggs are there? ");
            var input = Console.ReadLine();
            WriteLine(int.TryParse(input, out count) ? $"There are {count} eggs." : "I could not parse the input.");

            return this;
        }

        public CastingNParsing DisplayCastingConverting()
        {
            const int a = 10;
            const double b = a;
            const double c = 9.8;
            const int d = (int)c;
            long e = 10;
            var f = (int)e;
            const double i = 9.49;
            const double j = 9.5;
            const double k = 10.49;
            const double l = 10.5;
            var g = 9.8;
            var h = ToInt32(g);
            const int number = 12;
            const bool boolean = true;
            var now = DateTime.Now;
            var me = new object();

            //Implicit Conversions
            WriteLine(b);
            WriteLine(d);
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            WriteLine($"g is {g} and h is {h}");

            //Using Convert instead of Casting [Convert will round of the value]
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"i is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"j is {l}, ToInt(l) is {ToInt32(l)}");

            //ToString Method Usage
            WriteLine(number.ToString());
            WriteLine(boolean.ToString());
            WriteLine(now.ToString(CultureInfo.InvariantCulture));
            WriteLine(me.ToString());

            return this;
        }
        #endregion
    }
}
