using System.Text.RegularExpressions;


namespace ConsoleApp
{
    public class StringUtils
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
        public static bool compare(string a, string b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string RemoveSpaces(string a)
        {
            a = a.ToLower();
            a = Regex.Replace(a, @"\s+", " ");
            a = a.Trim(' ');
            Console.WriteLine(a);
            return a;
        }
        public static bool EmailCompare(string a)
        {
            string mail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Match isMatch = Regex.Match(a, mail, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PhoneCompare(string a)
        {
            string PhoneNumber = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
            Match isMatch = Regex.Match(a, PhoneNumber, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IPv4Compare(string a)
        {
            string IPv4 = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            Match isMatch = Regex.Match(a, IPv4, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
