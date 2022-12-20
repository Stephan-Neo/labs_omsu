namespace ConsoleApp.MenuItems
{
    public class MenuItemRecursionDate : MenuItemCore
    {
        public override string Title => "Recursion Date ( Intersection must be from 0 to 3 )";

        public override void Execute()
        {
            Console.Clear();
            while (true)
            {
                DateTime a, b;

                DateTime dateStart1 = IOUtils.SafeDateRead("Enter first date start:");
                Console.WriteLine("First start is {0}.{1}.{2}", dateStart1.Day, dateStart1.Month, dateStart1.Year);

                DateTime dateEnd1 = IOUtils.SafeDateRead("Enter first date end:");
                Console.WriteLine("First end is {0}.{1}.{2}", dateEnd1.Day, dateEnd1.Month, dateEnd1.Year);

                if (dateEnd1 < dateStart1)
                {
                    (dateEnd1, dateStart1) = (dateStart1, dateEnd1);
                    Console.WriteLine("Еhe start date and end date were reversed because the end date is less than the start date");
                }

                DateTime dateStart2 = IOUtils.SafeDateRead("Enter second date start:");
                Console.WriteLine("Second start is {0}.{1}.{2}", dateStart2.Day, dateStart2.Month, dateStart2.Year);

                DateTime dateEnd2 = IOUtils.SafeDateRead("Enter second date end:");
                Console.WriteLine("Second end is {0}.{1}.{2}", dateEnd2.Day, dateEnd2.Month, dateEnd2.Year);

                if (dateEnd2 < dateStart2)
                {
                    (dateEnd2, dateStart2) = (dateStart2, dateEnd2);
                }

                if (dateStart1 > dateStart2)
                {
                    a = dateStart1;
                }
                else
                {
                    a = dateStart2;
                }

                if (dateEnd1 < dateEnd2)
                {
                    b = dateEnd1;
                }
                else
                {
                    b = dateEnd2;
                }

                TimeSpan Intersection = b.Date - a.Date; 
                int c = Convert.ToInt32(Intersection.Days) + 1;
                if (c < 0)
                {
                    c = 0;
                }

                Console.WriteLine("Length of the segment of the intersection of dates = " + c);

                if (c > 3)
                {
                    Console.WriteLine("Enter new segments. Intersection can't be more than 3.");
                }
                else
                {

                    int Recursion = MenuItemRecursionDate.Akkerman(c, 5);
                    Console.WriteLine("Calculation of a recursive function: " + Recursion);
                    break;
                }

            }
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static int Akkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }

            if (m > 0 && n > 0)
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }

            Console.WriteLine(Akkerman(m, n));
            return Akkerman(m, n);
        }
    }
}
