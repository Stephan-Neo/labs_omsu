using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Task = ConsoleApp1.tasks.Task;

namespace ConsoleApp1.validation
{
	public class ValidateStrings: Task
	{
		public void isSame(string A, string B)
		{
			if(A != B){
				throw new ValidationException($"{A} != {B}");
			}
		}
		
		public void isNotSpaceLow(string ANotSpaceLow, string BNotSpaceLow)
		{
			if(ANotSpaceLow != BNotSpaceLow){
				throw new ValidationException($"{ANotSpaceLow} != {BNotSpaceLow}");
			}
			
		}
		
		public void isRevNotSpaceLow(string A, string B)
		{
			if(A != B){
				throw new ValidationException($"{A} != {B}");
			}
		}
		
		public void isRegex(
			MatchCollection matchesAEmail,
			MatchCollection matchesAPhone,
			MatchCollection matchesAIp,
			MatchCollection matchesBEmail,
			MatchCollection matchesBPhone,
			MatchCollection matchesBIp)
		{
			Regex = false;
			
			if (matchesAEmail.Count > 0)
			{
				foreach (Match match in matchesAEmail)
					Console.WriteLine($"\n{match.Value} it's Email");
				Regex = true;
			}
	        
			if (matchesAPhone.Count > 0){
				foreach (Match match in matchesAPhone)
					Console.WriteLine($"\n{match.Value} it's Phone Number");
				Regex = true;
			}
	        
			if (matchesAIp.Count > 0){
				foreach (Match match in matchesAIp)
					Console.WriteLine($"\n{match.Value} it's Ip");
				Regex = true;
			}
	        
			if (matchesBEmail.Count > 0){
				foreach (Match match in matchesBEmail)
					Console.WriteLine($"\n{match.Value} it's Email");
				Regex = true;
			}

			if (matchesBPhone.Count > 0){
				foreach (Match match in matchesBPhone)
					Console.WriteLine($"\n{match.Value} it's Phone Number");
				Regex = true;
			}
	        
			if (matchesBIp.Count > 0){
				foreach (Match match in matchesBIp)
					Console.WriteLine($"\n{match.Value} it's Ip");
				Regex = true;
			}

			if (!Regex)
			{
				throw new ValidationException($"NOT Regex");
			}
		}
	}


	public class Strings
	{
	    public static void Same(string? A, string? B){

	        string ANotSpaceLow = A.Replace(" ", "").ToLower();
	        string BNotSpaceLow = B.Replace(" ", "").ToLower();

	        Regex regexEmail = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
	        Regex regexPhone = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
	        Regex regexIp = new Regex(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");

	        MatchCollection matchesAEmail = regexEmail.Matches(A);
	        MatchCollection matchesAPhone = regexPhone.Matches(A);
	        MatchCollection matchesAIp = regexIp.Matches(A);

	        MatchCollection matchesBEmail = regexEmail.Matches(B);
	        MatchCollection matchesBPhone = regexPhone.Matches(B);
	        MatchCollection matchesBIp = regexIp.Matches(B);

	        string ARevNotSpaceLow = new string(ANotSpaceLow.Reverse().ToArray());

	        CheckSame(A, B);
	        
	        CheckNotSpaceLow(ANotSpaceLow, BNotSpaceLow);
	        
	        CheckRevNotSpaceLow(ARevNotSpaceLow, BNotSpaceLow);
	        
			CheckRegex(matchesAEmail, matchesAPhone, matchesAIp, matchesBEmail, matchesBPhone, matchesBIp);
	    }

	    private static void CheckSame(string A, string B)
	    {
		    ValidateStrings validate = new ValidateStrings();
		    try
		    {
			    validate.isSame(A, B);
			    
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
			    Console.WriteLine($"\nIt's same strings");
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
		    }
		    catch(ValidationException vx)
		    {	
			    Console.WriteLine(" ");
			    Console.WriteLine($"	1) {vx.Message}");
			    Console.WriteLine(" ");
		    }
	    }
	    private static void CheckNotSpaceLow(string A, string B)
	    {
		    ValidateStrings validate = new ValidateStrings();
		    try
		    {
			    validate.isNotSpaceLow(A, B);
			    
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
			    Console.WriteLine($"\nIt's same strings not space and in low register. {A} == {B}");
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
		    }
		    catch(ValidationException vx)
		    {	
			    Console.WriteLine(" ");
			    Console.WriteLine($"	2) {vx.Message}");
			    Console.WriteLine(" ");
		    }
	    }
	    
	    private static void CheckRevNotSpaceLow(string A, string B)
	    {
		    ValidateStrings validate = new ValidateStrings();
		    try
		    {
			    validate.isRevNotSpaceLow(A, B);
			    
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
			    Console.WriteLine($"\nIt's REVERSE strings. {A} == {B}");
			    Console.WriteLine(" ");
			    Console.WriteLine(String.Concat(Enumerable.Repeat("*", 20)));
		    }
		    catch(ValidationException vx)
		    {	
			    Console.WriteLine(" ");
			    Console.WriteLine($"	3) {vx.Message}");
			    Console.WriteLine(" ");
		    }
	    }

	    private static void CheckRegex(
		    MatchCollection matchesAEmail,
		    MatchCollection matchesAPhone,
		    MatchCollection matchesAIp,
		    MatchCollection matchesBEmail,
		    MatchCollection matchesBPhone,
		    MatchCollection matchesBIp)
	    {
		    ValidateStrings validate = new ValidateStrings();
		    try
		    {
			    validate.isRegex(
				    matchesAEmail,
				    matchesAPhone,
				    matchesAIp,
				    matchesBEmail,
				    matchesBPhone,
				    matchesBIp
			    );
		    }
		    catch (ValidationException vx)
		    {
			    Console.WriteLine(" ");
			    Console.WriteLine($"	4) {vx.Message}");
			    Console.WriteLine(" ");
		    }
	    }
	}
}

