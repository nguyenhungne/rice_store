using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using rice_store.data;
using rice_store.models;

public class PurchaseOrderRepository : IPurchaseOrderRepository
{
    private readonly AppDbContext _context;

    public PurchaseOrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync()
    {
        return await _context.PurchaseOrder
            .Include(po => po.Supplier)
            .ToListAsync();
    }

    public async Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id)
    {
        PurchaseOrder? purchaseOrder = await _context.PurchaseOrder
            .Include(po => po.Supplier) // Include Supplier data
            .FirstOrDefaultAsync(po => po.Id == id);

        return purchaseOrder ?? throw new InvalidOperationException($"Purchase Order with ID {id} not found.");
    }

    public async Task<PurchaseOrder> AddPurchaseOrderAsync(PurchaseOrder purchaseOrder)
    {
        _context.PurchaseOrder.Add(purchaseOrder);
        await _context.SaveChangesAsync();
        return purchaseOrder;
    }

    public async Task<PurchaseOrder> UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder)
    {
        PurchaseOrder? existingOrder = await _context.PurchaseOrder.FindAsync(purchaseOrder.Id);
        if (existingOrder == null)
        {
            throw new InvalidOperationException($"Purchase Order with ID {purchaseOrder.Id} not found.");
        }

        existingOrder.OrderDate = purchaseOrder.OrderDate;
        existingOrder.Status = purchaseOrder.Status;
        existingOrder.SupplierId = purchaseOrder.SupplierId;

        await _context.SaveChangesAsync();
        return existingOrder;
    }

    public async Task DeletePurchaseOrderAsync(int id)
    {
        PurchaseOrder? purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
        if (purchaseOrder == null)
        {
            throw new InvalidOperationException($"Purchase Order with ID {id} not found.");
        }

        _context.PurchaseOrder.Remove(purchaseOrder);
        await _context.SaveChangesAsync();
    }
}
