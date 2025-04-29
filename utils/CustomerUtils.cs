using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using rice_store.models;

namespace rice_store.utils
{
    class CustomerUtils
    {
        public static String GetRankCustomer(decimal total)
        {
            if (total >= 30_000_000) return "Kim cương";
            if (total >= 15_000_000) return "Vàng";
            if (total >= 10_000_000) return "Bạc";
            if (total >= 5_000_000) return "Đồng";
            return "Thường";
        }

       public static decimal GetTotalAmountAfterDiscount(decimal total, String rank)
        {
           if (rank.Equals("Đồng"))
           {
                return total - (total * 0.03m);
           }else if (rank.Equals("Bạc"))
           {
                return total - (total * 0.05m);
           }else if (rank.Equals("Vàng"))
           {
                return total - (total * 0.1m);
           }else if(rank.Equals("Kim cương"))
           {
                return total - (total * 0.15m);
           }

            return total;
        }

        public static decimal GetOriginalTotal(decimal discountedTotal, string rank)
        {
            if (rank.Equals("Đồng"))
            {
                return discountedTotal / (1 - 0.03m);
            }
            else if (rank.Equals("Bạc"))
            {
                return discountedTotal / (1 - 0.05m);
            }
            else if (rank.Equals("Vàng"))
            {
                return discountedTotal / (1 - 0.10m);
            }
            else if (rank.Equals("Kim cương"))
            {
                return discountedTotal / (1 - 0.15m);
            }

            return discountedTotal; 
        }

    }
}
