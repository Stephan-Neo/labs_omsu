namespace ConsoleApp.MenuItems
{
    public abstract class MenuItemCore
    {
        public abstract string Title { get; }

        public abstract void Execute();
    }
}
