using System;
using System.Linq;

namespace ConsoleApp1.helpers
{
    public static class Error
    {
        public static void PirntError(string error)
        {	
            Console.Clear();
            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
            Console.WriteLine($"	{error}");
            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

        }
    }
}