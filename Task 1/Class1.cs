using System;
using static System.Console;

namespace Library
{
    public class Commands
    {
        public static void Print(string value)
        {
            WriteLine(value);
        }

        public static int GetInt()
        {
            return Int32.Parse(ReadLine());
        }

        public static string GetStr()
        {
            return ReadLine();
        }

        public static void Pause()
        {
            ReadKey();
        }

     
    }
}
