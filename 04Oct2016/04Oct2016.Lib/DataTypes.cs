
using static System.Console;

namespace _04Oct2016.Lib
{
    public class DataTypes
    {

        #region Variables.
        private const string LineData = "--------------------------------------------------------------------------";
        private const string TitleData = "Type    Byte(s) of memory               Min                            Max";
        #endregion

        #region Methods.
        public DataTypes DisplayData()
        {
            const int population = 66000000;
            const double weight = 1.88;
            const decimal price = 4.99M;
            const string fruitName = "Apples";
            const char gender = 'M';
            const bool isMarried = true;

            WriteLine($"The Population of a State is {population:N0}");
            WriteLine($"{weight} Kg of {fruitName} costs {price:C}.");
            WriteLine($"You are of {gender} Gender and your martial status is {isMarried}");

            return this;
        }

        public DataTypes DisplayData1()
        {
            var cannotBeNull = 4;
            cannotBeNull = default(int);
            int? couldBeNull = null;
            var output = couldBeNull.GetValueOrDefault();
            WriteLine($"Non-Null Variable: {cannotBeNull} \t Nullable Variable: {couldBeNull} and Output: {output}");
            couldBeNull = 4;
            output = couldBeNull.GetValueOrDefault();
            WriteLine($"Non-Null Variable: {cannotBeNull} \t Nullable Variable: {couldBeNull} and Output: {output}");

            return this;
        }

        public DataTypes DisplayData2()
        {
            var names = new[] { "George" , "Jerry", "Manish", "Sajad" };
            Write($"With ForEach Loop.\t");
            foreach (var name in names)
            {
                Write($"{name} ");
            }
            WriteLine($"\nWithout ForEach Loop.   {string.Join(" ", names)}");

            return this;
        }

        public DataTypes DisplayData3()
        {
            Write($"Enter your Name:");
            var userName = ReadLine().Trim();
            Write($"Enter your Age:");
            var userAge = int.Parse(ReadLine().Trim());
            WriteLine($"Hello {userName}, you look good for {userAge}.");

            return this;
        }

        public DataTypes DisplayData4()
        {
            WriteLine(LineData);
            WriteLine(TitleData);
            WriteLine(LineData);
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine(LineData);

            return this;
        }
        #endregion
    }
}
