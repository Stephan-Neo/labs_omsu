namespace ConsoleApp.MenuItems
{
    public class Strings : MenuItemCore
    {
        public override string Title => "Strings";

        public override void Execute()
        {

            Console.WriteLine("Enter first line: ");
            string Stroka1 = Console.ReadLine();
            Console.WriteLine("Enter second line: ");
            string Stroka2 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(Stroka1);
            Console.WriteLine(Stroka2);

            try
            {
                StringException.CompareCheck(Stroka1, Stroka2);
                Console.WriteLine("Strings are equal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Stroka1 = StringUtils.RemoveSpaces(Stroka1);
            Stroka2 = StringUtils.RemoveSpaces(Stroka2);

            try
            {
                StringException.CompareCheck(Stroka1, Stroka2);
                Console.WriteLine("Strings are equal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string reverse = StringUtils.ReverseString(Stroka2);

            Console.WriteLine(Stroka1);
            Console.WriteLine(reverse);
            try
            {
                StringException.CompareCheck(Stroka1, reverse);
                Console.WriteLine("Strings are equal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                StringException.EmailCompareCheck(Stroka1);
                Console.WriteLine(Stroka1 + " is Email adress.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringException.EmailCompareCheck(Stroka2);
                Console.WriteLine(Stroka2 + " is Email adress.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringException.PhoneCompareCheck(Stroka1);
                Console.WriteLine(Stroka1 + " is a Phone number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringException.PhoneCompareCheck(Stroka2);
                Console.WriteLine(Stroka2 + " is a phone number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringException.IPv4CompareCheck(Stroka1);
                Console.WriteLine(Stroka1 + " is IPv4.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringException.IPv4CompareCheck(Stroka2);
                Console.WriteLine(Stroka2 + " is IPv4.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
            

        }
        
    }
}
