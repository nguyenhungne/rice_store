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

        // Apply filter for Product Name if provided
        if (!string.IsNullOrEmpty(filter.productName))
        {
            query = query.Where(i => i.Product.Name.Contains(filter.productName));
        }

        // Apply filter for Quantity if provided
        if (filter.stockQuantity.HasValue)
        {
            query = query.Where(i => i.Quantity == filter.stockQuantity.Value);
        }

        // Include the related Category data
        return await query.Include(i => i.Product).ToListAsync();
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
