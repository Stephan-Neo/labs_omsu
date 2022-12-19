using ConsoleApp1.helpers;
using Exit = ConsoleApp1.helpers.Exit;
using ConsoleApp1.input;
using ConsoleApp1.calculate;
using Validate = ConsoleApp1.validation;

namespace ConsoleApp1.tasks
{
    public class Task
    {
        public static string formula = "Z/X + 7*sqrt(Y)";
        public static string stringA = "";
        public static string stringB = "";
        public static double X;
        public static double Y;
        public static double Z;
        public static double N;
        public static DateTime firstStartDate = new DateTime();
        public static DateTime firstEndDate = new DateTime();
        public static DateTime secondStartDate = new DateTime();
        public static DateTime secondEndDate = new DateTime();
        public static bool Regex;

        public static void StartTask(int n)
        {
            switch (n)
            {
                case 0:
                    Exit.CloseProgram();
                    break;

                case 1:
                    Hello.PrintHello();
                    Menu.Menu.MenuPrint();
                    break;
                    
                case 2:
                    Input.InputCalculateFormula();
                    Calculate.CalculateFormula(X, Y, Z);
                    Menu.Menu.MenuPrint();
                    break;
                
                case 3:
                    Input.InputDate();
                    Calculate.CalculateIntersectionDates(firstStartDate, firstEndDate, secondStartDate, secondEndDate);
                    Calculate.CalculatePrimeNumber();
                    Menu.Menu.MenuPrint();
                    break;
                    
                case 4:
                    Input.InputStrings();
                    Validate.Strings.Same(stringA, stringB);
                    Menu.Menu.MenuPrint();
                    break;
            }
        }
        public class Calculator
        {
            public static int Add(int x, int y) => x + y;
            public static int Subtract(int x, int y) => x - y;
        }
    }
}