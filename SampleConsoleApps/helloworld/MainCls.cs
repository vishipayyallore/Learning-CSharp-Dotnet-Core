using FirstLibrary;
using static System.Console;

namespace helloworld
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;
            var person = new Person { Id = 101, Name = "Shiva Sai", Salary = 102.39M };

            WriteLine("***** Person Details *****");
            WriteLine($"Id: {person.Id} \nName: {person.Name} \nSalary: {person.Salary}");

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
