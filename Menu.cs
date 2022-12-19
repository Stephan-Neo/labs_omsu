using Task = ConsoleApp1.tasks.Task;
using Error = ConsoleApp1.helpers.Error;
using Validate = ConsoleApp1.validation;

namespace ConsoleApp1.Menu
{
    public class Menu: Task
    {
        public static void MenuPrint()
        {
            Console.WriteLine($"\n[0] Exit \n[1] Hello World! \n[2] Calc: {formula} \n[3] Recursion date \n[4] Strings");

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
            Console.Write("Input action: ");
            string input = Console.ReadLine();
            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

            if((Convert.ToString(input) != "" & input == "0") | (Convert.ToString(input) != "" & input == "1") | (Convert.ToString(input) != "" & input == "2" ) | (Convert.ToString(input) != "" & input == "3") | (Convert.ToString(input) != "" & input == "4"))
            {
                int action = Convert.ToInt32(input);
                StartTask(action);
            }
            else
            {
                Error.PirntError("Error!!! The wrong line");
                MenuPrint();
            }
        }
    }
}