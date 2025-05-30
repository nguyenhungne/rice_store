using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.utils;

public interface IPurchaseOrderDetailService
{
    Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync();
    Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync(int inventoryID);
    Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id);
    Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId, PurchaseOrderDetailFilter? filter = null);
    Task<List<PurchaseOrderDetail>> orderPurchaseOrderAsync(List<AddingProductsData> addingProducts);
    Task<PurchaseOrderDetail> AddPurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task<PurchaseOrderDetail> UpdatePurchaseOrderDetailAsync(PurchaseOrderDetail detail);
    Task DeletePurchaseOrderDetailAsync(int id);
    Task UpdateQuantityPurchaseOrderDetailAsync(int PurchaseDetailId, decimal quantity);
}

public class PurchaseOrderDetailService : IPurchaseOrderDetailService
{
    private readonly IPurchaseOrderDetailRepository _repository;
    private readonly IPurchaseOrderRepository _purchaseOrderRepository;
    private readonly IWarehouseRepository _warehouseRepository;

    public PurchaseOrderDetailService(IPurchaseOrderDetailRepository repository, IPurchaseOrderRepository purchaseOrderRepository, IWarehouseRepository warehouseRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
        _repository = repository;
        _warehouseRepository = warehouseRepository;
    }


    public async Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync()
    {
        return await _repository.GetAllPurchaseOrderDetailsAsync();
    }

    public async Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id)
    {
        return await _repository.GetPurchaseOrderDetailByIdAsync(id);
    }

    public async Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId, PurchaseOrderDetailFilter? filter = null)
    {
        return await _repository.GetPurchaseOrderDetailByWarehouseIdAsync(warehouseId, filter);
    }

    public async Task<List<PurchaseOrderDetail>> orderPurchaseOrderAsync(List<AddingProductsData> addingProducts)
{
    List<PurchaseOrderDetail> purchaseOrderDetails = new List<PurchaseOrderDetail>();
    foreach (AddingProductsData addingProduct in addingProducts)
    {
        AddingPurchaseOrderData addingPurchaseOrderData = addingProduct.purchaseOrder;
        PurchaseOrder purchaseOrder = new PurchaseOrder
        {
            OrderDate = addingPurchaseOrderData.orderDate,
            Status = "Completed", // Assuming "Completed" is the status for a new order
            SupplierId = addingPurchaseOrderData.supplierId,
        };
        PurchaseOrder newPurchaseOrder = await _purchaseOrderRepository.AddPurchaseOrderAsync(purchaseOrder);

        AddingWarehouseData addingWarehouseData = addingProduct.warehouse;

        Warehouse? existingWarehouse = await _warehouseRepository.GetWarehouseByProductAndInventoryIdAsync(
            addingWarehouseData.productId,
            addingWarehouseData.inventoryId
        );

        Warehouse newWarehouse;
        if (existingWarehouse != null)
        {
            newWarehouse = existingWarehouse;
        }
        else
        {
            newWarehouse = new Warehouse
            {
                ProductId = addingWarehouseData.productId,
                InventoryId = addingWarehouseData.inventoryId,
                BatchNumber = WarehouseUtil.GenerateBatchNumber(addingWarehouseData.productName),
                //MinThreshold = addingWarehouseData.minThreshold,
                ExpirationDate = addingWarehouseData.expirationDate,
            };
            newWarehouse = await _warehouseRepository.AddWarehouseAsync(newWarehouse);
        }

        AddingPurchaseOrderDetailData addingPurchaseOrderDetailData = addingProduct.purchaseOrderDetail;
        PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail
        {
            PurchaseOrderId = newPurchaseOrder.Id,
            WarehouseId = newWarehouse.Id,
            Quantity = addingPurchaseOrderDetailData.quantity,
            UnitPrice = addingPurchaseOrderDetailData.unitPrice,
            ExpirationDate = addingWarehouseData.expirationDate,
            QuantityRemaining = addingPurchaseOrderDetailData.quantityRemaining,
        };
        PurchaseOrderDetail newPurchaseOrderDetail = await _repository.AddPurchaseOrderDetailAsync(purchaseOrderDetail);
        purchaseOrderDetails.Add(newPurchaseOrderDetail);
    }

    return purchaseOrderDetails;
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

    public async Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync(int inventoryID)
    {
        IEnumerable<Warehouse> warehouses = await _warehouseRepository.GetWarehousesByInventoryIdAsync(inventoryID);
        IEnumerable<int> warehouseIds = warehouses.Select(w => w.Id); // Extract the Ids from the warehouses
        return await _repository.GetPurchaseOrderDetailsOfEachInventoryAsync(warehouseIds);
    }

    public async Task UpdateQuantityPurchaseOrderDetailAsync(int purchaseDetailId, decimal quantity)
    {
        await _repository.UpdateQuantityPurchaseOrderDetailAsync(purchaseDetailId, quantity);
    }
}
