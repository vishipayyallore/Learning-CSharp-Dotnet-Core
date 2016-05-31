using static System.Console;

namespace Variables.Basics
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class VariablesDemo1Cls
    {

        #region Variables.

        private const int Population = 66000000;
        private const double Weight = 1.88;
        private const decimal Price = 4.99M;
        private const string Fruit = "Apples";
        private char _letter = 'S';
        private bool _isHappy = true;

        private const string HeaderDoubleDash = "===================================================";
        private const string HeaderSingleDash = "---------------------------------------------------";
        #endregion

        public VariablesDemo1Cls()
        {
        }

        #region Methods
        public void DisplayDetails()
        {
            WriteLine(HeaderDoubleDash);
            WriteLine("Information:");
            WriteLine(HeaderSingleDash);
            WriteLine($"The Population of UK is {Population:N0}");
            WriteLine($"{Weight} Kgs of {Fruit} costs {Price:C}");
            WriteLine($"Your favorite character is {_letter}; your life is Happy and you are a {_isHappy} person.");
            WriteLine(HeaderDoubleDash);
        }
        #endregion
    }

}
