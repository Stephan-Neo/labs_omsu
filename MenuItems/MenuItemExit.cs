namespace ConsoleApp.MenuItems
{
    public class MenuItemExit : MenuItemCore
    {
        public override string Title => "Exit";

        public override void Execute()
        {
            Console.WriteLine("Exit...");
            Environment.Exit(0);
        }
    }
}
