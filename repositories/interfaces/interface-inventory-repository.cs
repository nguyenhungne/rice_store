using rice_store.models;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetAllInventoriesAsync(InventoryFilter filter);
    Task<Inventory> GetInventoryByIdAsync(int id);
    Task<Inventory> AddInventoryAsync(Inventory inventory);
    Task<Inventory> UpdateInventoryAsync(Inventory inventory);
    //Task DeleteInventoryAsync(int id);
}
