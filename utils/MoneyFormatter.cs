using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rice_store.utils
{
    public static class MoneyFormatter
    {
        public static string FormatToVND(decimal amount)
        {
            decimal formattedAmount = amount * 1000;

            return formattedAmount.ToString("#,0") + " VND";
        }
    }
}
