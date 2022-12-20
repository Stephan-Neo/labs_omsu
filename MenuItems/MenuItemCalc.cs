namespace ConsoleApp.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title => "calc :  X / Z + Y ^ 2";

        public override void Execute()
        {
            Console.Clear();
            int x, y, z;
            Console.WriteLine("Enter the numbers to count the expression");
            x = IOUtils.SafeReadInteger("Enter x");

            y = IOUtils.SafeReadInteger("Enter y");

            z = IOUtils.SafeReadInteger("Enter z");
            while (true)
            {
                if (z == 0)
                {
                    Console.WriteLine("Incorrect number. Enter new number.");
                    Console.Write("Z = ");
                    z = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            double result = (x / (double)z) + Math.Pow(y, 2);
            Console.WriteLine($"{result:N3}");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
