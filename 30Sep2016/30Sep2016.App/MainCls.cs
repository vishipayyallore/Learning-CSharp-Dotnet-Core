using System.Linq;
using System.Reflection;
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
            const string assemblyName = "30Sep2016.Lib";
            const string siteUrl = "https://in.YYY.com/?p=us";
            const string pageName = "";

            WriteLine($"Variable Name: {nameof(output)} :: Value: {output}");
            GetAssemblyInformation(assemblyName);

            DescribeMe.Run();

            var getContent = new GetWebSiteContent();
            getContent.Run(siteUrl, pageName);

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }

        #region Private Methods.
        private static void GetAssemblyInformation(string assemblyName)
        {
            var assemblyList = Assembly.GetEntryAssembly().GetReferencedAssemblies();
            foreach (var assembly in assemblyList.Where(assembly => assembly.Name == assemblyName))
            {
                WriteLine($"Current Assembly: {assembly.FullName} {assembly.Name} ------");
                var theAssembly = Assembly.Load(new AssemblyName(assembly.FullName));

                foreach (var definedType in theAssembly.DefinedTypes)
                {
                    WriteLine($"{definedType.Name} {definedType.FullName} {definedType.DeclaredMethods.Count()}");
                }
            }
        }
        #endregion

    }
}
