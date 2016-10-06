﻿using _06Oct2016.Lib;
using static System.Console;

namespace _06Oct2016.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = System.ConsoleColor.Cyan;

            (new SelectionStatements())
                .DisplaySwitchStatements();

            WriteLine("\n\nPress any key ...");
            ReadLine();
        }
    }
}