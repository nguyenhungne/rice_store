using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.models;

public interface IPurchaseOrderRepository
{
    Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync();
    Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id);
    Task<PurchaseOrder> AddPurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task<PurchaseOrder> UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task DeletePurchaseOrderAsync(int id);
}
