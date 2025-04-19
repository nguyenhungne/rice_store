using rice_store.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IWarehouseRepository
{
    Task<IEnumerable<Warehouse>> GetAllWarehousesAsync(int? inventoryId, WarehouseFilter filter = null);
    Task<Warehouse> GetWarehouseByIdAsync(int id);
    Task<Warehouse> AddWarehouseAsync(Warehouse warehouse);
    Task<Warehouse> UpdateWarehouseAsync(Warehouse warehouse);
    Task<Warehouse?> GetWarehouseByProductAndInventoryIdAsync(int productId, int inventoryId);
    Task DeleteWarehouseAsync(int id);
}
