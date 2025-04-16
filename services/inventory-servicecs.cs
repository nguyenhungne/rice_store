using rice_store.models;

public interface IInventoryService
{
    Task<IEnumerable<Inventory>> GetAllInventoriesAsync(InventoryFilter filter);
    Task<Inventory> GetInventoryByIdAsync(int id);
    Task<Inventory> AddInventoryAsync(Inventory inventory);
    //Task<Inventory> UpdateInventoryAsync(Inventory inventory);
    //Task DeleteInventoryAsync(int id);
}

public class InventoryService : IInventoryService
{
    private readonly IInventoryRepository _inventoryRepository;
    public InventoryService(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    public async Task<IEnumerable<Inventory>> GetAllInventoriesAsync(InventoryFilter filter)
    {
        return await _inventoryRepository.GetAllInventoriesAsync(filter);
    }
    public async Task<Inventory> GetInventoryByIdAsync(int id)
    {
        return await _inventoryRepository.GetInventoryByIdAsync(id);
    }
    public async Task<Inventory> AddInventoryAsync(Inventory inventory)
    {
        return await _inventoryRepository.AddInventoryAsync(inventory);
    }
}
