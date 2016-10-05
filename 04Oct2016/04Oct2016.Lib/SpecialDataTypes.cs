using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace _04Oct2016.Lib
{

    public class SpecialDataTypes
    {
        #region Methods.
        public static void DisplayObjectType()
        {
            object doorHeight = 2.77;
            object userName = "Shiva Sai";

            WriteLine("Object Data Type -----");
            WriteLine($"User Name: {userName} \nLength of Name: {userName.ToString().Length} \nDoor Height: {doorHeight}");
        }

        public static void DisplayDynamicType()
        {
            dynamic doorHeight = 2.77;
            dynamic userName = "Ali Zafer";

            WriteLine("Dynamic Data Type -----");
            WriteLine($"User Name: {userName} \nLength of Name: {userName.Length} \nDoor Height: {doorHeight}");
        }
        #endregion
    }

}
