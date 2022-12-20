using System;

namespace ConsoleApp.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        public override string Title => "Hello World!";

        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
