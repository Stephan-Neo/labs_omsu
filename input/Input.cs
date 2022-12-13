using System;
using ConsoleApp1.helpers;
using Error = ConsoleApp1.helpers.Error;
using Task = ConsoleApp1.tasks.Task;
using System.Text.RegularExpressions;

namespace ConsoleApp1.input
{
    public class Input: Task
    {
        public static void InputCalculateFormula()
        {
            Console.Clear();

            do{
                Console.WriteLine($"\nFormula: {formula}");
                Console.Write("\nInput X: ");
                string inputX = Console.ReadLine();

                if(inputX == ""){
                    Error.PirntError("X != empty string");
                }

                else if(inputX == "0"){
                    Error.PirntError("X dont = 0");
                }

                else if(!double.TryParse(inputX, out double numericValueX)){
                    Error.PirntError("X must be a number");
                }

                else{
                    X = Convert.ToDouble(inputX);
                    break;
                }


            } while(true);

            do{
                Console.WriteLine($"\nFormula: {formula}");
                Console.Write("\nInput Y: ");
                string inputY = Console.ReadLine();

                if(inputY == ""){
                    Error.PirntError("Y != empty string");
                }

                else if(!double.TryParse(inputY, out double numericValueY)){
                    Error.PirntError("Y must be a number");
                }

                else if(Convert.ToDouble(inputY) <= 0){
                    Error.PirntError("Y dont < 0");
                }

                else{
                    Y = Convert.ToDouble(inputY);
                    break;
                }


            } while(true);

            do{
                Console.WriteLine($"\nFormula: {formula}");
                Console.Write("\nInput Z: ");
                string inputZ = Console.ReadLine();

                if(inputZ == ""){
                    Error.PirntError("Z != empty string");
                }

                else if(!double.TryParse(inputZ, out double numericValueZ)){
                    Error.PirntError("Z must be a number");
                }

                else{
                    Z = Convert.ToDouble(inputZ);
                    break;
                }


            } while(true);
        }
        
        public static void InputDate()
         {
             do{
			    Console.Write("\nInput Date 1 (MM.DD.YYYY): ");
			    string inputDate = Console.ReadLine();

			    if(inputDate == ""){
				    Error.PirntError("Error!!! date != empty string");
			    }

                else if(!DateOnly.TryParse(inputDate, out DateOnly dateOnly)){
                    Error.PirntError("Error!!! invalid date format");
                }

			    else{
				    firstStartDate = Convert.ToDateTime(inputDate);
				    break;
			    }
             } while(true);
             do{
			    Console.Write("\nInput Date 2 (MM.DD.YYYY): ");
			    string inputDate = Console.ReadLine();

			    if(inputDate == ""){
                    Error.PirntError("Error!!! date != empty string");
			    }

                else if(!DateOnly.TryParse(inputDate, out DateOnly dateOnly)){
                    Error.PirntError("Error!!! invalid date format");
                }

                else if(Convert.ToDateTime(inputDate) <= firstStartDate){
                    Error.PirntError("Error!!! Date 2 <= Date 1");
                }

			    else{
				    firstEndDate = Convert.ToDateTime(inputDate);
				    break;
			    }
             } while(true);
             do{
			    Console.Write("\nInput Date 3 (MM.DD.YYYY): ");
			    string inputDate = Console.ReadLine();

			    if(inputDate == ""){
                    Error.PirntError("Error!!! date != empty string");
			    }

                else if(!DateOnly.TryParse(inputDate, out DateOnly dateOnly)){
                    Error.PirntError("Error!!! invalid date format");
                }

			    else{
				    secondStartDate = Convert.ToDateTime(inputDate);
				    break;
			    }
             } while(true);
             do{
			    Console.Write("\nInput Date 4 (MM.DD.YYYY): ");
			    string inputDate = Console.ReadLine();

			    if(inputDate == ""){
                    Error.PirntError("Error!!! date != empty string");
			    }

                else if(!DateOnly.TryParse(inputDate, out DateOnly dateOnly)){
                    Error.PirntError("Error!!! invalid date format");
                }

                else if(Convert.ToDateTime(inputDate) <= secondStartDate){
                    Error.PirntError("Error!!! Error!!! Date 4 <= Date 2");
                }

			    else{
				    secondEndDate = Convert.ToDateTime(inputDate);
				    break;
			    } } while(true);
         }
        
        public static void InputStrings(){
            Console.Clear();
            do{
                Console.Write("\nInput string A: ");
                string? inputAString = Console.ReadLine();

                if(inputAString == ""){
                    Error.PirntError("Error!!! string != empty string");
                }else{
                    stringA = inputAString;
                    break;
                }
            } while(true);

            do{
                Console.Write("\nInput string B: ");
                string inputBString = Console.ReadLine();

                if(inputBString == ""){
                    Error.PirntError("Error!!! string != empty string");
                }else{
                    stringB = inputBString;
                    break;
                }
            } while(true);

        }
    }
}