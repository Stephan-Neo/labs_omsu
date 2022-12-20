using ConsoleApp.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public static class Menu
    {
        private static readonly List<MenuItemCore> MenuItems = new List<MenuItemCore>();

        public static int ItemsCount => MenuItems.Count();

        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItemCore menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        public static void Execute()
        {
            int iMenu = IOUtils.SafeReadInteger(null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                Menu.MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("Menu item not found.");
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("=== MENU ===");

            int iMenuItem = 1;
            foreach (MenuItemCore menuItem in Menu.MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}