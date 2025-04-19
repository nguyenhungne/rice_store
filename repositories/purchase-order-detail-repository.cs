using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

public class PurchaseOrderDetailRepository : IPurchaseOrderDetailRepository
{
    private readonly AppDbContext _context;

    public PurchaseOrderDetailRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PurchaseOrderDetail>> GetAllPurchaseOrderDetailsAsync()
    {
        return await _context.PurchaseOrderDetail
            .Include(p => p.PurchaseOrder)
            .Include(p => p.Warehouse)
            .ToListAsync();
    }

    public async Task<PurchaseOrderDetail> GetPurchaseOrderDetailByIdAsync(int id)
    {
        return await _context.PurchaseOrderDetail
            .Include(p => p.PurchaseOrder)
            .Include(p => p.Warehouse)
            .FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new InvalidOperationException($"PurchaseOrderDetail with ID {id} not found.");
    }

    public async Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailByWarehouseIdAsync(int warehouseId, PurchaseOrderDetailFilter? filter = null)
    {
        IQueryable<PurchaseOrderDetail> query = _context.PurchaseOrderDetail
            .Include(p => p.PurchaseOrder)
            .ThenInclude(po => po.Supplier)
            .Include(p => p.Warehouse)
            .Where(p => p.WarehouseId == warehouseId);

        // Apply filter for PurchaseOrderId if provided
        if (filter?.purchaseOrderId.HasValue == true)
        {
            query = query.Where(p => p.PurchaseOrderId == filter.purchaseOrderId.Value);
        }

        // Apply filter for SupplierId if provided
        if (filter?.supplierId.HasValue == true)
        {
            query = query.Where(p => p.PurchaseOrder.SupplierId == filter.supplierId.Value);
        }

        return await query.ToListAsync();
    }

    public async Task<PurchaseOrderDetail> AddPurchaseOrderDetailAsync(PurchaseOrderDetail detail)
    {
        _context.PurchaseOrderDetail.Add(detail);
        await _context.SaveChangesAsync();
        return detail;
    }

    public async Task<PurchaseOrderDetail> UpdatePurchaseOrderDetailAsync(PurchaseOrderDetail detail)
    {
        var existingDetail = await _context.PurchaseOrderDetail.FindAsync(detail.Id);
        if (existingDetail == null)
        {
            throw new InvalidOperationException($"PurchaseOrderDetail with ID {detail.Id} not found.");
        }

        existingDetail.Quantity = detail.Quantity;
        existingDetail.UnitPrice = detail.UnitPrice;
        existingDetail.PurchaseOrderId = detail.PurchaseOrderId;
        existingDetail.WarehouseId = detail.WarehouseId;

        await _context.SaveChangesAsync();
        return existingDetail;
    }

    public async Task DeletePurchaseOrderDetailAsync(int id)
    {
        var detail = await _context.PurchaseOrderDetail.FindAsync(id);
        if (detail == null)
        {
            throw new InvalidOperationException($"PurchaseOrderDetail with ID {id} not found.");
        }

        _context.PurchaseOrderDetail.Remove(detail);
        await _context.SaveChangesAsync();
    }
}
