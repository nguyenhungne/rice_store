using rice_store.models;
using rice_store.utils;

using System.Collections.Generic;
using System.Threading.Tasks;

public interface IWarehouseService
{
    Task<IEnumerable<WarehouseDTO>> GetAllWarehousesAsync(int inventoryId, WarehouseFilter filter = null);
    Task<IEnumerable<WarehouseDTO>> GetAllWarehouseWithoutFilterAsync();
    Task<Warehouse> GetWarehouseByIdAsync(int id);
    Task<Warehouse> AddWarehouseAsync(Warehouse warehouse);
    Task<Warehouse> UpdateWarehouseAsync(Warehouse warehouse);
    Task DeleteWarehouseAsync(int id);
}

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;
    private readonly IPurchaseOrderDetailRepository _purchaseOrderDetailRepository;
    private readonly ISalesOrderDetailRepository _salesOrderDetailRepository;

    public WarehouseService(IWarehouseRepository warehouseRepository, IPurchaseOrderDetailRepository purchaseOrderDetailRepository, ISalesOrderDetailRepository salesOrderDetailRepository)
    {
        _warehouseRepository = warehouseRepository;
        _purchaseOrderDetailRepository = purchaseOrderDetailRepository;
        _salesOrderDetailRepository = salesOrderDetailRepository;
    }

    public async Task<IEnumerable<WarehouseDTO>> GetAllWarehousesAsync(int inventoryId, WarehouseFilter filter = null)
    {
        IEnumerable<Warehouse> warehouses = await _warehouseRepository.GetAllWarehousesAsync(inventoryId, filter);

        List<WarehouseDTO> warehouseDTOs = new List<WarehouseDTO>();

        foreach (Warehouse warehouse in warehouses)
        {
            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = await _purchaseOrderDetailRepository.GetPurchaseOrderDetailByWarehouseIdAsync(warehouse.Id);
            IEnumerable<SalesOrderDetail> salesOrderDetails = await _salesOrderDetailRepository.GetSalesOrderDetailsByWarehouseIdAsync(warehouse.Id);

            String? status = filter?.status;

            decimal totalInboundQuantity = purchaseOrderDetails.Sum(p => p.Quantity);
            decimal totalSalesQuantity = salesOrderDetails.Sum(s => s.Quantity);
            decimal quantity = totalInboundQuantity - totalSalesQuantity;

            string warehouseStatus = WarehouseStatusUtil.GetWarehouseStatus(quantity, warehouse.MinThreshold);

            if (status != null && warehouseStatus == status)
            {
                warehouseDTOs.Add(new WarehouseDTO
                {
                    Id = warehouse.Id,
                    BatchNumber = warehouse.BatchNumber,
                    MinThreshold = warehouse.MinThreshold,
                    ExpirationDate = warehouse.ExpirationDate,
                    totalInboundQuantity = totalInboundQuantity,
                    totalSalesQuantity = totalSalesQuantity,
                    Product = warehouse.Product,
                    Inventory = warehouse.Inventory,
                });
            }
            else if (status == null)
            {
                warehouseDTOs.Add(new WarehouseDTO
                {
                    Id = warehouse.Id,
                    BatchNumber = warehouse.BatchNumber,
                    MinThreshold = warehouse.MinThreshold,
                    ExpirationDate = warehouse.ExpirationDate,
                    totalInboundQuantity = totalInboundQuantity,
                    totalSalesQuantity = totalSalesQuantity,
                    Product = warehouse.Product,
                    Inventory = warehouse.Inventory,
                });
            }
        }

        return warehouseDTOs;
    }

    public async Task<IEnumerable<WarehouseDTO>> GetAllWarehouseWithoutFilterAsync()
    {
        IEnumerable<Warehouse> warehouses = await _warehouseRepository.GetAllWarehousesWithoutFilterAsync();

        List<WarehouseDTO> warehouseDTOs = new List<WarehouseDTO>();

        foreach (Warehouse warehouse in warehouses)
        {
            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = await _purchaseOrderDetailRepository.GetPurchaseOrderDetailByWarehouseIdAsync(warehouse.Id);
            IEnumerable<SalesOrderDetail> salesOrderDetails = await _salesOrderDetailRepository.GetSalesOrderDetailsByWarehouseIdAsync(warehouse.Id);

            decimal totalInboundQuantity = purchaseOrderDetails.Sum(p => p.Quantity);
            decimal totalSalesQuantity = salesOrderDetails.Sum(s => s.Quantity);
            decimal quantity = totalInboundQuantity - totalSalesQuantity;

            string warehouseStatus = WarehouseStatusUtil.GetWarehouseStatus(quantity, warehouse.MinThreshold);

            if (warehouseStatus == "Còn hàng")
            {
                warehouseDTOs.Add(new WarehouseDTO
                {
                    Id = warehouse.Id,
                    BatchNumber = warehouse.BatchNumber,
                    MinThreshold = warehouse.MinThreshold,
                    ExpirationDate = warehouse.ExpirationDate,
                    totalInboundQuantity = totalInboundQuantity,
                    totalSalesQuantity = totalSalesQuantity,
                    Product = warehouse.Product,
                    Inventory = warehouse.Inventory,
                });
            }
        }

        return warehouseDTOs;
    }

    public async Task<Warehouse> GetWarehouseByIdAsync(int id)
    {
        return await _warehouseRepository.GetWarehouseByIdAsync(id);
    }

    public async Task<Warehouse> AddWarehouseAsync(Warehouse warehouse)
    {
        return await _warehouseRepository.AddWarehouseAsync(warehouse);
    }

    public async Task<Warehouse> UpdateWarehouseAsync(Warehouse warehouse)
    {
        return await _warehouseRepository.UpdateWarehouseAsync(warehouse);
    }

    public async Task DeleteWarehouseAsync(int id)
    {
        await _warehouseRepository.DeleteWarehouseAsync(id);
    }
}
