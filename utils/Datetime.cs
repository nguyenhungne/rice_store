using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rice_store.utils
{
    public static class DatetimeUtil
    {
        public static int GetMonthNumber(string monthName)
        {
            Dictionary<string, int> months = new Dictionary<string, int>
    {
        { "January", 1 },
        { "February", 2 },
        { "March", 3 },
        { "April", 4 },
        { "May", 5 },
        { "June", 6 },
        { "July", 7 },
        { "August", 8 },
        { "September", 9 },
        { "October", 10 },
        { "November", 11 },
        { "December", 12 }
    };

            // Ensure the month name is valid and return the corresponding month number
            if (months.ContainsKey(monthName))
            {
                return months[monthName];
            }

            throw new ArgumentException("Invalid month name.");
        }
    }
}
