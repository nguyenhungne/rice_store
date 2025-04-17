using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPurchaseOrderDetailService
{
    Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync();
    Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id);
    Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId);
    Task<PurchaseOrderDetail> AddPurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task<PurchaseOrderDetail> UpdatePurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task DeletePurchaseOrderDetailAsync(int id);
}

public class PurchaseOrderDetailService : IPurchaseOrderDetailService
{
    private readonly IPurchaseOrderDetailRepository _repository;

    public PurchaseOrderDetailService(IPurchaseOrderDetailRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync()
    {
        return await _repository.GetAllPurchaseOrderDetailsAsync();
    }

    public async Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id)
    {
        return await _repository.GetPurchaseOrderDetailByIdAsync(id);
    }

    public async Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId)
    {
        return await _repository.GetPurchaseOrderDetailByWarehouseIdAsync(warehouseId);
    }

    public async Task<PurchaseOrderDetail> AddPurchaseOrderDetailAsync(PurchaseOrderDetail detail)
    {
        return await _repository.AddPurchaseOrderDetailAsync(detail);
    }

    public async Task<PurchaseOrderDetail> UpdatePurchaseOrderDetailAsync(PurchaseOrderDetail detail)
    {
        return await _repository.UpdatePurchaseOrderDetailAsync(detail);
    }

    public async Task DeletePurchaseOrderDetailAsync(int id)
    {
        await _repository.DeletePurchaseOrderDetailAsync(id);
    }
}
