using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.validation
{
    static class YValidator
    {
        public static void IsValid(int y)
        {
            if (y < 0)
                throw new ValidationException("y can't be < 0.");
        }
    }
}
