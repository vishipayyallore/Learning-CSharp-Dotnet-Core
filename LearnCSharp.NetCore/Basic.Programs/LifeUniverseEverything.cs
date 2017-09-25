using Programs.CoreLibrary;
using static System.Console;

namespace Basic.Programs
{
    public class LifeUniverseEverything : IProgram
    {
        public void Run()
        {
            do
            {
                var number = int.Parse(ReadLine().Trim());
                if(number == 42) { break; }
                WriteLine(number);
            } while (true);
        }
    }
}
