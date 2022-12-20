namespace ConsoleApp
{
    public class StringException
    {
        public static bool CompareCheck(string a, string b)
        {
            if (StringUtils.compare(a, b) == true)
            {
                return true;
            }
            else
            {
                throw new Exception("Strings are not equal.");
            }
        }
        public static bool EmailCompareCheck(string a)
        {
            if (StringUtils.EmailCompare(a) == true)
            {
                return true;
            }
            else
            {
                throw new Exception(a + " is not Email adress.");
            }
        }

        public static bool PhoneCompareCheck(string a)
        {
            if (StringUtils.PhoneCompare(a) == true)
            {
                return true;
            }
            else
            {
                throw new Exception(a + " is not a Phone number.");
            }
        }

        public static bool IPv4CompareCheck(string a)
        {
            if (StringUtils.IPv4Compare(a) == true)
            {
                return true;
            }
            else
            {
                throw new Exception(a + " is not IPv4.");
            }
        }
    }
}
