using System.Linq;
using System.Reflection;
using static System.Console;

namespace _30Sep2016.Lib
{
    public class DescribeMe
    {
        public static void Run()
        {
            foreach (var referencedAssembly in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                WriteLine($"Current Assembly: \n\t{referencedAssembly.FullName} {referencedAssembly.Name} ------");
                WriteLine($"Defined Type: -----");
                foreach (var definedType in Assembly.Load(new AssemblyName(referencedAssembly.FullName)).DefinedTypes)
                {
                    WriteLine($"\t{definedType.Name} {definedType.FullName} {definedType.DeclaredMethods.Count()}");
                }
                WriteLine("");
            }
        }
    }
}
