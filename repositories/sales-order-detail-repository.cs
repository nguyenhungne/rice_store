using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

public class SalesOrderDetailRepository : ISalesOrderDetailRepository
{
    private readonly AppDbContext _context;

    public SalesOrderDetailRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync()
    {
        return await _context.SalesOrderDetail
            .Include(s => s.SalesOrder)
            .ThenInclude(so => so.Customer)
            .Include(s => s.Warehouse)
            .ThenInclude(w => w.Product)
            .ThenInclude(p => p.Category)
            .ToListAsync();
    }

    public async Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id)
    {
        var salesOrderDetail = await _context.SalesOrderDetail
            .FirstOrDefaultAsync(s => s.Id == id);

        if (salesOrderDetail == null)
        {
            throw new KeyNotFoundException($"SalesOrderDetail with Id {id} was not found.");
        }

        return salesOrderDetail;
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId)
    {
        return await _context.SalesOrderDetail
            .Where(s => s.WarehouseId == warehouseId)
            .Include(s => s.SalesOrder)
            .Include(s => s.Warehouse)
            .ToListAsync();
    }

    public async Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail)
    {
        _context.SalesOrderDetail.Add(salesOrderDetail);
        await _context.SaveChangesAsync();
        return salesOrderDetail;
    }

    public async Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail)
    {
        _context.SalesOrderDetail.Update(salesOrderDetail);
        await _context.SaveChangesAsync();
        return salesOrderDetail;
    }

    public async Task DeleteSalesOrderDetailAsync(int id)
    {
        var salesOrderDetail = await GetSalesOrderDetailByIdAsync(id);
        _context.SalesOrderDetail.Remove(salesOrderDetail);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailByOrderID(int OrderId)
    {
        return await _context.SalesOrderDetail
            .Where(s => s.SalesOrderId == OrderId)
            .ToListAsync();
    }
}
