using MenuItemExit = ConsoleApp.MenuItems.MenuItemExit;
using MenuItemHelloWorld = ConsoleApp.MenuItems.MenuItemHelloWorld;
using MenuItemRecursionDate = ConsoleApp.MenuItems.MenuItemRecursionDate;
using MenuItemCalc = ConsoleApp.MenuItems.MenuItemCalc;
using Strings = ConsoleApp.MenuItems.Strings;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                IDictionary<string, string> argsDic = CmdArgsParser.Parse(args);
                IOUtils.SetExtValues(argsDic);
                
                Menu.AddItem(new MenuItemExit());
                Menu.AddItem(new MenuItemHelloWorld());
                Menu.AddItem(new MenuItemCalc());                                                    
                Menu.AddItem(new MenuItemRecursionDate());
                Menu.AddItem(new Strings());


                if (argsDic != null)
                {
                    try
                    {
                        Menu.Execute();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                }
                else
                {
                    while (true)
                    {
                        Menu.ShowMenu();
                        Menu.Execute();
                    }
                }
            }

        }
    }
}