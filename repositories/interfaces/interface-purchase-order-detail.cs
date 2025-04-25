using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPurchaseOrderDetailRepository
{
    Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync();
    Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id);
    Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId, PurchaseOrderDetailFilter? filter = null);
    Task<PurchaseOrderDetail> AddPurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task<PurchaseOrderDetail> UpdatePurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task DeletePurchaseOrderDetailAsync(int id);
    Task UpdateQuantityPurchaseOrderDetailAsync(int PurchaseDetailId, decimal quantity);
    Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailsOfEachInventoryAsync(IEnumerable<int> warehouseIds);
}
