using System;
using System.Linq;
using Exit = ConsoleApp1.helpers.Exit;
using Task = ConsoleApp1.tasks.Task;
using Hello = ConsoleApp1.helpers.Hello;
using Error = ConsoleApp1.helpers.Error;
using Input = ConsoleApp1.input.Input;
using Calculate = ConsoleApp1.calculate.Calculate;
using Validate = ConsoleApp1.validation;

namespace ConsoleApp1.Menu
{
    public class Menu: Task
    {
        public void MenuPrint()
        {
            Console.WriteLine($"\n[0] Exit \n[1] Hello World! \n[2] Calc: {formula} \n[3] Recursion date \n[4] Strings");

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
            Console.Write("Input action: ");
            string input = Console.ReadLine();
            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

            if((Convert.ToString(input) != "" & input == "0") | (Convert.ToString(input) != "" & input == "1") | (Convert.ToString(input) != "" & input == "2" ) | (Convert.ToString(input) != "" & input == "3") | (Convert.ToString(input) != "" & input == "4"))
            {
                int action = Convert.ToInt32(input);
                switch (action)
                {
                    case 0:
                        Exit.CloseProgram();
                        break;

                    case 1:
                        Hello.PrintHello();
                        MenuPrint();
                        break;
                    
                    case 2:
                        Input.InputCalculateFormula();
                        Calculate.CalculateFormula(X, Y, Z);
                        MenuPrint();
                        break;
                    
                     
                    case 3:
                        Input.InputDate();
                        Calculate.CalculateIntersectionDates(firstStartDate, firstEndDate, secondStartDate, secondEndDate);
                        Calculate.CalculatePrimeNumber();
                        MenuPrint();
                        break;
                    
                    case 4:
                        Input.InputStrings();
                        Validate.Strings.Same(stringA, stringB);
                        MenuPrint();
                        break;
                }
            }
            else
            {
                Error.PirntError("Error!!! The wrong line");
                MenuPrint();
            }
        }
    }
}