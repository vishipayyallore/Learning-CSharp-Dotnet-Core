
using static System.Console;

namespace _04Oct2016.Lib
{
    public class DataTypes
    {
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
        #endregion
    }
}
