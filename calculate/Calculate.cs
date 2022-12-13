using System;
using Task = ConsoleApp1.tasks.Task;

namespace ConsoleApp1.calculate
{
    public class Calculate: Task
    {
        public static void CalculateFormula (double x, double y, double z)
        {
            double rezult = (x / x) + (7 * Math.Sqrt(y)); 
            double rezultRound = Math.Round(rezult, 3, MidpointRounding.ToEven);
            Console.WriteLine($"\nRezult: {rezultRound}");
        }
        
        public static void CalculateIntersectionDates(DateTime date_1, DateTime date_2, DateTime date_3, DateTime date_4)
        {
            if(date_3 >= date_1 && date_4 <= date_2){
                string ?stringN = Convert.ToString(date_4 - date_3);
                N = Convert.ToDouble(stringN?.Substring(0, stringN.Length - 9)) + 1;
            }
		
            else if(date_3 < date_2 && date_4 <= date_2 | date_3 >= date_1 && date_4 > date_1){
                if(date_3 < date_2 && date_4 <= date_2){
                    string ?stringN = Convert.ToString(date_4 - date_1);
                    N = Convert.ToDouble(stringN?.Substring(0, stringN.Length - 9)) + 1;
                }
		
                else{
                    string ?stringN = Convert.ToString(date_2 - date_3);
                    N = Convert.ToDouble(stringN?.Substring(0, stringN.Length - 9)) + 1;
                }
            }

            else{
                if((date_3 > date_2 && date_4 > date_2) | (date_3 < date_1 && date_4 < date_1)){
                    N = 0;
                }
                else{
                    string ?stringN = Convert.ToString(date_2 - date_1);
                    N = Convert.ToDouble(stringN?.Substring(0, stringN.Length - 9)) + 1;
                }
            }
        }

        public static void CalculatePrimeNumber()
        {
            Console.Clear();

            for (int i = 2; i <= Math.Sqrt(N); i+=1) {
                if (X % i == 0) {
                    Console.WriteLine($"\n {N} doesn't prime number, since it is divided into {i}. NO");
                    return;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
            Console.WriteLine($"	N: {N}");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));

            Console.WriteLine($"\n {N} have prime number. YES");
        }
    }
}