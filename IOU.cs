namespace ConsoleApp;

public static class IOUtils
{
    private static IDictionary<string, string> ExternalValues = null;
    public static void SetExtValues(IDictionary<string, string> values)
    {
        ExternalValues = values;
    }
    public static int SafeReadInteger(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine(message);
        }

        while (true)
        {
            string sValue = Console.ReadLine();
            if (int.TryParse(sValue, out int iValue))
            {
                return iValue;
            }

            Console.WriteLine("ERROR: Incorrect format. Enter integer value...");

        }
    }

    public static DateTime SafeDateRead(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine(message);
        }

        while (true)
        {
            string sValue = Console.ReadLine();
            if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                return date;
            }

            Console.WriteLine("ERROR: Incorrect format. Enter correct date time...");
        }
    }
}
