using System;

namespace rice_store.utils
{
    public static class WarehouseUtil
    {
        public static string GenerateBatchNumber(string warehouseCode)
        {
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string timePart = DateTime.Now.ToString("HHmmss");

            string randomPart = Guid.NewGuid().ToString().Substring(0, 8);

            string batchNumber = $"{datePart}-{timePart}-{warehouseCode}-{randomPart}";

            return batchNumber;
        }
    }
}
