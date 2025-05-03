using rice_store.services.type;
using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.utils;

public class PurchaseOrderService
{
    private readonly IPurchaseOrderRepository  _purchaseOrderRepository;

    public PurchaseOrderService(IPurchaseOrderRepository purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<List<PurchaseReportDTO>> GetFilteredPurchaseDataAsync(int startMonth, int endMonth, int year)
    {
        return await _purchaseOrderRepository.GetFilteredPurchaseDataAsync(startMonth, endMonth, year);
    }
}
