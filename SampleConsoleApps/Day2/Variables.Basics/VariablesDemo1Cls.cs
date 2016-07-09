using System.Text;
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
        private const char Letter = 'S';
        private const bool IsHappy = true;
        #endregion

        #region Methods
        public string GetDetails()
        {
            var countryDetails = new StringBuilder(1024);
            countryDetails.Append($"The Population of UK is {Population:N0}\n");
            countryDetails.Append($"{Weight} Kgs of {Fruit} costs {Price:C}\n");
            countryDetails.Append($"Your favorite character is {Letter}; your life is Happy and you are a {IsHappy} person.");
            return countryDetails.ToString();
        }
        #endregion
    }

}
