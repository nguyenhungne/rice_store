using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.models;
using rice_store.services.type;

public interface IPurchaseOrderRepository
{
    Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync();
    Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id);
    Task<PurchaseOrder> AddPurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task<List<PurchaseReportDTO>> GetFilteredPurchaseDataAsync(int startMonth, int endMonth, int year);
    Task<PurchaseOrder> UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder);
    Task DeletePurchaseOrderAsync(int id);
}
