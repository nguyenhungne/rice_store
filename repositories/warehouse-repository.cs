using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

public class WarehouseRepository : IWarehouseRepository
{
    private readonly AppDbContext _context;

    public WarehouseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Warehouse>> GetAllWarehousesAsync(int? inventoryId, WarehouseFilter filter = null)
    {
        if (filter != null)
        {
            var query = _context.Warehouse.AsQueryable();

            if (inventoryId.HasValue)
            {
                query = query.Where(w => !inventoryId.HasValue || w.InventoryId == inventoryId.Value);
            }

            if (filter.productName != null)
            {
                query = query.Where(w => w.Product.Name.Contains(filter.productName));
            }

            return await query.Include(w => w.Product)
                              .Include(w => w.Inventory)
                              .Include(w => w.PurchaseOrderDetails)
                              .ToListAsync();
        }

        return await _context.Warehouse
            .Where(w => !inventoryId.HasValue || w.InventoryId == inventoryId.Value)
            .Include(w => w.Product)
            .Include(w => w.Inventory)
            .Include(w => w.PurchaseOrderDetails)
            .ToListAsync();
    }

    public async Task<IEnumerable<Warehouse>> GetAllWarehousesWithoutFilterAsync()
    {
        return await _context.Warehouse
            .Include(w => w.Product)
            .Include(w => w.Inventory)
            .Include(w => w.PurchaseOrderDetails)
            .ToListAsync();
    }

    public async Task<Warehouse?> GetWarehouseByProductAndInventoryIdAsync(int productId, int inventoryId)
    {
        var warehouse = await _context.Warehouse
                                      .Include(w => w.Product)
                                      .Include(w => w.Inventory)
                                      .Include(w => w.PurchaseOrderDetails)
                                      .FirstOrDefaultAsync(w => w.ProductId == productId && w.InventoryId == inventoryId);

        return warehouse;
    }

    public async Task<Warehouse> GetWarehouseByIdAsync(int id)
    {
        var warehouse = await _context.Warehouse
                                      .Include(w => w.Product)
                                      .Include(w => w.Inventory)
                                      .Include(w => w.PurchaseOrderDetails)
                                      .FirstOrDefaultAsync(w => w.Id == id);
        if (warehouse == null)
        {
            throw new InvalidOperationException($"Warehouse with ID {id} not found.");
        }

        return warehouse;
    }

    public async Task<Warehouse> AddWarehouseAsync(Warehouse warehouse)
    {
        _context.Warehouse.Add(warehouse);
        await _context.SaveChangesAsync();
        return warehouse;
    }

    public async Task<Warehouse> UpdateWarehouseAsync(Warehouse warehouse)
    {
        var existingWarehouse = await _context.Warehouse.FindAsync(warehouse.Id);
        if (existingWarehouse == null)
        {
            throw new InvalidOperationException($"Warehouse with ID {warehouse.Id} not found.");
        }

        existingWarehouse.BatchNumber = warehouse.BatchNumber;
        existingWarehouse.MinThreshold = warehouse.MinThreshold;
        existingWarehouse.ExpirationDate = warehouse.ExpirationDate;
        existingWarehouse.ProductId = warehouse.ProductId;
        existingWarehouse.InventoryId = warehouse.InventoryId;

        await _context.SaveChangesAsync();
        return existingWarehouse;
    }

    public async Task DeleteWarehouseAsync(int id)
    {
        var warehouse = await _context.Warehouse.FindAsync(id);
        if (warehouse == null)
        {
            throw new InvalidOperationException($"Warehouse with ID {id} not found.");
        }

        _context.Warehouse.Remove(warehouse);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Warehouse>> GetWarehousesByInventoryIdAsync(int inventoryId)
    {
        return await _context.Warehouse
                             .Where(w => w.InventoryId == inventoryId)
                             .ToListAsync();
    }
}
