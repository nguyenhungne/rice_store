using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;

public class InventoryRepository : IInventoryRepository
{
    private readonly AppDbContext _context;
    public InventoryRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Inventory>> GetAllInventoriesAsync(InventoryFilter filter)
    {
        var query = _context.Inventory.AsQueryable();

        // Apply filter for Inventory Name if provided
        if (!string.IsNullOrEmpty(filter.inventoryName))
        {
            // Using EF.Functions.Like to perform case-insensitive search
            query = query.Where(i => EF.Functions.Like(i.name, $"%{filter.inventoryName}%"));
        }

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<Inventory>> GetAllInventoriesAsync()
    {

        return await _context.Inventory.ToListAsync();
    }

    public async Task<Inventory> GetInventoryByIdAsync(int id)
    {
        return await _context.Inventory.FindAsync(id);
    }
    public async Task<Inventory> AddInventoryAsync(Inventory inventory)
    {
        _context.Inventory.Add(inventory);
        await _context.SaveChangesAsync();
        return inventory;
    }
    public async Task<Inventory> UpdateInventoryAsync(Inventory inventory)
    {
        _context.Inventory.Update(inventory);
        await _context.SaveChangesAsync();
        return inventory;
    }
}
