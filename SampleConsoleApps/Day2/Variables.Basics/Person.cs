using System.Text;
using static System.Console;

namespace Variables.Basics
{

    public class Person
    {
        #region Variables.
        private const int Population = 66000000;
        private const double Weight = 68.88;
        private const decimal MonthlySalary = 4.99M;
        private const string Name = "Shiva Sai";
        private const char Gender = 'M';
        private const bool IsMarried = true;
        private const char NewLine = '\n';

        private const string HeaderDoubleDash = "===================================================";
        private const string HeaderSingleDash = "---------------------------------------------------";
        #endregion

        public Person()
        {
        }

        #region Methods
        public override string ToString()
        {
            var personDetails = new StringBuilder(1024);
            personDetails.Append(HeaderDoubleDash);
            personDetails.Append(NewLine);
            personDetails.Append("Information:");
            personDetails.Append(NewLine);
            personDetails.Append(HeaderSingleDash);
            personDetails.Append(NewLine);
            personDetails.Append($"The Population of UK is {Population:N0}");
            personDetails.Append(NewLine);
            //WriteLine($"{Weight} Kgs of {Fruit} costs {Price:C}");
            //WriteLine($"Your favorite character is {_letter}; your life is Happy and you are a {_isHappy} person.");
            personDetails.Append(HeaderDoubleDash);

            return personDetails.ToString();
        }
        #endregion
    }


}
