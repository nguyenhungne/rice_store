using System;

namespace rice_store.utils
{
    public class WarehouseStatusUtil
    {
        public static string GetWarehouseStatus(decimal quantity, int minThreshold)
        {
            if (quantity > minThreshold)
            {
                return "Còn hàng";
            }
            else if (quantity > 0 && quantity <= minThreshold)
            {
                return "Sắp hết hàng";
            }
            else
            {
                return "Hết hàng";
            }
        }
    }
}
