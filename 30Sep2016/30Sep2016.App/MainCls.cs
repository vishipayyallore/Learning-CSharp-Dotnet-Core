using _30Sep2016.Lib;
using static System.Console;

namespace _30Sep2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;
            const string output = "Hello .Net Core!!!";

            WriteLine($"{output}");
            //const string siteUrl = "https://www.AAA.com/en-in/";
            //const string pageName = "";
            const string siteUrl = "https://in.YYY.com/?p=us";
            const string pageName = "Home";
            var getContent = new GetWebSiteContent();
            getContent.Run(siteUrl, pageName);

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}
